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
     public partial class Frm_Banka : Form
    {
        public Frm_Banka()
        {
            InitializeComponent();
        }
        private void FormGetir(Form form)
        {
            pnl_Banka.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            pnl_Banka.Controls.Add(form);
            form.Show();
        }

        private void Btn_Musteri_Ekle_Click(object sender, EventArgs e)
        {
            Frm_MusteriEkle frm_MusteriEkle = new Frm_MusteriEkle();
            FormGetir(frm_MusteriEkle);
        }

        private void Btn_Rapor_Click(object sender, EventArgs e)
        {
            Frm_BankaRapor frm_BankaRapor = new Frm_BankaRapor();
            FormGetir(frm_BankaRapor);
        }
    }
}
