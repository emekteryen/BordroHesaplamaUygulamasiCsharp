namespace BordroHesabi
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
            this.elemanlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblMedeni = new System.Windows.Forms.Label();
            this.lblCocuk = new System.Windows.Forms.Label();
            this.MaasGrid = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.personelEkle = new System.Windows.Forms.Button();
            this.brutHesap = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMesai = new System.Windows.Forms.TextBox();
            this.yolYardimi = new System.Windows.Forms.CheckBox();
            this.yemekYardimi = new System.Windows.Forms.CheckBox();
            this.maasTarih = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEngel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // elemanlar
            // 
            this.elemanlar.FormattingEnabled = true;
            this.elemanlar.Location = new System.Drawing.Point(12, 26);
            this.elemanlar.Name = "elemanlar";
            this.elemanlar.Size = new System.Drawing.Size(121, 23);
            this.elemanlar.TabIndex = 0;
            this.elemanlar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "T.C. No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Medeni Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Çocuk Sayısı:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(255, 9);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(38, 15);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "label7";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(255, 26);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(38, 15);
            this.lblSoyad.TabIndex = 9;
            this.lblSoyad.Text = "label8";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(255, 43);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(38, 15);
            this.lblTC.TabIndex = 10;
            this.lblTC.Text = "label9";
            // 
            // lblMedeni
            // 
            this.lblMedeni.AutoSize = true;
            this.lblMedeni.Location = new System.Drawing.Point(255, 62);
            this.lblMedeni.Name = "lblMedeni";
            this.lblMedeni.Size = new System.Drawing.Size(44, 15);
            this.lblMedeni.TabIndex = 11;
            this.lblMedeni.Text = "label10";
            // 
            // lblCocuk
            // 
            this.lblCocuk.AutoSize = true;
            this.lblCocuk.Location = new System.Drawing.Point(255, 77);
            this.lblCocuk.Name = "lblCocuk";
            this.lblCocuk.Size = new System.Drawing.Size(44, 15);
            this.lblCocuk.TabIndex = 12;
            this.lblCocuk.Text = "label11";
            // 
            // MaasGrid
            // 
            this.MaasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaasGrid.Location = new System.Drawing.Point(12, 143);
            this.MaasGrid.Name = "MaasGrid";
            this.MaasGrid.RowTemplate.Height = 25;
            this.MaasGrid.Size = new System.Drawing.Size(913, 382);
            this.MaasGrid.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(431, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ek Mesai:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(430, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Ek Ödemeler:";
            // 
            // personelEkle
            // 
            this.personelEkle.Location = new System.Drawing.Point(764, 30);
            this.personelEkle.Name = "personelEkle";
            this.personelEkle.Size = new System.Drawing.Size(87, 23);
            this.personelEkle.TabIndex = 16;
            this.personelEkle.Text = "Ekle";
            this.personelEkle.UseVisualStyleBackColor = true;
            this.personelEkle.Click += new System.EventHandler(this.personelEkle_Click);
            // 
            // brutHesap
            // 
            this.brutHesap.Location = new System.Drawing.Point(470, 107);
            this.brutHesap.Name = "brutHesap";
            this.brutHesap.Size = new System.Drawing.Size(106, 23);
            this.brutHesap.TabIndex = 17;
            this.brutHesap.Text = "Brüt Hesaplama";
            this.brutHesap.UseVisualStyleBackColor = true;
            this.brutHesap.Click += new System.EventHandler(this.btnBrutHesap_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(764, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Personel Ekle";
            // 
            // txtMesai
            // 
            this.txtMesai.Location = new System.Drawing.Point(513, 8);
            this.txtMesai.Name = "txtMesai";
            this.txtMesai.Size = new System.Drawing.Size(100, 23);
            this.txtMesai.TabIndex = 20;
            // 
            // yolYardimi
            // 
            this.yolYardimi.AutoSize = true;
            this.yolYardimi.Location = new System.Drawing.Point(513, 50);
            this.yolYardimi.Name = "yolYardimi";
            this.yolYardimi.Size = new System.Drawing.Size(85, 19);
            this.yolYardimi.TabIndex = 25;
            this.yolYardimi.Text = "Yol Yardımı";
            this.yolYardimi.UseVisualStyleBackColor = true;
            // 
            // yemekYardimi
            // 
            this.yemekYardimi.AutoSize = true;
            this.yemekYardimi.Location = new System.Drawing.Point(594, 50);
            this.yemekYardimi.Name = "yemekYardimi";
            this.yemekYardimi.Size = new System.Drawing.Size(104, 19);
            this.yemekYardimi.TabIndex = 26;
            this.yemekYardimi.Text = "Yemek Yardımı";
            this.yemekYardimi.UseVisualStyleBackColor = true;
            // 
            // maasTarih
            // 
            this.maasTarih.CustomFormat = "yyyy-MM";
            this.maasTarih.Location = new System.Drawing.Point(512, 75);
            this.maasTarih.Name = "maasTarih";
            this.maasTarih.Size = new System.Drawing.Size(118, 23);
            this.maasTarih.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(431, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "Tarih Seçimi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Güncelleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Saatlik Brüt:";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(255, 92);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(44, 15);
            this.lblMaas.TabIndex = 33;
            this.lblMaas.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(165, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 15);
            this.label18.TabIndex = 34;
            this.label18.Text = "Engel Durumu:";
            // 
            // lblEngel
            // 
            this.lblEngel.AutoSize = true;
            this.lblEngel.Location = new System.Drawing.Point(255, 107);
            this.lblEngel.Name = "lblEngel";
            this.lblEngel.Size = new System.Drawing.Size(44, 15);
            this.lblEngel.TabIndex = 35;
            this.lblEngel.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(764, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 15);
            this.label20.TabIndex = 36;
            this.label20.Text = "Personel Güncelle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 555);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblEngel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.maasTarih);
            this.Controls.Add(this.yemekYardimi);
            this.Controls.Add(this.yolYardimi);
            this.Controls.Add(this.txtMesai);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.brutHesap);
            this.Controls.Add(this.personelEkle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MaasGrid);
            this.Controls.Add(this.lblCocuk);
            this.Controls.Add(this.lblMedeni);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elemanlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaasGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox elemanlar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblTC;
        private Label lblMedeni;
        private Label lblCocuk;
        private DataGridView MaasGrid;
        private Label label12;
        private Label label13;
        private Button personelEkle;
        private Button brutHesap;
        private Label label14;
        private TextBox txtMesai;
        private CheckBox yolYardimi;
        private CheckBox yemekYardimi;
        private DateTimePicker maasTarih;
        private Label label16;
        private Button button1;
        private Label label15;
        private Label lblMaas;
        private Label label18;
        private Label lblEngel;
        private Label label20;
    }
}