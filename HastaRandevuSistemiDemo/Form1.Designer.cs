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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBrans.Location = new Point(95, 99);
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
            lblTitle.Location = new Point(153, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Hasta Randevu Sistemi";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 29);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(171, 188);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(277, 29);
            comboBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(95, 191);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 3;
            label1.Text = "Branşlar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 681);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblBrans);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrans;
        private Label lblTitle;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
    }
}
