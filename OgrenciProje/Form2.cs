
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

namespace OgrenciProje
{
    public partial class Form2 : Form
    {

        string baglantiYolu2 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dersler.accdb";
        OleDbConnection baglanti2;
        int OgrID;
        public Form2(int Id)
        {
            InitializeComponent();
            OgrID = Id;
            baglanti2 = new OleDbConnection(baglantiYolu2); // Burada sadece başlatılıyor
        }


        void DersEkle(int ID,string ders, string notum, string devam)
        {
            baglanti2.Open();

            OleDbCommand komut2 = new OleDbCommand("INSERT INTO dersler (OgrID,DersAdi, Notum, Devamsizlik) VALUES (@ID,@ders, @notum, @devam)", baglanti2);
            komut2.Parameters.AddWithValue("@ID", ID);
            komut2.Parameters.AddWithValue("@ders", ders);
            komut2.Parameters.AddWithValue("@notum", notum);
            komut2.Parameters.AddWithValue("@devam", devam);


            komut2.ExecuteNonQuery();

            baglanti2.Close();

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtders.Text) && !string.IsNullOrWhiteSpace(txtnot.Text) && !string.IsNullOrWhiteSpace(txtdevam.Text))
            {
                DersEkle(OgrID,txtders.Text, txtnot.Text, txtdevam.Text);
                MessageBox.Show("Ders eklendi.");
                txtders.Clear();
                txtnot.Clear();
                txtdevam.Clear();
                //OgrencileriListele();
            }
            else
            {
                MessageBox.Show("Lütfen bir ders girin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(OgrID);
            form4.Show();
            this.Hide();
        }
    }
}
