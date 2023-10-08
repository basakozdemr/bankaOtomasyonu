using Npgsql;
using System.Data;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace nesneProje
{
     public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=nesne;User Id=postgres;Password=1234");

        string bakiye;

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
       

        private void Btn_Musteri_Click(object sender, EventArgs e)
        {
            Frm_Musteri frm_musteri = new Frm_Musteri();
            frm_musteri.lbl_atanacakHesapno.Text = txt_id.Text;
            this.Hide();
            frm_musteri.ShowDialog();
            this.Show();
             

        }

        private void btn_Banka_Click(object sender, EventArgs e)
        {
            Frm_Banka frm_Banka =new Frm_Banka();
            this.Hide();
            frm_Banka.ShowDialog();
            this.Show();

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}