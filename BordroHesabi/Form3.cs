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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string connectionString = "Server=localhost;Database=avonaltd;User ID=root;Password=;";
        private void Form3_Load(object sender, EventArgs e)
        {
            comboEngel.Items.Add("0");
            comboEngel.Items.Add("1");
            comboEngel.Items.Add("2");
            comboEngel.Items.Add("3");
            comboEsCalisma.Items.Add("Evet");
            comboEsCalisma.Items.Add("Hayır");
            comboMedeni.Items.Add("Evli");
            comboMedeni.Items.Add("Bekar");
            comboEsCalisma.Enabled = false;
            comboEngel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEsCalisma.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMedeni.DropDownStyle = ComboBoxStyle.DropDownList;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PersonelID, Ad, Soyad FROM Personel";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        elemanSec.Items.Add(new
                        {
                            Text = $"{reader["Ad"]} {reader["Soyad"]}",
                            Value = reader["PersonelID"]
                        });
                    }
                }
            }
        }

        private void elemanSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int personelId = elemanSec.SelectedIndex+1;


            using (MySqlConnection connection2 = new MySqlConnection(connectionString))
            {
                connection2.Open();
                string query2 = "SELECT * FROM Personel WHERE PersonelID = @PersonelID";
                MySqlCommand cmd = new MySqlCommand(query2, connection2);
                cmd.Parameters.AddWithValue("@PersonelID", personelId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bool medeni = false;
                        bool escalisma = false;
                        txtAd.Text = reader["Ad"].ToString();
                        txtSoyad.Text = reader["Soyad"].ToString();
                        medeni = reader.GetBoolean("Medeni");
                        if (medeni==true)
                        { comboMedeni.SelectedItem = "Evli"; }
                        if (medeni == false)
                        { comboMedeni.SelectedItem = "Bekar"; }
                        numCocuk.Text = reader["Cocuksayisi"].ToString();
                        txtMaas.Text = reader["SaatlikMaas"].ToString();
                        comboEngel.SelectedItem = reader["EngellilikDurumu"].ToString();
                        escalisma = reader.GetBoolean("EsinCalismaDurumu");
                        if (escalisma == true)
                        { comboEsCalisma.SelectedItem = "Evet"; }
                        if (escalisma == false)
                        { comboEsCalisma.SelectedItem = "Hayır"; }
                    }
                }
                connection2.Close();
            }

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int personelId = elemanSec.SelectedIndex+1;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Personel SET Ad = @Ad, Soyad = @Soyad, Medeni = @Medeni, Cocuksayisi = @Cocuksayisi, " +
                               "SaatlikMaas = @SaatlikMaas, EngellilikDurumu = @EngellilikDurumu, EsinCalismaDurumu = @EsinCalismaDurumu " +
                               " WHERE PersonelID = @PersonelID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                bool escalisma = comboEsCalisma.SelectedItem.ToString() == "Evet";
                bool medeni = comboMedeni.SelectedItem.ToString() == "Evli";
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@Medeni", medeni);
                cmd.Parameters.AddWithValue("@Cocuksayisi", int.Parse(numCocuk.Text));
                cmd.Parameters.AddWithValue("@SaatlikMaas", decimal.Parse(txtMaas.Text));
                cmd.Parameters.AddWithValue("@EngellilikDurumu", comboEngel.SelectedItem);
                cmd.Parameters.AddWithValue("@EsinCalismaDurumu", escalisma);
                cmd.Parameters.AddWithValue("@PersonelID", personelId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel bilgileri başarıyla güncellendi!");
                this.Close();
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

        private void comboMedeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMedeni.SelectedIndex == 0)
            {
                comboEsCalisma.Enabled = true;
            }
            else
            {
                comboEsCalisma.Enabled = false;
                comboEsCalisma.SelectedIndex = 1;
            }
        }

        private void comboEngel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
