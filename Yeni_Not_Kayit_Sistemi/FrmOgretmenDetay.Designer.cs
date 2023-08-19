namespace Yeni_Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1KayitGincelle = new System.Windows.Forms.Button();
            this.maskedTextBox1Numara = new System.Windows.Forms.MaskedTextBox();
            this.button1OgrKaydet = new System.Windows.Forms.Button();
            this.textBox2Soyad = new System.Windows.Forms.TextBox();
            this.textBox1Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2NotKaydet = new System.Windows.Forms.Button();
            this.textBox5Sinav2 = new System.Windows.Forms.TextBox();
            this.textBox4Sinav3 = new System.Windows.Forms.TextBox();
            this.textBox3Sinav1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblGecensayisi = new System.Windows.Forms.Label();
            this.LblKalanSayisi = new System.Windows.Forms.Label();
            this.LblOrtalama = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSINAV1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSINAV2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSINAV3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet = new Yeni_Not_Kayit_Sistemi.DbNotKayitDataSet();
            this.tBLDERSTableAdapter = new Yeni_Not_Kayit_Sistemi.DbNotKayitDataSetTableAdapters.TBLDERSTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1KayitGincelle);
            this.groupBox1.Controls.Add(this.maskedTextBox1Numara);
            this.groupBox1.Controls.Add(this.button1OgrKaydet);
            this.groupBox1.Controls.Add(this.textBox2Soyad);
            this.groupBox1.Controls.Add(this.textBox1Ad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci Ekle";
            // 
            // button1KayitGincelle
            // 
            this.button1KayitGincelle.Location = new System.Drawing.Point(71, 258);
            this.button1KayitGincelle.Name = "button1KayitGincelle";
            this.button1KayitGincelle.Size = new System.Drawing.Size(200, 50);
            this.button1KayitGincelle.TabIndex = 7;
            this.button1KayitGincelle.Text = "Kayit Guncelle";
            this.button1KayitGincelle.UseVisualStyleBackColor = true;
            this.button1KayitGincelle.Click += new System.EventHandler(this.button1KayitGincelle_Click_1);
            // 
            // maskedTextBox1Numara
            // 
            this.maskedTextBox1Numara.Location = new System.Drawing.Point(130, 43);
            this.maskedTextBox1Numara.Mask = "0000";
            this.maskedTextBox1Numara.Name = "maskedTextBox1Numara";
            this.maskedTextBox1Numara.Size = new System.Drawing.Size(141, 35);
            this.maskedTextBox1Numara.TabIndex = 7;
            this.maskedTextBox1Numara.ValidatingType = typeof(int);
            // 
            // button1OgrKaydet
            // 
            this.button1OgrKaydet.Location = new System.Drawing.Point(130, 188);
            this.button1OgrKaydet.Name = "button1OgrKaydet";
            this.button1OgrKaydet.Size = new System.Drawing.Size(141, 55);
            this.button1OgrKaydet.TabIndex = 6;
            this.button1OgrKaydet.Text = "Kaydet";
            this.button1OgrKaydet.UseVisualStyleBackColor = true;
            this.button1OgrKaydet.Click += new System.EventHandler(this.button1OgrKaydet_Click);
            // 
            // textBox2Soyad
            // 
            this.textBox2Soyad.Location = new System.Drawing.Point(130, 127);
            this.textBox2Soyad.Name = "textBox2Soyad";
            this.textBox2Soyad.Size = new System.Drawing.Size(141, 35);
            this.textBox2Soyad.TabIndex = 5;
            // 
            // textBox1Ad
            // 
            this.textBox1Ad.Location = new System.Drawing.Point(130, 86);
            this.textBox1Ad.Name = "textBox1Ad";
            this.textBox1Ad.Size = new System.Drawing.Size(141, 35);
            this.textBox1Ad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2NotKaydet);
            this.groupBox2.Controls.Add(this.textBox5Sinav2);
            this.groupBox2.Controls.Add(this.textBox4Sinav3);
            this.groupBox2.Controls.Add(this.textBox3Sinav1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(345, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not girisi";
            // 
            // button2NotKaydet
            // 
            this.button2NotKaydet.Location = new System.Drawing.Point(129, 204);
            this.button2NotKaydet.Name = "button2NotKaydet";
            this.button2NotKaydet.Size = new System.Drawing.Size(149, 48);
            this.button2NotKaydet.TabIndex = 6;
            this.button2NotKaydet.Text = "Not Kaydet";
            this.button2NotKaydet.UseVisualStyleBackColor = true;
            this.button2NotKaydet.Click += new System.EventHandler(this.button2NotKaydet_Click);
            // 
            // textBox5Sinav2
            // 
            this.textBox5Sinav2.Location = new System.Drawing.Point(129, 90);
            this.textBox5Sinav2.Name = "textBox5Sinav2";
            this.textBox5Sinav2.Size = new System.Drawing.Size(149, 35);
            this.textBox5Sinav2.TabIndex = 5;
            // 
            // textBox4Sinav3
            // 
            this.textBox4Sinav3.Location = new System.Drawing.Point(129, 137);
            this.textBox4Sinav3.Name = "textBox4Sinav3";
            this.textBox4Sinav3.Size = new System.Drawing.Size(149, 35);
            this.textBox4Sinav3.TabIndex = 4;
            // 
            // textBox3Sinav1
            // 
            this.textBox3Sinav1.Location = new System.Drawing.Point(129, 40);
            this.textBox3Sinav1.Name = "textBox3Sinav1";
            this.textBox3Sinav1.Size = new System.Drawing.Size(149, 35);
            this.textBox3Sinav1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sinav 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sinav 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sinav 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblGecensayisi);
            this.groupBox3.Controls.Add(this.LblKalanSayisi);
            this.groupBox3.Controls.Add(this.LblOrtalama);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(668, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 334);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sinif Bilgisi";
            // 
            // LblGecensayisi
            // 
            this.LblGecensayisi.AutoSize = true;
            this.LblGecensayisi.Location = new System.Drawing.Point(203, 93);
            this.LblGecensayisi.Name = "LblGecensayisi";
            this.LblGecensayisi.Size = new System.Drawing.Size(41, 29);
            this.LblGecensayisi.TabIndex = 6;
            this.LblGecensayisi.Text = "00";
            // 
            // LblKalanSayisi
            // 
            this.LblKalanSayisi.AutoSize = true;
            this.LblKalanSayisi.Location = new System.Drawing.Point(203, 133);
            this.LblKalanSayisi.Name = "LblKalanSayisi";
            this.LblKalanSayisi.Size = new System.Drawing.Size(41, 29);
            this.LblKalanSayisi.TabIndex = 5;
            this.LblKalanSayisi.Text = "00";
            // 
            // LblOrtalama
            // 
            this.LblOrtalama.AutoSize = true;
            this.LblOrtalama.Location = new System.Drawing.Point(203, 46);
            this.LblOrtalama.Name = "LblOrtalama";
            this.LblOrtalama.Size = new System.Drawing.Size(41, 29);
            this.LblOrtalama.TabIndex = 4;
            this.LblOrtalama.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ortalama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Gecen Sayisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kalan Sayisi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1087, 278);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sinav Notlari";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRSINAV1DataGridViewTextBoxColumn,
            this.oGRSINAV2DataGridViewTextBoxColumn,
            this.oGRSINAV3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLDERSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRNUMARADataGridViewTextBoxColumn
            // 
            this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            // 
            // oGRSINAV1DataGridViewTextBoxColumn
            // 
            this.oGRSINAV1DataGridViewTextBoxColumn.DataPropertyName = "OGRSINAV1";
            this.oGRSINAV1DataGridViewTextBoxColumn.HeaderText = "OGRSINAV1";
            this.oGRSINAV1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oGRSINAV1DataGridViewTextBoxColumn.Name = "oGRSINAV1DataGridViewTextBoxColumn";
            // 
            // oGRSINAV2DataGridViewTextBoxColumn
            // 
            this.oGRSINAV2DataGridViewTextBoxColumn.DataPropertyName = "OGRSINAV2";
            this.oGRSINAV2DataGridViewTextBoxColumn.HeaderText = "OGRSINAV2";
            this.oGRSINAV2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oGRSINAV2DataGridViewTextBoxColumn.Name = "oGRSINAV2DataGridViewTextBoxColumn";
            // 
            // oGRSINAV3DataGridViewTextBoxColumn
            // 
            this.oGRSINAV3DataGridViewTextBoxColumn.DataPropertyName = "OGRSINAV3";
            this.oGRSINAV3DataGridViewTextBoxColumn.HeaderText = "OGRSINAV3";
            this.oGRSINAV3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oGRSINAV3DataGridViewTextBoxColumn.Name = "oGRSINAV3DataGridViewTextBoxColumn";
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // tBLDERSBindingSource
            // 
            this.tBLDERSBindingSource.DataMember = "TBLDERS";
            this.tBLDERSBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDERSTableAdapter
            // 
            this.tBLDERSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmOgretmenDetay";
            this.Text = "FrmOgretmenDetay";
            this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1OgrKaydet;
        private System.Windows.Forms.TextBox textBox2Soyad;
        private System.Windows.Forms.TextBox textBox1Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5Sinav2;
        private System.Windows.Forms.TextBox textBox4Sinav3;
        private System.Windows.Forms.TextBox textBox3Sinav1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2NotKaydet;
        private System.Windows.Forms.Label LblGecensayisi;
        private System.Windows.Forms.Label LblKalanSayisi;
        private System.Windows.Forms.Label LblOrtalama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource tBLDERSBindingSource;
        private DbNotKayitDataSetTableAdapters.TBLDERSTableAdapter tBLDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSINAV1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSINAV2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSINAV3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1Numara;
        private System.Windows.Forms.Button button1KayitGincelle;
    }
}