using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace BordroHesabi
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=localhost;Database=avonaltd;User ID=root;Password=;";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboEngel.Items.Add("0");
            comboEngel.Items.Add("1");
            comboEngel.Items.Add("2");
            comboEngel.Items.Add("3");
            comboEsCalisma.Items.Add("Evet");
            comboEsCalisma.Items.Add("Hayır");
            comboMedeni.Items.Add("Evli");
            comboMedeni.Items.Add("Bekar");
            comboMedeni.SelectedIndex = 1;
            comboEsCalisma.SelectedIndex = 1;
            comboEngel.SelectedIndex = 0;
            comboEsCalisma.Enabled = false;
            comboMedeni.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEsCalisma.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEngel.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTc.KeyPress += new KeyPressEventHandler(txtTc_KeyPress);
            txtMaas.KeyPress += new KeyPressEventHandler(txtMaas_KeyPress);
        }
        private void personelEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string tckn = txtTc.Text;
            bool medeni = comboMedeni.SelectedItem.ToString() == "Evli";
            bool escalisma = comboEsCalisma.SelectedItem.ToString() == "Evet";
            int engeldurumu = comboEngel.SelectedIndex;
            int cocuksayisi = (int)numCocuk.Value;
            double saatlikMaas = double.Parse(txtMaas.Text);
            if (saatlikMaas < 88.9)
            {
                MessageBox.Show("Brüt Saatlik Maaş Yasal Sınır Olan Minimum 88.9 Değerinin Altında Olamaz");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Personel (Ad, Soyad, TCKN, Medeni, Cocuksayisi, SaatlikMaas, EngellilikDurumu, EsinCalismaDurumu) VALUES (@Ad, @Soyad, @TCKN, @Medeni, @Cocuksayisi, @SaatlikMaas, @EngellilikDurumu, @EsinCalismaDurumu)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@TCKN", tckn);
                cmd.Parameters.AddWithValue("@Medeni", medeni);
                cmd.Parameters.AddWithValue("@Cocuksayisi", cocuksayisi);
                cmd.Parameters.AddWithValue("@SaatlikMaas", saatlikMaas);
                cmd.Parameters.AddWithValue("@EngellilikDurumu", engeldurumu);
                cmd.Parameters.AddWithValue("@EsinCalismaDurumu", escalisma);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel başarıyla eklendi!");
                this.Close();
            }
        }
        private void comboMedeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboMedeni.SelectedIndex==0)
            {
                comboEsCalisma.Enabled = true;
            }
            else
            {
                comboEsCalisma.Enabled = false;
                comboEsCalisma.SelectedIndex = 1;
            }
        }
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
