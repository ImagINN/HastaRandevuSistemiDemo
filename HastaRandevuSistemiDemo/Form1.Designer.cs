namespace HastaRandevuSistemiDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBrans = new Label();
            lblTitle = new Label();
            cmbBrans = new ComboBox();
            cmbDoktor = new ComboBox();
            label1 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSoyad = new TextBox();
            dtpTarih = new DateTimePicker();
            label4 = new Label();
            cmbSaat = new ComboBox();
            label5 = new Label();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBrans.Location = new Point(34, 72);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(70, 21);
            lblBrans.TabIndex = 0;
            lblBrans.Text = "Branşlar:";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.Location = new Point(294, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Hasta Randevu Sistemi";
            // 
            // cmbBrans
            // 
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(110, 69);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(277, 29);
            cmbBrans.TabIndex = 2;
            cmbBrans.SelectionChangeCommitted += cmbBrans_SelectionChangeCommitted;
            // 
            // cmbDoktor
            // 
            cmbDoktor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoktor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(512, 69);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(277, 29);
            cmbDoktor.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(427, 72);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 3;
            label1.Text = "Doktorlar:";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(110, 120);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(277, 29);
            txtAd.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(72, 123);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 6;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(450, 123);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 8;
            label3.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(512, 120);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(277, 29);
            txtSoyad.TabIndex = 7;
            // 
            // dtpTarih
            // 
            dtpTarih.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(110, 173);
            dtpTarih.MinDate = new DateTime(2025, 5, 15, 0, 0, 0, 0);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(277, 23);
            dtpTarih.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(58, 175);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 10;
            label4.Text = "Tarih:";
            // 
            // cmbSaat
            // 
            cmbSaat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbSaat.FormattingEnabled = true;
            cmbSaat.IntegralHeight = false;
            cmbSaat.Location = new Point(512, 167);
            cmbSaat.MaxDropDownItems = 4;
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(277, 29);
            cmbSaat.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(463, 170);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 11;
            label5.Text = "Saat:";
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(714, 229);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 62);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 361);
            Controls.Add(btnKaydet);
            Controls.Add(cmbSaat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpTarih);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(cmbDoktor);
            Controls.Add(label1);
            Controls.Add(cmbBrans);
            Controls.Add(lblTitle);
            Controls.Add(lblBrans);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastane Randevu Sistemi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrans;
        private Label lblTitle;
        private ComboBox cmbBrans;
        private ComboBox cmbDoktor;
        private Label label1;
        private TextBox txtAd;
        private Label label2;
        private Label label3;
        private TextBox txtSoyad;
        private DateTimePicker dtpTarih;
        private Label label4;
        private ComboBox cmbSaat;
        private Label label5;
        private Button btnKaydet;
    }
}
