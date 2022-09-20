using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SQLite;

namespace protim
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form3 form3 = new Form3();

        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        string id;
        int yenisayi, kayitsayisi;

        public void listele()
        {
            con = new SQLiteConnection("Data Source=protimkyt.sqlite;Version=3;");
            da = new SQLiteDataAdapter("Select *From genel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "genel");
            metroGrid1.DataSource= ds.Tables["genel"];
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            metroGrid1.Columns[0].Visible = false;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string aranan = textBox1.Text.Trim().ToUpper();
            try
            {
                da = new SQLiteDataAdapter("select * from genel where hastaadi like '" + aranan + "%'", con);
                ds = new DataSet();
                da.Fill(ds, "genel");
                metroGrid1.DataSource = ds.Tables["genel"];
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                string aranan = textBox1.Text.Trim().ToUpper();
                da = new SQLiteDataAdapter("SELECT subeadi,tarih,hastahane,raporuch,gonderen,hastaadi,yapilan,marka,model,serino,kulak,satistut,kalanborc,zraporno,dokumanno,giren,cikan,notdb,gelir,gider,banka,kredikarti,kkkomisyon,ilgpersonel FROM genel Where tarih BETWEEN @tar1 and @tar2 and hastaadi like '" + aranan + "%'", con);
                ds = new DataSet();
                da.SelectCommand.Parameters.AddWithValue("@tar1", dateTimePicker1.Value);
                da.SelectCommand.Parameters.AddWithValue("@tar2", dateTimePicker2.Value);
                con.Open();
                da.Fill(ds, "genel");
                metroGrid1.DataSource = ds.Tables["genel"];
                con.Close();
            }
            else
            {
                da = new SQLiteDataAdapter("SELECT subeadi,tarih,hastahane,raporuch,gonderen,hastaadi,yapilan,marka,model,serino,kulak,satistut,kalanborc,zraporno,dokumanno,giren,cikan,notdb,gelir,gider,banka,kredikarti,kkkomisyon,ilgpersonel FROM genel Where tarih BETWEEN @tar1 and @tar2", con);
                ds = new DataSet();
                da.SelectCommand.Parameters.AddWithValue("@tar1", dateTimePicker1.Value);
                da.SelectCommand.Parameters.AddWithValue("@tar2", dateTimePicker2.Value);
                con.Open();
                da.Fill(ds, "genel");
                metroGrid1.DataSource = ds.Tables["genel"];
                con.Close();
            }
                
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            id = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                DialogResult sonuc = new DialogResult();
                sonuc = MessageBox.Show("Seçili Faaliyeti silmek istediğinizden emin misiniz ? ", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {

                    SQLiteCommand komut = new SQLiteCommand("delete from genel where id=@id ", con);
                    con.Open();
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();
                    con.Close();
                    listele();
                    yenisayi = metroGrid1.RowCount;
                    listele();
                    if (kayitsayisi != yenisayi)
                    {
                        MessageBox.Show("Silme İşlemi Başarılı.", "Sil !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Silme İşlemi Başarısız!", "Sil !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
    }
}
