using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesneProje
{
      public partial class Frm_Musteri : Form
    {
        public Frm_Musteri()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=nesne;User Id=postgres;Password=1234");


        public void FormGetir(Form form)
        {
            pnl_Musteri.Controls.Clear();
            form.MdiParent=this;
            form.FormBorderStyle = FormBorderStyle.None;
            pnl_Musteri.Controls.Add(form);
            form.Show();
        }

        private void Btn_ParaCek_Click(object sender, EventArgs e)
        {

                Frm_ParaCek frm_ParaCek = new Frm_ParaCek();
                FormGetir(frm_ParaCek);
            
                
            
            
        }

        private void btn_ParaYatır_Click(object sender, EventArgs e)
        {
           
            Frm_ParaYatir frm_ParaYatir = new Frm_ParaYatir();
            FormGetir(frm_ParaYatir);
           
        }

        private void btn_HesabaHavale_Click(object sender, EventArgs e)
        {
            Frm_Havale frm_Havale = new Frm_Havale();
            FormGetir(frm_Havale);
        }

        private void btn_HesapAc_Click(object sender, EventArgs e)
        {
            Frm_HesapAc frm_HesapAc =new Frm_HesapAc();
            FormGetir(frm_HesapAc);
        }

        private void btn_HesapKapat_Click(object sender, EventArgs e)
        {
            Frm_HesapKapat frm_HesapKapat =new Frm_HesapKapat();
            FormGetir(frm_HesapKapat);
        }

        private void btn_HesapOzeti_Click(object sender, EventArgs e)
        {
            Frm_HesapOzeti frm_HesapOzeti =new Frm_HesapOzeti();
            FormGetir(frm_HesapOzeti);
        }

        public void verileri_goster(string txt)
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
                dataGridView1.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        } 
             int atanacakdeger ;

        public void Frm_Musteri_Load(object sender, EventArgs e)
        {
            atanacakdeger = Convert.ToInt32(lbl_atanacakHesapno.Text);

           
            verileri_goster("select * from musteri where musteriid='"+atanacakdeger+"'");
            
            
            
            
        }
    }
}
