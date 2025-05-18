using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciProje
{
    public partial class Form3 : Form
    {
        int OgrId;
        public Form3(int ID)
        {
            InitializeComponent();
            OgrId = ID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(OgrId);
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(OgrId);
            frm4.Show();
            this.Hide();
        }
    }
}
