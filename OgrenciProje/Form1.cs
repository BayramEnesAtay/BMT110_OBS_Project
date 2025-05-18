using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;



namespace OgrenciProje
{
    

    public partial class Form1 : Form

    {
        string baglantiYolu = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ogrenciler.accdb";




        OleDbConnection baglanti;
        public Form1()
        {
            InitializeComponent();
            baglanti = new OleDbConnection(baglantiYolu); // Burada sadece başlatılıyor

        }

        

        int OgrenciEkle(string ad,string numara,string sifre)
        {
            int sonId;
            using (OleDbConnection baglanti = new OleDbConnection(baglantiYolu))
            {
                baglanti.Open();

                using (OleDbCommand komut = new OleDbCommand("INSERT INTO ogrenciler (AdSoyAd, Numara, Sifre) VALUES (@adsoyad, @numara, @sifre)", baglanti))
                {
                    komut.Parameters.AddWithValue("@adsoyad", ad);
                    komut.Parameters.AddWithValue("@numara", numara);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    komut.ExecuteNonQuery();

                    komut.CommandText = "SELECT @@IDENTITY";
                    sonId = Convert.ToInt32(komut.ExecuteScalar());
                }
            }
            return sonId;


        }


        bool SifreKontrol(string kullaniciAdi, string girilenSifre)
        {

            string sql = "SELECT Sifre FROM ogrenciler WHERE AdSoyAd = @adsoyad";
            object result;
            using (OleDbConnection baglanti = new OleDbConnection(baglantiYolu))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, baglanti))
                {
                    cmd.Parameters.AddWithValue("@adsoyad", kullaniciAdi);
                    baglanti.Open();
                     result = cmd.ExecuteScalar();
                    
                }
            }


            //result bızım sıfre degıskenımız.
            if (result != null)
            {
                string kayitliSifre = result.ToString();
                return kayitliSifre == girilenSifre;
            }
            else
            {
                // Kullanıcı bulunamadı
                return false;
            }
        }


        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAd.Text) && !string.IsNullOrWhiteSpace(txtno.Text) && !string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                if (SifreKontrol(txtAd.Text, txtsifre.Text))
                {
                    MessageBox.Show("Giriş Başarılı");
                    //kullanıcı dogru gırdıyse yanı varsa bu seferı ısme gore ıd alımı yapıyoruz.

                    object result;
                    using (OleDbConnection baglanti = new OleDbConnection(baglantiYolu))
                    {
                        baglanti.Open();
                        using (OleDbCommand komut = new OleDbCommand("SELECT OgrID FROM ogrenciler WHERE AdSoyAd = @adsoyad", baglanti))
                        {
                            komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
                             result = komut.ExecuteScalar();
                        }
                    }



                    if (result != null)
                    {
                        int ogrenciID = Convert.ToInt32(result);
                        Form3 frm3 = new Form3(ogrenciID);
                        frm3.Show();
                        this.Hide();
                        // ogrenciID burada o öğrencinin ID'si
                    }
                    else
                    {
                        // Öğrenci bulunamadı
                    }

                   
                }
                else
                {
                    // Eğer kullanıcı varsa ama şifre yanlış
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("SELECT COUNT(*) FROM ogrenciler WHERE AdSoyAd = @adsoyad", baglanti);
                    komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
                    int sayi = (int)komut.ExecuteScalar();//ad soyad bulunup bulunmadıgı sorgulanır.
                    baglanti.Close();
                    //ısım en az bır kez bulunmus
                    if (sayi > 0)
                    {
                        MessageBox.Show("Şifre yanlış, lütfen tekrar deneyin.");
                        txtsifre.Clear();
                        txtsifre.Focus();
                    }
                    else
                    {
                        baglanti.Open();
                        // Kullanıcı yoksa ekle
                        int yeniId=OgrenciEkle(txtAd.Text, txtno.Text, txtsifre.Text);
                        MessageBox.Show("Öğrenci eklendi.");
                        txtAd.Clear();
                        txtno.Clear();
                        txtsifre.Clear();
                        OleDbCommand komut2 = new OleDbCommand("SELECT OgrID FROM ogrenciler WHERE AdSoyAd = @adsoyad", baglanti);
                        komut2.Parameters.AddWithValue("@adsoyad", txtAd.Text);

                        object result = komut.ExecuteScalar();
                        if (result != null)
                        {
                            int ogrenciID = Convert.ToInt32(result);
                            Form3 frm3 = new Form3(yeniId);
                            frm3.Show();
                            this.Hide();
                            // ogrenciID burada o öğrencinin ID'si
                        }
                        baglanti.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
