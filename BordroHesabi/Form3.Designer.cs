namespace BordroHesabi
{
    partial class Form3
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
            this.elemanSec = new System.Windows.Forms.ComboBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.comboEngel = new System.Windows.Forms.ComboBox();
            this.comboMedeni = new System.Windows.Forms.ComboBox();
            this.numCocuk = new System.Windows.Forms.NumericUpDown();
            this.comboEsCalisma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCocuk)).BeginInit();
            this.SuspendLayout();
            // 
            // elemanSec
            // 
            this.elemanSec.FormattingEnabled = true;
            this.elemanSec.Location = new System.Drawing.Point(116, 21);
            this.elemanSec.Name = "elemanSec";
            this.elemanSec.Size = new System.Drawing.Size(121, 23);
            this.elemanSec.TabIndex = 0;
            this.elemanSec.SelectedIndexChanged += new System.EventHandler(this.elemanSec_SelectedIndexChanged);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(79, 270);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(75, 23);
            this.guncelle.TabIndex = 1;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(116, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(116, 79);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(116, 198);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 23);
            this.txtMaas.TabIndex = 4;
            this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // comboEngel
            // 
            this.comboEngel.FormattingEnabled = true;
            this.comboEngel.Location = new System.Drawing.Point(116, 227);
            this.comboEngel.Name = "comboEngel";
            this.comboEngel.Size = new System.Drawing.Size(121, 23);
            this.comboEngel.TabIndex = 7;
            this.comboEngel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEngel_KeyPress);
            // 
            // comboMedeni
            // 
            this.comboMedeni.FormattingEnabled = true;
            this.comboMedeni.Location = new System.Drawing.Point(116, 111);
            this.comboMedeni.Name = "comboMedeni";
            this.comboMedeni.Size = new System.Drawing.Size(121, 23);
            this.comboMedeni.TabIndex = 8;
            this.comboMedeni.SelectedIndexChanged += new System.EventHandler(this.comboMedeni_SelectedIndexChanged);
            // 
            // numCocuk
            // 
            this.numCocuk.Location = new System.Drawing.Point(116, 169);
            this.numCocuk.Name = "numCocuk";
            this.numCocuk.Size = new System.Drawing.Size(120, 23);
            this.numCocuk.TabIndex = 9;
            // 
            // comboEsCalisma
            // 
            this.comboEsCalisma.FormattingEnabled = true;
            this.comboEsCalisma.Location = new System.Drawing.Point(116, 140);
            this.comboEsCalisma.Name = "comboEsCalisma";
            this.comboEsCalisma.Size = new System.Drawing.Size(121, 23);
            this.comboEsCalisma.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Personel Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Medeni Durum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Eş Çalışma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Çocuk Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Maaş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Engel Durumu";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 325);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEsCalisma);
            this.Controls.Add(this.numCocuk);
            this.Controls.Add(this.comboMedeni);
            this.Controls.Add(this.comboEngel);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.elemanSec);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCocuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox elemanSec;
        private Button guncelle;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMaas;
        private ComboBox comboEngel;
        private ComboBox comboMedeni;
        private NumericUpDown numCocuk;
        private ComboBox comboEsCalisma;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}