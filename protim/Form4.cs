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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        string tarih;
        string id;
        int yenisayi, kayitsayisi;
        void listele()
        {
            con = new SQLiteConnection("Data Source=protimkyt.sqlite;Version=3;");
            da = new SQLiteDataAdapter("Select *From hasta", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "hasta");
            metroGrid1.DataSource = ds.Tables["hasta"];
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                listele();
                cmd = new SQLiteCommand();
                
                con.Open();
                cmd.Connection = con;
                tarih = dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                cmd.CommandText = "insert into hasta(adsoyad,telefon,adres,dtarih,cinsiyet) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + tarih + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Kayıt Başarılı");
                listele();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
                listele();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listele();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listele();
            metroGrid1.Columns[0].Visible = false;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            id = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                DialogResult sonuc = new DialogResult();
                sonuc = MessageBox.Show("Seçili Hastayı silmek istediğinizden emin misiniz ? ", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                   
                    SQLiteCommand komut = new SQLiteCommand("delete from hasta where id=@id ", con);
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

