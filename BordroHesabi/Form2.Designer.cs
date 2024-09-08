namespace BordroHesabi
{
    partial class Form2
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
            this.personelEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.numCocuk = new System.Windows.Forms.NumericUpDown();
            this.comboMedeni = new System.Windows.Forms.ComboBox();
            this.comboEngel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEsCalisma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCocuk)).BeginInit();
            this.SuspendLayout();
            // 
            // personelEkle
            // 
            this.personelEkle.Location = new System.Drawing.Point(70, 252);
            this.personelEkle.Name = "personelEkle";
            this.personelEkle.Size = new System.Drawing.Size(75, 23);
            this.personelEkle.TabIndex = 0;
            this.personelEkle.Text = "Ekle";
            this.personelEkle.UseVisualStyleBackColor = true;
            this.personelEkle.Click += new System.EventHandler(this.personelEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medeni Durum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Çocuk Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "T.c. No.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Saatlik Maaş:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 46);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(119, 223);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 23);
            this.txtTc.TabIndex = 9;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(120, 165);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 23);
            this.txtMaas.TabIndex = 10;
            this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // numCocuk
            // 
            this.numCocuk.Location = new System.Drawing.Point(120, 136);
            this.numCocuk.Name = "numCocuk";
            this.numCocuk.Size = new System.Drawing.Size(120, 23);
            this.numCocuk.TabIndex = 11;
            // 
            // comboMedeni
            // 
            this.comboMedeni.FormattingEnabled = true;
            this.comboMedeni.Location = new System.Drawing.Point(120, 75);
            this.comboMedeni.Name = "comboMedeni";
            this.comboMedeni.Size = new System.Drawing.Size(121, 23);
            this.comboMedeni.TabIndex = 12;
            this.comboMedeni.SelectedIndexChanged += new System.EventHandler(this.comboMedeni_SelectedIndexChanged);
            // 
            // comboEngel
            // 
            this.comboEngel.FormattingEnabled = true;
            this.comboEngel.Location = new System.Drawing.Point(119, 194);
            this.comboEngel.Name = "comboEngel";
            this.comboEngel.Size = new System.Drawing.Size(121, 23);
            this.comboEngel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Engel Durumu";
            // 
            // comboEsCalisma
            // 
            this.comboEsCalisma.FormattingEnabled = true;
            this.comboEsCalisma.Location = new System.Drawing.Point(120, 107);
            this.comboEsCalisma.Name = "comboEsCalisma";
            this.comboEsCalisma.Size = new System.Drawing.Size(121, 23);
            this.comboEsCalisma.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Eşi Çalışıyor Mu?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 320);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboEsCalisma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEngel);
            this.Controls.Add(this.comboMedeni);
            this.Controls.Add(this.numCocuk);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelEkle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCocuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button personelEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTc;
        private TextBox txtMaas;
        private NumericUpDown numCocuk;
        private ComboBox comboMedeni;
        private ComboBox comboEngel;
        private Label label7;
        private ComboBox comboEsCalisma;
        private Label label8;
    }
}