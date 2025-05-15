using Microsoft.Data.SqlClient;
using System.Data;

namespace HastaRandevuSistemiDemo
{
    public partial class Form1 : Form
    {
        private bool branslarYuklendiMi = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BransDoldur();
            SaatDoldur();

            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.MinDate = DateTime.Today;
        }

        private void SaatDoldur()
        {
            cmbSaat.Items.Clear();
            cmbSaat.Items.AddRange(new string[]
            {
                "09:00", "09:30",
                "10:00", "10:30",
                "11:00", "11:30",
                "13:00", "13:30",
                "14:00", "14:30",
                "15:00", "15:30",
                "16:00", "16:30",
            });
            cmbSaat.SelectedIndex = 0;
            cmbSaat.IntegralHeight = false;
            cmbSaat.MaxDropDownItems = cmbSaat.Items.Count / 2;
        }

        private void BransDoldur()
        {
            try
            {
                DatabaseHelper db = new();
                DataTable dt = db.ExecuteSelectQuery("SELECT Id, BransAdi FROM Branslar");

                DataRow dr = dt.NewRow();
                dr["Id"] = 0;
                dr["BransAdi"] = "Seçiniz";
                dt.Rows.InsertAt(dr, 0);

                cmbBrans.DataSource = dt;
                cmbBrans.DisplayMember = "BransAdi";
                cmbBrans.ValueMember = "Id";

                branslarYuklendiMi = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBrans_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBrans.SelectedIndex == 0)
            {
                cmbDoktor.DataSource = null;
                MessageBox.Show("Lütfen bir branþ seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedBransId = Convert.ToInt32(cmbBrans.SelectedValue);
            DoktorlariYukle(selectedBransId);
        }

        private void DoktorlariYukle(int bransId)
        {
            DatabaseHelper db = new();
            string query = "SELECT Id, CONCAT(DoktorAdi, ' ', DoktorSoyadi) AS Doktor FROM Doktorlar WHERE BransId = @bransId";

            DataTable dt = db.ExecuteSelectQuery(query, new SqlParameter("@bransId", bransId));

            DataRow dr = dt.NewRow();
            dr["Id"] = 0;
            dr["Doktor"] = "Seçiniz";
            dt.Rows.InsertAt(dr, 0);

            cmbDoktor.DataSource = dt;
            cmbDoktor.DisplayMember = "Doktor";
            cmbDoktor.ValueMember = "Id";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!FormVerileriGecerliMi()) return;

            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            int bransId = Convert.ToInt32(cmbBrans.SelectedValue);
            int doktorId = Convert.ToInt32(cmbDoktor.SelectedValue);
            DateTime tarih = dtpTarih.Value.Date;
            TimeSpan saat = TimeSpan.Parse(cmbSaat.SelectedItem.ToString());

            if (DoktorCakismaVarMi(doktorId, tarih, saat)) return;
            if (HastaTekrarAyniBransaGeldiMi(ad, soyad, bransId, tarih)) return;

            RandevuKaydet(ad, soyad, bransId, doktorId, tarih, saat);
            MessageBox.Show("Randevu baþarýyla kaydedildi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormAlanlariniTemizle();
        }

        private bool FormVerileriGecerliMi()
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen ad ve soyad bilgilerini giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbBrans.SelectedIndex == 0 || cmbDoktor.SelectedIndex == 0 || cmbSaat.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen branþ, doktor ve saat seçiniz.", "Eksik Seçim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool DoktorCakismaVarMi(int doktorId, DateTime tarih, TimeSpan saat)
        {
            string sql = "SELECT COUNT(*) FROM Randevular WHERE DoktorId = @doktorId AND RandevuTarihi = @tarih AND RandevuSaati = @saat";
            int sonuc = (int)new DatabaseHelper().ExecuteScalarQuery(sql,
                new SqlParameter("@doktorId", doktorId),
                new SqlParameter("@tarih", tarih),
                new SqlParameter("@saat", saat)
            );

            if (sonuc > 0)
            {
                MessageBox.Show("Seçilen doktor bu tarihte ve saatte zaten bir randevuya sahip.", "Çakýþma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private bool HastaTekrarAyniBransaGeldiMi(string ad, string soyad, int bransId, DateTime tarih)
        {
            string sql = "SELECT COUNT(*) FROM Randevular WHERE HastaAdi = @ad AND HastaSoyadi = @soyad AND BransId = @bransId AND RandevuTarihi = @tarih";
            int sonuc = (int)new DatabaseHelper().ExecuteScalarQuery(sql,
                new SqlParameter("@ad", ad),
                new SqlParameter("@soyad", soyad),
                new SqlParameter("@bransId", bransId),
                new SqlParameter("@tarih", tarih)
            );

            if (sonuc > 0)
            {
                MessageBox.Show("Ayný branþa bir gün içinde yalnýzca bir kez randevu alabilirsiniz.", "Kýsýtlama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void RandevuKaydet(string ad, string soyad, int bransId, int doktorId, DateTime tarih, TimeSpan saat)
        {
            string query = "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransId, DoktorId, RandevuTarihi, RandevuSaati) " +
                           "VALUES (@ad, @soyad, @bransId, @doktorId, @tarih, @saat)";

            new DatabaseHelper().ExecuteInsertQuery(query,
                new SqlParameter("@ad", ad),
                new SqlParameter("@soyad", soyad),
                new SqlParameter("@bransId", bransId),
                new SqlParameter("@doktorId", doktorId),
                new SqlParameter("@tarih", tarih),
                new SqlParameter("@saat", saat)
            );
        }

        private void FormAlanlariniTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();

            cmbBrans.SelectedIndex = 0;
            cmbDoktor.DataSource = null;
            cmbDoktor.Items.Clear();

            cmbSaat.SelectedIndex = 0;

            dtpTarih.Value = DateTime.Today;
        }

    }
}
