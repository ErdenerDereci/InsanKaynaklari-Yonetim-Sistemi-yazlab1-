﻿namespace yazGel1v1
{
    partial class CalisanArayuzu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kisiBilgileriGuncelle = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.adiLabel = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dogumTarihiLabel = new System.Windows.Forms.Label();
            this.ehliyetLabel = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.yabanciDilLabel = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.adresiLabel = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.egitimBilgisiDataGrid = new System.Windows.Forms.DataGridView();
            this.OkulAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaglangicTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotOrtalamasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isyeriBilgileriDataGrid = new System.Windows.Forms.DataGridView();
            this.IsyeriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsyeriAdresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalismaSuresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.verileriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.egitimBilgisiDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isyeriBilgileriDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // kisiBilgileriGuncelle
            // 
            this.kisiBilgileriGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.kisiBilgileriGuncelle.Location = new System.Drawing.Point(274, 129);
            this.kisiBilgileriGuncelle.Name = "kisiBilgileriGuncelle";
            this.kisiBilgileriGuncelle.Size = new System.Drawing.Size(206, 29);
            this.kisiBilgileriGuncelle.TabIndex = 29;
            this.kisiBilgileriGuncelle.Text = "Kişi Bilgilerini Güncelle";
            this.kisiBilgileriGuncelle.UseVisualStyleBackColor = false;
            this.kisiBilgileriGuncelle.Click += new System.EventHandler(this.kisiBilgileriGuncelle_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(79, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 14);
            this.label19.TabIndex = 46;
            this.label19.Text = "Adı :";
            // 
            // adiLabel
            // 
            this.adiLabel.AutoSize = true;
            this.adiLabel.Location = new System.Drawing.Point(116, 41);
            this.adiLabel.Name = "adiLabel";
            this.adiLabel.Size = new System.Drawing.Size(11, 14);
            this.adiLabel.TabIndex = 47;
            this.adiLabel.Text = "-";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(22, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 14);
            this.label25.TabIndex = 48;
            this.label25.Text = "Doğum Tarihi :";
            // 
            // dogumTarihiLabel
            // 
            this.dogumTarihiLabel.AutoSize = true;
            this.dogumTarihiLabel.Location = new System.Drawing.Point(115, 89);
            this.dogumTarihiLabel.Name = "dogumTarihiLabel";
            this.dogumTarihiLabel.Size = new System.Drawing.Size(11, 14);
            this.dogumTarihiLabel.TabIndex = 49;
            this.dogumTarihiLabel.Text = "-";
            // 
            // ehliyetLabel
            // 
            this.ehliyetLabel.AutoSize = true;
            this.ehliyetLabel.Location = new System.Drawing.Point(116, 135);
            this.ehliyetLabel.Name = "ehliyetLabel";
            this.ehliyetLabel.Size = new System.Drawing.Size(11, 14);
            this.ehliyetLabel.TabIndex = 51;
            this.ehliyetLabel.Text = "-";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(60, 135);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 14);
            this.label30.TabIndex = 50;
            this.label30.Text = "Ehliyet :";
            // 
            // yabanciDilLabel
            // 
            this.yabanciDilLabel.AutoSize = true;
            this.yabanciDilLabel.Location = new System.Drawing.Point(372, 89);
            this.yabanciDilLabel.Name = "yabanciDilLabel";
            this.yabanciDilLabel.Size = new System.Drawing.Size(11, 14);
            this.yabanciDilLabel.TabIndex = 57;
            this.yabanciDilLabel.Text = "-";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(292, 89);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 14);
            this.label32.TabIndex = 56;
            this.label32.Text = "Yabancı Dil :";
            // 
            // adresiLabel
            // 
            this.adresiLabel.AutoSize = true;
            this.adresiLabel.Location = new System.Drawing.Point(374, 41);
            this.adresiLabel.Name = "adresiLabel";
            this.adresiLabel.Size = new System.Drawing.Size(11, 14);
            this.adresiLabel.TabIndex = 55;
            this.adresiLabel.Text = "-";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(318, 41);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 14);
            this.label34.TabIndex = 54;
            this.label34.Text = "Adresi :";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(636, 41);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(11, 14);
            this.telefonLabel.TabIndex = 59;
            this.telefonLabel.Text = "-";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(576, 41);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(54, 14);
            this.label36.TabIndex = 58;
            this.label36.Text = "Telefon :";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(635, 89);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(11, 14);
            this.mailLabel.TabIndex = 61;
            this.mailLabel.Text = "-";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(572, 89);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(57, 14);
            this.label38.TabIndex = 60;
            this.label38.Text = "E-Posta :";
            // 
            // egitimBilgisiDataGrid
            // 
            this.egitimBilgisiDataGrid.AllowUserToAddRows = false;
            this.egitimBilgisiDataGrid.AllowUserToDeleteRows = false;
            this.egitimBilgisiDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.egitimBilgisiDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.egitimBilgisiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.egitimBilgisiDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OkulAdi,
            this.Turu,
            this.Bolumu,
            this.BaglangicTarihi,
            this.BitisTarihi,
            this.NotOrtalamasi});
            this.egitimBilgisiDataGrid.Location = new System.Drawing.Point(23, 205);
            this.egitimBilgisiDataGrid.Name = "egitimBilgisiDataGrid";
            this.egitimBilgisiDataGrid.RowHeadersWidth = 50;
            this.egitimBilgisiDataGrid.Size = new System.Drawing.Size(804, 190);
            this.egitimBilgisiDataGrid.TabIndex = 62;
            // 
            // OkulAdi
            // 
            this.OkulAdi.HeaderText = "Okul Adı";
            this.OkulAdi.MinimumWidth = 6;
            this.OkulAdi.Name = "OkulAdi";
            this.OkulAdi.ReadOnly = true;
            this.OkulAdi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OkulAdi.Width = 125;
            // 
            // Turu
            // 
            this.Turu.HeaderText = "Türü";
            this.Turu.MinimumWidth = 6;
            this.Turu.Name = "Turu";
            this.Turu.ReadOnly = true;
            this.Turu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Turu.Width = 125;
            // 
            // Bolumu
            // 
            this.Bolumu.HeaderText = "Bölümü";
            this.Bolumu.MinimumWidth = 6;
            this.Bolumu.Name = "Bolumu";
            this.Bolumu.ReadOnly = true;
            this.Bolumu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bolumu.Width = 125;
            // 
            // BaglangicTarihi
            // 
            this.BaglangicTarihi.HeaderText = "Başlangıç Tarihi";
            this.BaglangicTarihi.MinimumWidth = 6;
            this.BaglangicTarihi.Name = "BaglangicTarihi";
            this.BaglangicTarihi.ReadOnly = true;
            this.BaglangicTarihi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BaglangicTarihi.Width = 125;
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.HeaderText = "Bitiş Tarihi";
            this.BitisTarihi.MinimumWidth = 6;
            this.BitisTarihi.Name = "BitisTarihi";
            this.BitisTarihi.ReadOnly = true;
            this.BitisTarihi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BitisTarihi.Width = 125;
            // 
            // NotOrtalamasi
            // 
            this.NotOrtalamasi.HeaderText = "Not Ortalaması";
            this.NotOrtalamasi.MinimumWidth = 6;
            this.NotOrtalamasi.Name = "NotOrtalamasi";
            this.NotOrtalamasi.ReadOnly = true;
            this.NotOrtalamasi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NotOrtalamasi.Width = 125;
            // 
            // isyeriBilgileriDataGrid
            // 
            this.isyeriBilgileriDataGrid.AllowUserToAddRows = false;
            this.isyeriBilgileriDataGrid.AllowUserToDeleteRows = false;
            this.isyeriBilgileriDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.isyeriBilgileriDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.isyeriBilgileriDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.isyeriBilgileriDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.isyeriBilgileriDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsyeriAdi,
            this.IsyeriAdresi,
            this.Gorevi,
            this.CalismaSuresi});
            this.isyeriBilgileriDataGrid.GridColor = System.Drawing.Color.Gray;
            this.isyeriBilgileriDataGrid.Location = new System.Drawing.Point(23, 447);
            this.isyeriBilgileriDataGrid.Name = "isyeriBilgileriDataGrid";
            this.isyeriBilgileriDataGrid.RowHeadersWidth = 80;
            this.isyeriBilgileriDataGrid.Size = new System.Drawing.Size(804, 190);
            this.isyeriBilgileriDataGrid.TabIndex = 63;
            // 
            // IsyeriAdi
            // 
            this.IsyeriAdi.HeaderText = "İşyeri Adı";
            this.IsyeriAdi.MinimumWidth = 6;
            this.IsyeriAdi.Name = "IsyeriAdi";
            this.IsyeriAdi.ReadOnly = true;
            this.IsyeriAdi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IsyeriAdi.Width = 125;
            // 
            // IsyeriAdresi
            // 
            this.IsyeriAdresi.HeaderText = "İşyeri Adresi";
            this.IsyeriAdresi.MinimumWidth = 6;
            this.IsyeriAdresi.Name = "IsyeriAdresi";
            this.IsyeriAdresi.ReadOnly = true;
            this.IsyeriAdresi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IsyeriAdresi.Width = 125;
            // 
            // Gorevi
            // 
            this.Gorevi.HeaderText = "Görevi / Pozisyonu";
            this.Gorevi.MinimumWidth = 6;
            this.Gorevi.Name = "Gorevi";
            this.Gorevi.ReadOnly = true;
            this.Gorevi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Gorevi.Width = 125;
            // 
            // CalismaSuresi
            // 
            this.CalismaSuresi.HeaderText = "Çalışma Süresi";
            this.CalismaSuresi.MinimumWidth = 6;
            this.CalismaSuresi.Name = "CalismaSuresi";
            this.CalismaSuresi.ReadOnly = true;
            this.CalismaSuresi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CalismaSuresi.Width = 125;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.Location = new System.Drawing.Point(22, 177);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(87, 14);
            this.label39.TabIndex = 64;
            this.label39.Text = "Eğitim Bilgileri";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label40.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(22, 419);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(83, 14);
            this.label40.TabIndex = 65;
            this.label40.Text = "İşyeri Bilgileri";
            // 
            // verileriSil
            // 
            this.verileriSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.verileriSil.Location = new System.Drawing.Point(539, 129);
            this.verileriSil.Name = "verileriSil";
            this.verileriSil.Size = new System.Drawing.Size(288, 29);
            this.verileriSil.TabIndex = 66;
            this.verileriSil.Text = "Verileri Sil ve Sistemden Çık";
            this.verileriSil.UseVisualStyleBackColor = false;
            this.verileriSil.Click += new System.EventHandler(this.verileriSil_Click);
            // 
            // CalisanArayuzu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 666);
            this.Controls.Add(this.verileriSil);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.isyeriBilgileriDataGrid);
            this.Controls.Add(this.egitimBilgisiDataGrid);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.yabanciDilLabel);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.adresiLabel);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.ehliyetLabel);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.dogumTarihiLabel);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.adiLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.kisiBilgileriGuncelle);
            this.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalisanArayuzu";
            this.Text = "Çalışan Arayüzü";
            this.Activated += new System.EventHandler(this.CalisanArayuzu_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CalisanArayuzu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.egitimBilgisiDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isyeriBilgileriDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kisiBilgileriGuncelle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button verileriSil;
        public System.Windows.Forms.Label adiLabel;
        public System.Windows.Forms.Label dogumTarihiLabel;
        public System.Windows.Forms.Label ehliyetLabel;
        public System.Windows.Forms.Label yabanciDilLabel;
        public System.Windows.Forms.Label adresiLabel;
        public System.Windows.Forms.Label telefonLabel;
        public System.Windows.Forms.Label mailLabel;
        public System.Windows.Forms.DataGridView egitimBilgisiDataGrid;
        public System.Windows.Forms.DataGridView isyeriBilgileriDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn OkulAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaglangicTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotOrtalamasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsyeriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsyeriAdresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalismaSuresi;
    }
}