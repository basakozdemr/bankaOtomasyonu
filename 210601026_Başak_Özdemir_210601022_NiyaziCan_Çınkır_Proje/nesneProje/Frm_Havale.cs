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
    public partial class Frm_Havale : Form
    {
        public Frm_Havale()
        {
            InitializeComponent();
        }

        string bakiye;
        string alicibakiye;
        string gonderenmusteritipi;
        string alicimusteritipi;
        string bankapara;

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=nesne;User Id=postgres;Password=1234");


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
        public int veri_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                alicibakiye = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();
            return 0;
        }


        public int gonderenMusteriTipi_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                gonderenmusteritipi = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();
            return 0;
        }

        public int aliciMusteriTipi_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                alicimusteritipi = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();
            return 0;
        }


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

        

        private void btn_HavaleYap_Click(object sender, EventArgs e)
        {

            DateTime tarih = System.DateTime.Now;
            verileri_goster("select bakiye\r\nfrom musteri\r\nwhere hesapno='" + txt_HesapNo.Text + "' ");
            string gonderenBakiye = bakiye; 
            veri_goster("select bakiye\r\nfrom musteri\r\nwhere hesapno='" + txt_AliciHesapNo.Text + "' ");
            string aliciBakiye = alicibakiye;
            gonderenMusteriTipi_goster("select musteritipi\r\nfrom musteri\r\nwhere hesapno='" + txt_HesapNo.Text + "' ");
            string gonderenMusteriTipi = gonderenmusteritipi;
            aliciMusteriTipi_goster("select musteritipi\r\nfrom musteri\r\nwhere hesapno='" + txt_AliciHesapNo.Text + "' ");
            string aliciMusteriTipi = alicimusteritipi;
            bankaPara_goster("select yenipara\r\nfrom banka");
            string bankaPara = bankapara;
            

            int havaleMiktari = Convert.ToInt32(txt_HavaleMiktar.Text);
            int havaleUcreti = havaleMiktari * 2 / 100;


            if (gonderenMusteriTipi=="bireyselmusteri")
            {      if(Convert.ToInt32(bakiye)- havaleMiktari-havaleUcreti >=0 )
                {

                
                int bankaYeniPara = Convert.ToInt32(bankaPara) + havaleUcreti;

                int gonderenYeniBakiye = Convert.ToInt32(gonderenBakiye) - havaleMiktari - havaleUcreti;
                int aliciYeniBakiye = Convert.ToInt32(aliciBakiye) +havaleMiktari;
                conn.Open();
                NpgsqlCommand komut_azalt = new NpgsqlCommand();
                komut_azalt.Connection = conn;
                komut_azalt.Parameters.AddWithValue("@islemturu", "havale");
                komut_azalt.Parameters.AddWithValue("@tarih", tarih);
                komut_azalt.Parameters.AddWithValue("@gonderilenmiktar",havaleMiktari);
                komut_azalt.Parameters.AddWithValue("@gonderenhesapno", Convert.ToInt32(txt_HesapNo.Text));
                komut_azalt.Parameters.AddWithValue("@alicihesapno", Convert.ToInt32(txt_AliciHesapNo.Text));
                komut_azalt.Parameters.AddWithValue("@gonderenbakiye", Convert.ToInt32(gonderenBakiye));
                komut_azalt.Parameters.AddWithValue("@alicibakiye", Convert.ToInt32(aliciBakiye));

                komut_azalt.CommandText = "insert into havale (islemturu, hesapno, bakiye, alicihesapno, alicibakiye, gonderilenmiktar, tarih) values (@islemturu, @gonderenhesapno, @gonderenbakiye, @alicihesapno, @alicibakiye, @gonderilenmiktar, @tarih)";
                komut_azalt.CommandType = CommandType.Text;
                NpgsqlDataReader dr = komut_azalt.ExecuteReader();
                conn.Close();
                komut_azalt.Dispose();



                conn.Open();
                NpgsqlCommand komut_guncelle = new NpgsqlCommand();
                komut_guncelle.Connection = conn;
                komut_guncelle.Parameters.AddWithValue("@gonderenhesapno", Convert.ToInt32(txt_HesapNo.Text));
                komut_guncelle.Parameters.AddWithValue("@gonderenyenibakiye", gonderenYeniBakiye);
                komut_guncelle.CommandText = "update musteri set bakiye=@gonderenyenibakiye where hesapno = @gonderenhesapno";
                komut_guncelle.CommandType = CommandType.Text;
                NpgsqlDataReader dr2 = komut_guncelle.ExecuteReader();
                conn.Close();
                komut_guncelle.Dispose();



                conn.Open();
                NpgsqlCommand komut_aliciguncelle = new NpgsqlCommand();
                komut_aliciguncelle.Connection = conn;
                komut_aliciguncelle.Parameters.AddWithValue("@alicihesapno", Convert.ToInt32(txt_AliciHesapNo.Text));
                komut_aliciguncelle.Parameters.AddWithValue("@aliciyenibakiye", aliciYeniBakiye);
                komut_aliciguncelle.CommandText = "update musteri set bakiye=@aliciyenibakiye where hesapno = @alicihesapno";
                komut_aliciguncelle.CommandType = CommandType.Text;
                NpgsqlDataReader dr3 = komut_aliciguncelle.ExecuteReader();
                conn.Close();
                komut_aliciguncelle.Dispose();



                conn.Open();
                NpgsqlCommand komut_bankaveri = new NpgsqlCommand();
                komut_bankaveri.Connection = conn;
                komut_bankaveri.Parameters.AddWithValue("@islemturu", "havale");
                komut_bankaveri.Parameters.AddWithValue("@gonderenhesapno", Convert.ToInt32(txt_HesapNo.Text));
                komut_bankaveri.Parameters.AddWithValue("@gonderilenmiktar", havaleMiktari);
                komut_bankaveri.Parameters.AddWithValue("@tarih", tarih);
                komut_bankaveri.Parameters.AddWithValue("@bankapara", Convert.ToInt32(bankapara));
                komut_bankaveri.Parameters.AddWithValue("@eklenenpara", havaleUcreti);
                komut_bankaveri.Parameters.AddWithValue("@bankayenipara", bankaYeniPara);
                komut_bankaveri.CommandText = "insert into banka (islemturu, hesapno, miktar, para, degisim, yenipara, tarih) values (@islemturu, @gonderenhesapno, @gonderilenmiktar, @bankapara, @eklenenpara,  @bankayenipara, @tarih)";
                komut_bankaveri.CommandType = CommandType.Text;
                NpgsqlDataReader dr4 = komut_bankaveri.ExecuteReader();
                conn.Close();
                komut_bankaveri.Dispose();


                    MessageBox.Show("Havale Başarılı", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else    MessageBox.Show("Havale Sonrası Bakiyeniz 0 TL altına Düşemez ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                if (Convert.ToInt32(bakiye) - havaleMiktari  >= 0) { 

                    int gonderenYeniBakiye = Convert.ToInt32(gonderenBakiye) - havaleMiktari;
                int aliciYeniBakiye = Convert.ToInt32(aliciBakiye) + havaleMiktari;
                conn.Open();
                NpgsqlCommand komut_azalt = new NpgsqlCommand();
                komut_azalt.Connection = conn;
                komut_azalt.Parameters.AddWithValue("@islemturu", "havale");
                komut_azalt.Parameters.AddWithValue("@tarih", tarih);
                komut_azalt.Parameters.AddWithValue("@gonderilenmiktar", havaleMiktari);
                komut_azalt.Parameters.AddWithValue("@gonderenhesapno", Convert.ToInt32(txt_HesapNo.Text));
                komut_azalt.Parameters.AddWithValue("@alicihesapno", Convert.ToInt32(txt_AliciHesapNo.Text));
                komut_azalt.Parameters.AddWithValue("@gonderenbakiye", Convert.ToInt32(gonderenBakiye));
                komut_azalt.Parameters.AddWithValue("@alicibakiye", Convert.ToInt32(aliciBakiye));

                komut_azalt.CommandText = "insert into havale (islemturu, hesapno, bakiye, alicihesapno, alicibakiye, gonderilenmiktar, tarih) values (@islemturu, @gonderenhesapno, @gonderenbakiye, @alicihesapno, @alicibakiye, @gonderilenmiktar, @tarih)";
                komut_azalt.CommandType = CommandType.Text;
                NpgsqlDataReader dr = komut_azalt.ExecuteReader();
                conn.Close();
                komut_azalt.Dispose();



                conn.Open();
                NpgsqlCommand komut_guncelle = new NpgsqlCommand();
                komut_guncelle.Connection = conn;
                komut_guncelle.Parameters.AddWithValue("@gonderenhesapno", Convert.ToInt32(txt_HesapNo.Text));
                komut_guncelle.Parameters.AddWithValue("@gonderenyenibakiye", gonderenYeniBakiye);
                komut_guncelle.CommandText = "update musteri set bakiye=@gonderenyenibakiye where hesapno = @gonderenhesapno";
                komut_guncelle.CommandType = CommandType.Text;
                NpgsqlDataReader dr2 = komut_guncelle.ExecuteReader();
                conn.Close();
                komut_guncelle.Dispose();



                conn.Open();
                NpgsqlCommand komut_aliciguncelle = new NpgsqlCommand();
                komut_aliciguncelle.Connection = conn;
                komut_aliciguncelle.Parameters.AddWithValue("@alicihesapno", Convert.ToInt32(txt_AliciHesapNo.Text));
                komut_aliciguncelle.Parameters.AddWithValue("@aliciyenibakiye", aliciYeniBakiye);
                komut_aliciguncelle.CommandText = "update musteri set bakiye=@aliciyenibakiye where hesapno = @alicihesapno";
                komut_aliciguncelle.CommandType = CommandType.Text;
                NpgsqlDataReader dr3 = komut_aliciguncelle.ExecuteReader();
                conn.Close();
                komut_aliciguncelle.Dispose();




                conn.Open();
                NpgsqlCommand komut_bankaveri = new NpgsqlCommand();
                komut_bankaveri.Connection = conn;
                komut_bankaveri.Parameters.AddWithValue("@islemturu", "havale");
                komut_bankaveri.Parameters.AddWithValue("@gonderenhesapno", Convert.ToInt32(txt_HesapNo.Text));
                komut_bankaveri.Parameters.AddWithValue("@gonderilenmiktar", havaleMiktari);
                komut_bankaveri.Parameters.AddWithValue("@tarih", tarih);
                komut_bankaveri.Parameters.AddWithValue("@bankapara", Convert.ToInt32(bankapara));
                komut_bankaveri.Parameters.AddWithValue("bankaeklenenpara", 0);
                komut_bankaveri.Parameters.AddWithValue("@bankayenipara", Convert.ToInt32(bankapara));
                komut_bankaveri.CommandText = "insert into banka (islemturu, hesapno, miktar, para, degisim, yenipara, tarih) values (@islemturu, @gonderenhesapno, @gonderilenmiktar, @bankapara, @bankaeklenenpara, @bankayenipara, @tarih)";
                komut_bankaveri.CommandType = CommandType.Text;
                NpgsqlDataReader dr4 = komut_bankaveri.ExecuteReader();
                conn.Close();
                komut_bankaveri.Dispose();

                    MessageBox.Show("Havale Başarılı", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Havale Sonrası Bakiyeniz 0 TL altına Düşemez ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }





        }
    }
}
