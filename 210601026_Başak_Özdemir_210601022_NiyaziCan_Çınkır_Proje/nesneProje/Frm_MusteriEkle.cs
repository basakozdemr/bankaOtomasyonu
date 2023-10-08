using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Npgsql;
using System.Windows.Forms.VisualStyles;
using System.Reflection.Emit;

namespace nesneProje
{
    public partial class Frm_MusteriEkle : Form
    {
        public Frm_MusteriEkle()
        {
            InitializeComponent();
           
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=nesne;User Id=postgres;Password=1234");



        public int verileri_goster(string txt, DataGridView dataGridView)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridView.DataSource = dt;

            }
            komut.Dispose();
            conn.Close();
            return 0;
        }



        private void Btn_MusteriEkle_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int musteriId = rand.Next(100, 999);

            Random r = new Random();
            int hesapNo = r.Next(100, 999);
            int bakiye = 0;
            int gunlukLimit = 750;


            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;
            komut_ekle.Parameters.AddWithValue("@adsoyad", txt_AdSoyad.Text);

            if (rb_BireyselMusteri.Checked)
            {
                string musteritipi = "bireyselmusteri";
                komut_ekle.Parameters.AddWithValue("@musteritipi", musteritipi);

            }
            else if (rb_TicariMusteri.Checked)
            {
                string musteritipi = "ticarimusteri";
                komut_ekle.Parameters.AddWithValue("@musteritipi", musteritipi);

            }
            else
            {
                MessageBox.Show("Müşteri tipi seçiniz.");
            }

            komut_ekle.Parameters.AddWithValue("@bakiye", bakiye);
            komut_ekle.Parameters.AddWithValue("@hesapno", hesapNo);
            komut_ekle.Parameters.AddWithValue("@musteriid", musteriId);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into musteri (musteriid, adsoyad, musteritipi, bakiye, hesapno) values (@musteriid, @adsoyad, @musteritipi, @bakiye, @hesapno)";
            NpgsqlDataReader dr = komut_ekle.ExecuteReader();

            conn.Close();
            komut_ekle.Dispose();

            MessageBox.Show("KAYIT BAŞARILI", "", MessageBoxButtons.OK, MessageBoxIcon.Information);





            DateTime tarih = System.DateTime.Now;

            conn.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = conn;
            komut_guncelle.Parameters.AddWithValue("@gunluklimit", 750);
            komut_guncelle.Parameters.AddWithValue("@hesapno", hesapNo);
            komut_guncelle.Parameters.AddWithValue("@tarih", tarih);
            komut_guncelle.CommandText = "insert into gunluklimit (hesapno,tarih,gunluklimit) values (@hesapno,@tarih,@gunluklimit)";


            komut_guncelle.CommandType = CommandType.Text;
            NpgsqlDataReader dr2 = komut_guncelle.ExecuteReader();
            conn.Close();
            komut_guncelle.Dispose();


            label3.Visible = true;
            lblatamaYapılacak.Text = musteriId.ToString();

        }





    }
}

