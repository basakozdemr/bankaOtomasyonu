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
    public partial class Frm_HesapKapat : Form
    {
        public Frm_HesapKapat()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=nesne;User Id=postgres;Password=1234");

        private void btn_HesapKapat_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_sil = new NpgsqlCommand();
            komut_sil.Connection = conn;
            komut_sil.Parameters.AddWithValue("@silinecekHesapNo", Convert.ToInt32(txt_HesapNo.Text));
            komut_sil.CommandText = "delete from musteri where hesapno = @silinecekHesapNo";
            komut_sil.CommandType = CommandType.Text;
            NpgsqlDataReader dr = komut_sil.ExecuteReader();
            conn.Close();
            komut_sil.Dispose();
        }
    }
}
