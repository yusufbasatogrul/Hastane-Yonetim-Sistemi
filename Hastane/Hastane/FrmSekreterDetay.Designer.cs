namespace Hastane
{
    partial class FrmSekreterDetay
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.rchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRandevuListe = new System.Windows.Forms.Button();
            this.btnBransPanel = new System.Windows.Forms.Button();
            this.btnDoktorPanel = new System.Windows.Forms.Button();
            this.btnDuyuru = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAdSoyad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTC);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sekreter Bilgi ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(132, 89);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(98, 28);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Null Null ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad : ";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(132, 47);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(144, 28);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox1.Controls.Add(this.rchDuyuru);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 287);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duyuru Oluştur ";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(7, 235);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(298, 46);
            this.btnDuyuruOlustur.TabIndex = 1;
            this.btnDuyuruOlustur.Text = "Oluştur ";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // rchDuyuru
            // 
            this.rchDuyuru.Location = new System.Drawing.Point(7, 36);
            this.rchDuyuru.Name = "rchDuyuru";
            this.rchDuyuru.Size = new System.Drawing.Size(298, 197);
            this.rchDuyuru.TabIndex = 0;
            this.rchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.chkDurum);
            this.groupBox3.Controls.Add(this.mskTC);
            this.groupBox3.Controls.Add(this.cmbDoktor);
            this.groupBox3.Controls.Add(this.cmbBrans);
            this.groupBox3.Controls.Add(this.mskSaat);
            this.groupBox3.Controls.Add(this.mskTarih);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(344, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 437);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(132, 337);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 46);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(133, 299);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(105, 32);
            this.chkDurum.TabIndex = 13;
            this.chkDurum.Text = "Durum ";
            this.chkDurum.UseVisualStyleBackColor = true;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(132, 256);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(149, 36);
            this.mskTC.TabIndex = 12;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(132, 214);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(149, 36);
            this.cmbDoktor.TabIndex = 11;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(132, 172);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(150, 36);
            this.cmbBrans.TabIndex = 10;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(132, 129);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(149, 36);
            this.mskSaat.TabIndex = 9;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(132, 87);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(149, 36);
            this.mskTarih.TabIndex = 8;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(132, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(150, 36);
            this.txtid.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "TC :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(665, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 215);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(665, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 347);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(427, 312);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDuyuru);
            this.groupBox6.Controls.Add(this.btnRandevuListe);
            this.groupBox6.Controls.Add(this.btnBransPanel);
            this.groupBox6.Controls.Add(this.btnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 455);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(634, 121);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim ";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // btnRandevuListe
            // 
            this.btnRandevuListe.Location = new System.Drawing.Point(319, 49);
            this.btnRandevuListe.Name = "btnRandevuListe";
            this.btnRandevuListe.Size = new System.Drawing.Size(176, 65);
            this.btnRandevuListe.TabIndex = 17;
            this.btnRandevuListe.Text = "Randevu Liste";
            this.btnRandevuListe.UseVisualStyleBackColor = true;
            this.btnRandevuListe.Click += new System.EventHandler(this.btnRandevuListe_Click);
            // 
            // btnBransPanel
            // 
            this.btnBransPanel.Location = new System.Drawing.Point(163, 49);
            this.btnBransPanel.Name = "btnBransPanel";
            this.btnBransPanel.Size = new System.Drawing.Size(148, 65);
            this.btnBransPanel.TabIndex = 16;
            this.btnBransPanel.Text = "Branş Paneli ";
            this.btnBransPanel.UseVisualStyleBackColor = true;
            this.btnBransPanel.Click += new System.EventHandler(this.btnBransPanel_Click);
            // 
            // btnDoktorPanel
            // 
            this.btnDoktorPanel.Location = new System.Drawing.Point(7, 49);
            this.btnDoktorPanel.Name = "btnDoktorPanel";
            this.btnDoktorPanel.Size = new System.Drawing.Size(150, 65);
            this.btnDoktorPanel.TabIndex = 15;
            this.btnDoktorPanel.Text = "Doktor Paneli ";
            this.btnDoktorPanel.UseVisualStyleBackColor = true;
            this.btnDoktorPanel.Click += new System.EventHandler(this.btnDoktorPanel_Click);
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.Location = new System.Drawing.Point(501, 49);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(127, 65);
            this.btnDuyuru.TabIndex = 18;
            this.btnDuyuru.Text = "Duyurular";
            this.btnDuyuru.UseVisualStyleBackColor = true;
            this.btnDuyuru.Click += new System.EventHandler(this.btnDuyuru_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1110, 581);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay ";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox rchDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRandevuListe;
        private System.Windows.Forms.Button btnBransPanel;
        private System.Windows.Forms.Button btnDoktorPanel;
        private System.Windows.Forms.Button btnDuyuru;
    }
}