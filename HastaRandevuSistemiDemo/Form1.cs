using Microsoft.Data.SqlClient;
using System.Data;

namespace HastaRandevuSistemiDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.ExecuteSelectQuery("SELECT BransAdi FROM Branslar");

            //    comboBoxBrans.DataSource = dt;
            //    comboBoxBrans.DisplayMember = "BransAdi";
            //    comboBoxBrans.ValueMember = "BransAdi";
        }
    }
}
