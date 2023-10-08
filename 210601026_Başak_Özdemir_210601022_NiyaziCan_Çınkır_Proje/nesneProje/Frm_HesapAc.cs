using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace nesneProje
{
     partial class Frm_HesapAc : Form
    {

        public Frm_HesapAc()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=nesne;User Id=postgres;Password=1234");

        string adsoyad;
        string musteritipi;
        public int adsoyad_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                adsoyad = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();
            return 0;
        }

        public int musteriTipi_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                musteritipi = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();
            return 0;
        }



        private void btn_HesapAc_Click(object sender, EventArgs e)
        {


            Random r = new Random();
            int hesapNo = r.Next(100, 999);
            int bakiye = 0;

            adsoyad_goster("select adsoyad\r\nfrom musteri\r\nwhere musteriid='" + txt_MusteriID.Text + "' ");
            string adSoyad = adsoyad;
            musteriTipi_goster("select musteritipi\r\nfrom musteri\r\nwhere musteriid='" + txt_MusteriID.Text + "' ");
            string musteriTipi = musteritipi;


            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;
            komut_ekle.Parameters.AddWithValue("@adsoyad", adSoyad);
            komut_ekle.Parameters.AddWithValue("@musteritipi", musteriTipi);
            komut_ekle.Parameters.AddWithValue("@musteriid", Convert.ToInt32(txt_MusteriID.Text));
            komut_ekle.Parameters.AddWithValue("@hesapno", hesapNo);
            komut_ekle.Parameters.AddWithValue("@bakiye", bakiye);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into musteri (musteriid, adsoyad, musteritipi, bakiye, hesapno) values (@musteriid, @adsoyad, @musteritipi, @bakiye, @hesapno)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();

            conn.Close();
            komut_ekle.Dispose();

            MessageBox.Show("KAYIT BAŞARILI", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

 


    }
    }
}
