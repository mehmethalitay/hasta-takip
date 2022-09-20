using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace protim
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel1.Text = System.DateTime.Now.ToLongDateString() +" "+ System.DateTime.Now.ToLongTimeString();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Limitsiz Reklam Tarafından OĞUZHAN DUMAN PROTİM İŞİTME MERKEZİ için kodlanmıştır. Tüm Hakları Saklıdır. İzinsiz Kopyalanamaz Çoğaltılamaz. İrtibat Tel : 0534 300 48 41");
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kodlanma Aşamasında");

        }
    }
}
