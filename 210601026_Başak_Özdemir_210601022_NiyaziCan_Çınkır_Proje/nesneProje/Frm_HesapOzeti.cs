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
    public partial class Frm_HesapOzeti : Form
    {
        public Frm_HesapOzeti()
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



        private void button1_Click(object sender, EventArgs e)
        {
            verileri_goster("select islemturu, hesapno, miktar, tarih from banka where hesapno= '" + Convert.ToInt32(txt_HesapNo.Text) + "' and  tarih between '" + msk_txtbaslangic.Text + "' and'" + msk_txtbitis.Text + "'", dgv_HesapOzeti);
            verileri_goster("select bakiye from musteri where hesapno= '" + Convert.ToInt32(txt_HesapNo.Text) + "'", dgv_Bakiye);

        }
    }
}
