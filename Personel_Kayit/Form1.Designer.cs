
namespace Personel_Kayit
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.radioBekar = new System.Windows.Forms.RadioButton();
            this.radioEvli = new System.Windows.Forms.RadioButton();
            this.mskMaas = new System.Windows.Forms.MaskedTextBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeritabaniDataSet = new Personel_Kayit.PersonelVeritabaniDataSet();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(33, 31);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(215, 33);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(33, 70);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(215, 33);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(33, 109);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(215, 33);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(33, 148);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(215, 33);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(33, 187);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(215, 33);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(33, 226);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(215, 33);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "İstatistik";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(33, 265);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(215, 33);
            this.btnGrafik.TabIndex = 1;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.radioBekar);
            this.groupBox1.Controls.Add(this.radioEvli);
            this.groupBox1.Controls.Add(this.mskMaas);
            this.groupBox1.Controls.Add(this.cmbSehir);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(115, 270);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(147, 29);
            this.txtMeslek.TabIndex = 8;
            // 
            // radioBekar
            // 
            this.radioBekar.AutoSize = true;
            this.radioBekar.Location = new System.Drawing.Point(184, 233);
            this.radioBekar.Name = "radioBekar";
            this.radioBekar.Size = new System.Drawing.Size(76, 28);
            this.radioBekar.TabIndex = 7;
            this.radioBekar.TabStop = true;
            this.radioBekar.Text = "Bekar";
            this.radioBekar.UseVisualStyleBackColor = true;
            this.radioBekar.CheckedChanged += new System.EventHandler(this.radioBekar_CheckedChanged);
            // 
            // radioEvli
            // 
            this.radioEvli.AutoSize = true;
            this.radioEvli.Location = new System.Drawing.Point(120, 233);
            this.radioEvli.Name = "radioEvli";
            this.radioEvli.Size = new System.Drawing.Size(58, 28);
            this.radioEvli.TabIndex = 6;
            this.radioEvli.TabStop = true;
            this.radioEvli.Text = "Evli";
            this.radioEvli.UseVisualStyleBackColor = true;
            this.radioEvli.CheckedChanged += new System.EventHandler(this.radioEvli_CheckedChanged);
            // 
            // mskMaas
            // 
            this.mskMaas.Location = new System.Drawing.Point(120, 192);
            this.mskMaas.Mask = "0000";
            this.mskMaas.Name = "mskMaas";
            this.mskMaas.Size = new System.Drawing.Size(142, 29);
            this.mskMaas.TabIndex = 5;
            this.mskMaas.ValidatingType = typeof(int);
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "Şehir Seçiniz",
            "01 Adana",
            "02 Adıyaman",
            "03 Afyon",
            "04 Ağrı",
            "05 Amasya",
            "06 Ankara",
            "07 Antalya",
            "08 Artvin",
            "09 Aydın",
            "10 Balıkesir",
            "11 Bilecik",
            "12 Bingöl",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir",
            "27 Gaziantep",
            "28 Giresun",
            "29 Gümüşhane",
            "30 Hakkari",
            "31 Hatay",
            "32 Isparta",
            "33 İçel (Mersin)",
            "34 İstanbul",
            "35 İzmir",
            "36 Kars",
            "37 Kastamonu",
            "38 Kayseri",
            "39 Kırklareli",
            "40 Kırşehir",
            "41 Kocaeli",
            "42 Konya",
            "43 Kütahya",
            "44 Malatya",
            "45 Manisa",
            "46 K.maraş",
            "47 Mardin",
            "48 Muğla",
            "49 Muş",
            "50 Nevşehir",
            "51 Niğde",
            "52 Ordu",
            "53 Rize",
            "54 Sakarya",
            "55 Samsun",
            "56 Siirt",
            "57 Sinop",
            "58 Sivas",
            "59 Tekirdağ",
            "60 Tokat",
            "61 Trabzon",
            "62 Tunceli",
            "63 Şanlıurfa",
            "64 Uşak",
            "65 Van",
            "66 Yozgat",
            "67 Zonguldak",
            "68 Aksaray",
            "69 Bayburt",
            "70 Karaman",
            "71 Kırıkkale",
            "72 Batman",
            "73 Şırnak",
            "74 Bartın",
            "75 Ardahan",
            "76 Iğdır",
            "77 Yalova",
            "78 Karabük",
            "79 Kilis",
            "80 Osmaniye",
            "81 Düzce"});
            this.cmbSehir.Location = new System.Drawing.Point(120, 151);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(142, 32);
            this.cmbSehir.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 110);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(142, 29);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 71);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(142, 29);
            this.txtAd.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 29);
            this.txtID.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "PerID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Durum : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Soyadı : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Adı : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Şehir : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Maaş : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Meslek : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrafik);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnStats);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Location = new System.Drawing.Point(470, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 312);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 211);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veriler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeritabaniDataSet;
            // 
            // personelVeritabaniDataSet
            // 
            this.personelVeritabaniDataSet.DataSetName = "PersonelVeritabaniDataSet";
            this.personelVeritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(889, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Personel Veritabanı v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.RadioButton radioBekar;
        private System.Windows.Forms.RadioButton radioEvli;
        private System.Windows.Forms.MaskedTextBox mskMaas;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeritabaniDataSet personelVeritabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

