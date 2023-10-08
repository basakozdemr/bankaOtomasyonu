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

namespace nesneProje
{
    public partial class Frm_ParaYatir : Form
    {
        public Frm_ParaYatir()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=nesne;User Id=postgres;Password=1234");



        string bakiye;



        public int verileri_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                bakiye = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();
            return 0;
        }

        string bankapara;
        public int bankaPara_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                bankapara = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();
            return 0;
        }




        private void btn_ParaYatir_Click(object sender, EventArgs e)
        {

            DateTime tarih = System.DateTime.Now;
            verileri_goster("select bakiye\r\nfrom musteri\r\nwhere hesapno='" + txt_HesapNo.Text + "' ");
            int yenibakiye = Convert.ToInt32(bakiye) + Convert.ToInt32(txt_YatirilacakMiktar.Text);

            bankaPara_goster("select yenipara\r\nfrom banka");
            string bankaPara = bankapara;

            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;
            komut_ekle.Parameters.AddWithValue("@islemturu", "para yatırma");
            komut_ekle.Parameters.AddWithValue("@tarih", tarih);
            komut_ekle.Parameters.AddWithValue("@yatirilanmiktar", Convert.ToInt32(txt_YatirilacakMiktar.Text));
            komut_ekle.Parameters.AddWithValue("@hesapno", Convert.ToInt32(txt_HesapNo.Text));
            komut_ekle.Parameters.AddWithValue("@bakiye", Convert.ToInt32(bakiye));
            komut_ekle.Parameters.AddWithValue("@yenibakiye", yenibakiye);
            komut_ekle.CommandText = "insert into para_yatir (islemturu, tarih, yatirilanmiktar, hesapno, bakiye, yenibakiye) values (@islemturu, @tarih, @yatirilanmiktar, @hesapno, @bakiye, @yenibakiye)";
            komut_ekle.CommandType = CommandType.Text;
            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            conn.Close();
            komut_ekle.Dispose();


            conn.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = conn;
            komut_guncelle.Parameters.AddWithValue("@hesapno", Convert.ToInt32(txt_HesapNo.Text));
            komut_guncelle.Parameters.AddWithValue("@yenibakiye", yenibakiye);
            komut_guncelle.CommandText = "update musteri set bakiye=@yenibakiye where hesapno = @hesapno";
            komut_guncelle.CommandType = CommandType.Text;
            NpgsqlDataReader dr2 = komut_guncelle.ExecuteReader();
            conn.Close();
            komut_guncelle.Dispose();



            conn.Open();
            NpgsqlCommand komut_bankaveri = new NpgsqlCommand();
            komut_bankaveri.Connection = conn;
            komut_bankaveri.Parameters.AddWithValue("@islemturu", "para yatırma");
            komut_bankaveri.Parameters.AddWithValue("@hesapno", Convert.ToInt32(txt_HesapNo.Text));
            komut_bankaveri.Parameters.AddWithValue("@yatirilanmiktar", Convert.ToInt32(txt_YatirilacakMiktar.Text));
            komut_bankaveri.Parameters.AddWithValue("@tarih", tarih);
            komut_bankaveri.Parameters.AddWithValue("@bankapara", Convert.ToInt32(bankapara));
            komut_bankaveri.Parameters.AddWithValue("bankaeklenenpara", Convert.ToInt32(txt_YatirilacakMiktar.Text));
            komut_bankaveri.Parameters.AddWithValue("@bankayenipara", Convert.ToInt32(bankapara) + Convert.ToInt32(txt_YatirilacakMiktar.Text));
            komut_bankaveri.CommandText = "insert into banka (islemturu, hesapno, miktar, para, degisim, yenipara, tarih) values (@islemturu, @hesapno, @yatirilanmiktar, @bankapara, @bankaeklenenpara, @bankayenipara, @tarih)";
            komut_bankaveri.CommandType = CommandType.Text;
            NpgsqlDataReader dr4 = komut_bankaveri.ExecuteReader();
            conn.Close();
            komut_bankaveri.Dispose();

            MessageBox.Show("KAYIT BAŞARILI", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
