using MySqlConnector;
using System;
using System.Data;
using System.Diagnostics.Metrics;

namespace BordroHesabi
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=avonaltd;User ID=root;Password=;";

        public Form1()
        {
            InitializeComponent();
            txtMesai.Text = "0";
            TarihSec();
        }

        private void TarihSec()
        {
            maasTarih.Format = DateTimePickerFormat.Custom;
            maasTarih.CustomFormat = "yyyy-MM";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaasGetir();
            MySqlConnection connection8 = new MySqlConnection(connectionString);
            connection8.Open();
            string query = "SELECT * from Personel";
            int personelId = elemanlar.SelectedIndex + 1;

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
                        lblAd.Text = reader["Ad"].ToString();
                        lblSoyad.Text = reader["Soyad"].ToString();
                        lblTC.Text = reader["TCKN"].ToString();
                        bool medeni = reader.GetBoolean("Medeni");
                        if (medeni = true)
                        { lblMedeni.Text = "Evli"; }
                        if (medeni = true)
                        { lblMedeni.Text = "Bekar"; }
                        lblCocuk.Text = reader["Cocuksayisi"].ToString();
                        lblMaas.Text = reader["SaatlikMaas"].ToString();
                        lblEngel.Text = reader["EngellilikDurumu"].ToString();
                    }
                }
                connection2.Close();
            }
            connection8.Close();
        }
        private void personelEkle_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void PersonelGetir()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT PersonelID, CONCAT(Ad, ' ', Soyad) AS TamAd FROM Personel";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable personeller = new DataTable();
            adapter.Fill(personeller);
            elemanlar.DataSource = personeller;
            elemanlar.DisplayMember = "TamAd";
            elemanlar.ValueMember = "PersonelID";
            
            connection.Close();
        }
        private void MaasGetir()
        {
            MySqlConnection connection3 = new MySqlConnection(connectionString);
            connection3.Open();
            int secilenPersonelID = elemanlar.SelectedIndex + 1;
            string query = "SELECT p.Ad, p.Soyad, m.MaasGunu, m.NetMaas, m.EkOdemeler, m.FazlaCalismaSuresi, m.Kesintiler, m.SirketeBedeli, m.SGKIsveren, m.IssizlikSigortasiIsveren, m.HazineDestegi, m.GelirVergisiToplam, m.GelirVergisiIndirim, m.DamgaVergisi, m.DamgaVergisiIndirim   " +
                               "FROM Personel p " +
                               "JOIN maasbilgisi m ON p.PersonelID = m.PersonelID " +
                               "WHERE p.PersonelID = @PersonelID " +
                               "ORDER BY m.MaasGunu DESC";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection3);
            adapter.SelectCommand.Parameters.AddWithValue("@PersonelID", secilenPersonelID);

            DataTable MaasTablosu = new DataTable();
            adapter.Fill(MaasTablosu);
            MaasGrid.DataSource = MaasTablosu;
            connection3.Close();
        }
        private void btnBrutHesap_Click(object sender, EventArgs e)
        {
            int personelId = Convert.ToInt32(elemanlar.SelectedValue);
            DateTime selectedDate = maasTarih.Value;
            DateTime maasGunu = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            MySqlConnection connection12 = new MySqlConnection(connectionString);
            connection12.Open();

            string tarihKontrol = "SELECT COUNT(*) FROM maasbilgisi WHERE PersonelID = @PersonelID AND YEAR(MaasGunu) = @Year AND MONTH(MaasGunu) = @Month";
            MySqlCommand cmdTarih = new MySqlCommand(tarihKontrol, connection12);
            cmdTarih.Parameters.AddWithValue("@PersonelID", personelId);
            cmdTarih.Parameters.AddWithValue("@Year", maasGunu.Year);
            cmdTarih.Parameters.AddWithValue("@Month", maasGunu.Month);

            int count = Convert.ToInt32(cmdTarih.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Bu tarihte zaten maaþ bilgisi mevcut.");
                connection12.Close();
                return;
            }


            double yol = 2888;
            double yemek = 4420;

            double ekOdemeler = 0;
            double fazlaCalismaSuresi = double.Parse(txtMesai.Text);
            if (yolYardimi.Checked) { ekOdemeler += yol; }
            if (yemekYardimi.Checked) { ekOdemeler += yemek; }
            MySqlConnection connection2 = new MySqlConnection(connectionString);
            connection2.Open();
            string getPersonelQuery = "SELECT SaatlikMaas, EsinCalismaDurumu, Medeni, EngellilikDurumu, Cocuksayisi FROM Personel WHERE PersonelID = @PersonelID";
            MySqlCommand getPersonelCmd = new MySqlCommand(getPersonelQuery, connection2);
            getPersonelCmd.Parameters.AddWithValue("@PersonelID", personelId);
            using (MySqlDataReader reader = getPersonelCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    double saatlikMaas = reader.GetDouble("SaatlikMaas");
                    bool es = reader.GetBoolean("EsinCalismaDurumu");
                    bool medeni = reader.GetBoolean("Medeni");
                    int cocuksayisi = reader.GetInt32("Cocuksayisi");
                    int engeldurumu = reader.GetInt32("EngellilikDurumu");
                    DateTime maasayi = maasTarih.Value;
                    int ay = maasayi.Month;
                    double aylikBrutMaas = saatlikMaas * 225;
                    double fazlaMesaiUcreti = fazlaCalismaSuresi * saatlikMaas * 1.5;
                    double sgkCalisan = aylikBrutMaas * 0.14;
                    double sgkIsveren = aylikBrutMaas * 0.205;
                    double issizlikSigortasiCalisan = aylikBrutMaas * 0.01;
                    double issizlikSigortasiIsveren = aylikBrutMaas * 0.02;
                    double hazineDestegi = aylikBrutMaas * 0.05;
                    double aileYardimi = 0;
                    aileYardimi += cocuksayisi * 200.16;
                    if (medeni == true && es==false) aileYardimi += 1000.80;
                    double toplammaas = aylikBrutMaas * ay;
                    double vergi27 = 580000;
                    double vergi20 = 230000;
                    double vergi15 = 110000;
                    double damgavergisiindirim = (88.9 * 225) * 0.00759;
                    double gelirvergisiindirim = 0;
                    double gelirvergisi;
                    double damgavergisi = (aylikBrutMaas) * 0.00759;
                    double gelirvergisitoplam = 0;
                    if (toplammaas <= vergi15)
                    {
                        gelirvergisitoplam = (aylikBrutMaas - sgkCalisan) * 0.15;
                        gelirvergisiindirim = (88.9 * 225 - sgkCalisan) * 0.15;
                    }
                    else if (vergi15 <= toplammaas || toplammaas <= vergi20)
                    {
                        gelirvergisitoplam = (aylikBrutMaas - sgkCalisan) * 0.20;
                        gelirvergisiindirim = (88.9 * 225 - sgkCalisan) * 0.20;
                    }
                    else if (vergi20 <= toplammaas || toplammaas <= vergi27)
                    {
                        gelirvergisitoplam = (aylikBrutMaas - sgkCalisan) * 0.27;
                        gelirvergisiindirim = (88.9 * 225 - sgkCalisan) * 0.27;
                    }



                    double damgatoplam = damgavergisi - damgavergisiindirim;
                    gelirvergisi = gelirvergisitoplam - gelirvergisiindirim;
                    double engelindirimi;
                    if (gelirvergisi > 0)
                    {
                        if(engeldurumu==0)
                        { }
                        else if(engeldurumu==1)
                        {
                            gelirvergisi = gelirvergisi - 4400;
                            if (gelirvergisi < 0) { gelirvergisi = 0; }
                        }
                        else if (engeldurumu == 2)
                        {
                            gelirvergisi = gelirvergisi - 2600;
                            if (gelirvergisi < 0) { gelirvergisi = 0; }
                        }
                        else if (engeldurumu == 3)
                        {
                            gelirvergisi = gelirvergisi - 1100;
                            if (gelirvergisi < 0) { gelirvergisi = 0; }
                        }
                    }

                    double netMaas = aylikBrutMaas + fazlaMesaiUcreti + ekOdemeler + aileYardimi - damgatoplam - gelirvergisi - sgkCalisan - issizlikSigortasiCalisan;
                    double sirketeBedeli = aylikBrutMaas + sgkIsveren + issizlikSigortasiIsveren + fazlaMesaiUcreti + ekOdemeler - hazineDestegi;
                    MySqlConnection connection4 = new MySqlConnection(connectionString);
                    connection4.Open();
                    string maasekleString = "INSERT INTO maasbilgisi (PersonelID, MaasGunu, FazlaCalismaSuresi,AileYardimi, EkOdemeler, SGK, IssizlikSigortasi, NetMaas, SirketeBedeli, SGKIsveren, IssizlikSigortasiIsveren, HazineDestegi, GelirVergisiToplam,GelirVergisiIndirim,DamgaVergisi,DamgaVergisiIndirim) " +
                        "VALUES (@PersonelID, @MaasGunu, @FazlaCalismaSuresi,@AileYardimi, @EkOdemeler, @SGK, @IssizlikSigortasi, @NetMaas, @SirketeBedeli, @SGKIsveren, @IssizlikSigortasiIsveren, @HazineDestegi, @GelirVergisiToplam,@GelirVergisiIndirim,@DamgaVergisi,@DamgaVergisiIndirim)";
                    MySqlCommand maasekle = new MySqlCommand(maasekleString, connection4);
                    maasekle.Parameters.AddWithValue("@PersonelID", personelId);
                    maasekle.Parameters.AddWithValue("@MaasGunu", maasGunu);
                    maasekle.Parameters.AddWithValue("@FazlaCalismaSuresi", fazlaCalismaSuresi);
                    maasekle.Parameters.AddWithValue("@AileYardimi", aileYardimi);
                    maasekle.Parameters.AddWithValue("@EkOdemeler", ekOdemeler);
                    maasekle.Parameters.AddWithValue("@SGK", sgkCalisan);
                    maasekle.Parameters.AddWithValue("@IssizlikSigortasi", issizlikSigortasiCalisan);
                    maasekle.Parameters.AddWithValue("@NetMaas", netMaas);
                    maasekle.Parameters.AddWithValue("@SirketeBedeli", sirketeBedeli);
                    maasekle.Parameters.AddWithValue("@SGKIsveren", sgkIsveren);
                    maasekle.Parameters.AddWithValue("@IssizlikSigortasiIsveren", issizlikSigortasiIsveren);
                    maasekle.Parameters.AddWithValue("@HazineDestegi", hazineDestegi);
                    maasekle.Parameters.AddWithValue("@GelirVergisiToplam", gelirvergisitoplam);
                    maasekle.Parameters.AddWithValue("@GelirVergisiIndirim", gelirvergisiindirim);
                    maasekle.Parameters.AddWithValue("@DamgaVergisi", damgavergisi);
                    maasekle.Parameters.AddWithValue("@DamgaVergisiIndirim", damgavergisiindirim);
                    maasekle.ExecuteNonQuery();
                    MessageBox.Show("Maas detaylarý baþarýyla eklendi!");
                    MaasGetir();
                    connection4.Close();
                }
            }
            connection2.Close();
            txtMesai.Text = "0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}