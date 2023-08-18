namespace Yeni_Not_Kayit_Sistemi
{
    partial class FrmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitleOgrNumarasi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextOgrNumberText = new System.Windows.Forms.MaskedTextBox();
            this.girisButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitleOgrNumarasi
            // 
            this.LblTitleOgrNumarasi.AutoSize = true;
            this.LblTitleOgrNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTitleOgrNumarasi.Location = new System.Drawing.Point(59, 39);
            this.LblTitleOgrNumarasi.Name = "LblTitleOgrNumarasi";
            this.LblTitleOgrNumarasi.Size = new System.Drawing.Size(238, 29);
            this.LblTitleOgrNumarasi.TabIndex = 0;
            this.LblTitleOgrNumarasi.Text = "Ogrenci Numarasi: ";
            this.LblTitleOgrNumarasi.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // maskedTextOgrNumberText
            // 
            this.maskedTextOgrNumberText.Location = new System.Drawing.Point(303, 40);
            this.maskedTextOgrNumberText.Mask = "0000";
            this.maskedTextOgrNumberText.Name = "maskedTextOgrNumberText";
            this.maskedTextOgrNumberText.Size = new System.Drawing.Size(100, 26);
            this.maskedTextOgrNumberText.TabIndex = 2;
            this.maskedTextOgrNumberText.ValidatingType = typeof(int);
            this.maskedTextOgrNumberText.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextOgrNumberText_MaskInputRejected);
            this.maskedTextOgrNumberText.TextChanged += new System.EventHandler(this.maskedTextOgrNumberText_TextChanged);
            // 
            // girisButonu
            // 
            this.girisButonu.Location = new System.Drawing.Point(303, 91);
            this.girisButonu.Name = "girisButonu";
            this.girisButonu.Size = new System.Drawing.Size(100, 48);
            this.girisButonu.TabIndex = 3;
            this.girisButonu.Text = "Giris Yap";
            this.girisButonu.UseVisualStyleBackColor = true;
            this.girisButonu.Click += new System.EventHandler(this.frmGirisYap_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.girisButonu);
            this.Controls.Add(this.maskedTextOgrNumberText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTitleOgrNumarasi);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitleOgrNumarasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextOgrNumberText;
        private System.Windows.Forms.Button girisButonu;
    }
}