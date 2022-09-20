using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace protim
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;

        SQLiteDataAdapter da1;
        SQLiteCommand cmd1;
        DataSet ds1;
        string tarih;
        string hastaadic;
        void listele()
        {
            con = new SQLiteConnection("Data Source=protimkyt.sqlite;Version=3;");
            da = new SQLiteDataAdapter("Select *From genel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "genel");

            comboBox1.Items.Clear();

            SQLiteCommand komut = new SQLiteCommand("select * from hasta", con);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["adsoyad"].ToString());
            }
            con.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
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
                tarih= dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                cmd.CommandText = "insert into genel(subeadi,tarih,hastahane,raporuch,gonderen,hastaadi,yapilan,marka,model,serino,kulak,satistut,kalanborc,zraporno,dokumanno,giren,cikan,notdb,gelir,gider,banka,kredikarti,kkkomisyon,ilgpersonel) values ('" + textBox1.Text + "','" + tarih + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + hastaadic + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";
                textBox22.Text = "";
                textBox23.Text = "";
                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            hastaadic = comboBox1.Text;

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.listele();
        }
    }
}
