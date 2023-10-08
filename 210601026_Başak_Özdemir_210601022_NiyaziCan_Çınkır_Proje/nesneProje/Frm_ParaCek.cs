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
     partial class Frm_ParaCek : Form 
    {
        public Frm_ParaCek ()
        {
            InitializeComponent();
             
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=nesne;User Id=postgres;Password=1234");

        string bakiye;
        string gunluklimit;


        public int verileri_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

           while(dr.Read())
            {
                 bakiye = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();
            return 0;
        }




        public int Gunluklimit(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                gunluklimit = dr[0].ToString();
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

        private void btn_ParaCek_Click(object sender, EventArgs e)
        {

            int cekilenmiktar = Convert.ToInt32(txt_CekilecekMiktar.Text);

 
            DateTime tarih = System.DateTime.Now;
            verileri_goster("select bakiye from musteri where hesapno='" + txt_HesapNo.Text + "' ");
            Gunluklimit("select gunluklimit from gunluklimit where hesapno='" + txt_HesapNo.Text + "' ");
            bankaPara_goster("select yenipara\r\nfrom banka");
            string bankaPara = bankapara;

            int gunlukLimit = Convert.ToInt32(gunluklimit);

            int yenibakiye = Convert.ToInt32(bakiye) - Convert.ToInt32(txt_CekilecekMiktar.Text);

            if (gunlukLimit - cekilenmiktar >= 0)
            {
                if (yenibakiye >= 0)
                {


                    gunlukLimit = gunlukLimit - cekilenmiktar;


                    conn.Open();
                    NpgsqlCommand komut_ekle = new NpgsqlCommand();
                    komut_ekle.Connection = conn;
                    komut_ekle.Parameters.AddWithValue("@islemturu", "para çekme");
                    komut_ekle.Parameters.AddWithValue("@tarih", tarih);
                    komut_ekle.Parameters.AddWithValue("@cekilenmiktar", Convert.ToInt32(txt_CekilecekMiktar.Text));
                    komut_ekle.Parameters.AddWithValue("@hesapno", Convert.ToInt32(txt_HesapNo.Text));
                    komut_ekle.Parameters.AddWithValue("@bakiye", Convert.ToInt32(bakiye));
                    komut_ekle.Parameters.AddWithValue("@yenibakiye", yenibakiye);
                    komut_ekle.Parameters.AddWithValue("@gunluklimit", gunlukLimit);

                    komut_ekle.CommandText = "insert into para_cek (islemturu, tarih, cekilenmiktar, hesapno, bakiye, yenibakiye,gunluklimit) values (@islemturu, @tarih, @cekilenmiktar, @hesapno, @bakiye, @yenibakiye ,@gunluklimit)";
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
                    NpgsqlCommand komut_limit = new NpgsqlCommand();
                    komut_limit.Connection = conn;
                    komut_limit.Parameters.AddWithValue("@hesapno", Convert.ToInt32(txt_HesapNo.Text));
                    komut_limit.Parameters.AddWithValue("@gunluklimit", gunlukLimit);
                    komut_limit.CommandText = "update gunluklimit set gunluklimit = @gunluklimit where hesapno = @hesapno";
                    komut_limit.CommandType = CommandType.Text;
                    NpgsqlDataReader dr3 = komut_limit.ExecuteReader();
                    conn.Close();
                    komut_limit.Dispose();



                    conn.Open();
                    NpgsqlCommand komut_bankaveri = new NpgsqlCommand();
                    komut_bankaveri.Connection = conn;
                    komut_bankaveri.Parameters.AddWithValue("@islemturu", "para çekme");
                    komut_bankaveri.Parameters.AddWithValue("@hesapno", Convert.ToInt32(txt_HesapNo.Text));
                    komut_bankaveri.Parameters.AddWithValue("@cekilenmiktar", Convert.ToInt32(txt_CekilecekMiktar.Text));
                    komut_bankaveri.Parameters.AddWithValue("@tarih", tarih);
                    komut_bankaveri.Parameters.AddWithValue("@bankapara", Convert.ToInt32(bankapara));
                    komut_bankaveri.Parameters.AddWithValue("bankaazalanpara", -Convert.ToInt32(txt_CekilecekMiktar.Text));
                    komut_bankaveri.Parameters.AddWithValue("@bankayenipara", Convert.ToInt32(bankapara) - Convert.ToInt32(txt_CekilecekMiktar.Text));
                    komut_bankaveri.CommandText = "insert into banka (islemturu, hesapno, miktar, para, degisim, yenipara, tarih) values (@islemturu, @hesapno, @cekilenmiktar, @bankapara, @bankaazalanpara, @bankayenipara, @tarih)";
                    komut_bankaveri.CommandType = CommandType.Text;
                    NpgsqlDataReader dr4 = komut_bankaveri.ExecuteReader();
                    conn.Close();
                    komut_bankaveri.Dispose();



                    MessageBox.Show("Para Başarıyla Çekildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Bakiye Yetersiz Mevcut Bakiyeniz:" + bakiye + "TL\n Çekmek İstediğiniz Tutar:"+cekilenmiktar+"TL\n Yeni Bakiyeniz: "+yenibakiye+"TL Olamaz!","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);


            }
            else
                MessageBox.Show("Maalesef Limt Yetmedi Limit:" + gunlukLimit);


        }







        private void Frm_ParaCek_Load(object sender, EventArgs e)
        {
            
        }





    }
    }

