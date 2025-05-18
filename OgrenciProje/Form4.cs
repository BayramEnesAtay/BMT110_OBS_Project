using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciProje
{
    public partial class Form4 : Form
    {
        string baglantiYolu4 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dersler.accdb";
        OleDbConnection baglanti4;
        int OGrId;
        public Form4(int id)
        {
            InitializeComponent();
            OGrId = id;
            baglanti4 = new OleDbConnection(baglantiYolu4); // Burada sadece başlatılıyor
            this.Load += new System.EventHandler(this.Form4_Load); // Form yüklendiğinde çalışacak metodu bağlar
        }
        
            void OgrencileriListele()
            {
                try
                {
                    DataTable dt = new DataTable();
                    string sql = "SELECT DersAdi, Notum, Devamsizlik FROM dersler WHERE OgrID = @ogrID";
                     
                OleDbDataAdapter da = new OleDbDataAdapter(sql, baglanti4);
                // parametreye öğrencinin ID değerini veriyoruz
                da.SelectCommand.Parameters.AddWithValue("@ogrID", OGrId);
                da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }



        private void Form4_Load(object sender, EventArgs e)
        {
           
            dataGridView1.AutoGenerateColumns = true;
            OgrencileriListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
