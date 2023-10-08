namespace nesneProje
{
    partial class Frm_Musteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_ParaCek = new System.Windows.Forms.Button();
            this.btn_ParaYatır = new System.Windows.Forms.Button();
            this.btn_HesabaHavale = new System.Windows.Forms.Button();
            this.pnl_Musteri_Menu = new System.Windows.Forms.Panel();
            this.btn_HesapKapat = new System.Windows.Forms.Button();
            this.btn_HesapOzeti = new System.Windows.Forms.Button();
            this.btn_HesapAc = new System.Windows.Forms.Button();
            this.pnl_Musteri = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_atanacakHesapno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Musteri_Menu.SuspendLayout();
            this.pnl_Musteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ParaCek
            // 
            this.Btn_ParaCek.BackColor = System.Drawing.Color.SpringGreen;
            this.Btn_ParaCek.Location = new System.Drawing.Point(21, 10);
            this.Btn_ParaCek.Name = "Btn_ParaCek";
            this.Btn_ParaCek.Size = new System.Drawing.Size(130, 35);
            this.Btn_ParaCek.TabIndex = 3;
            this.Btn_ParaCek.Text = "Para Çek";
            this.Btn_ParaCek.UseVisualStyleBackColor = false;
            this.Btn_ParaCek.Click += new System.EventHandler(this.Btn_ParaCek_Click);
            // 
            // btn_ParaYatır
            // 
            this.btn_ParaYatır.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ParaYatır.Location = new System.Drawing.Point(159, 10);
            this.btn_ParaYatır.Name = "btn_ParaYatır";
            this.btn_ParaYatır.Size = new System.Drawing.Size(130, 35);
            this.btn_ParaYatır.TabIndex = 4;
            this.btn_ParaYatır.Text = "Para Yatır";
            this.btn_ParaYatır.UseVisualStyleBackColor = false;
            this.btn_ParaYatır.Click += new System.EventHandler(this.btn_ParaYatır_Click);
            // 
            // btn_HesabaHavale
            // 
            this.btn_HesabaHavale.BackColor = System.Drawing.Color.Aqua;
            this.btn_HesabaHavale.Location = new System.Drawing.Point(299, 10);
            this.btn_HesabaHavale.Name = "btn_HesabaHavale";
            this.btn_HesabaHavale.Size = new System.Drawing.Size(130, 35);
            this.btn_HesabaHavale.TabIndex = 5;
            this.btn_HesabaHavale.Text = "Hesaba Havale";
            this.btn_HesabaHavale.UseVisualStyleBackColor = false;
            this.btn_HesabaHavale.Click += new System.EventHandler(this.btn_HesabaHavale_Click);
            // 
            // pnl_Musteri_Menu
            // 
            this.pnl_Musteri_Menu.BackColor = System.Drawing.Color.White;
            this.pnl_Musteri_Menu.Controls.Add(this.btn_HesapKapat);
            this.pnl_Musteri_Menu.Controls.Add(this.btn_HesapOzeti);
            this.pnl_Musteri_Menu.Controls.Add(this.btn_HesapAc);
            this.pnl_Musteri_Menu.Controls.Add(this.btn_HesabaHavale);
            this.pnl_Musteri_Menu.Controls.Add(this.Btn_ParaCek);
            this.pnl_Musteri_Menu.Controls.Add(this.btn_ParaYatır);
            this.pnl_Musteri_Menu.Location = new System.Drawing.Point(0, 2);
            this.pnl_Musteri_Menu.Name = "pnl_Musteri_Menu";
            this.pnl_Musteri_Menu.Size = new System.Drawing.Size(894, 66);
            this.pnl_Musteri_Menu.TabIndex = 6;
            // 
            // btn_HesapKapat
            // 
            this.btn_HesapKapat.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_HesapKapat.Location = new System.Drawing.Point(713, 10);
            this.btn_HesapKapat.Name = "btn_HesapKapat";
            this.btn_HesapKapat.Size = new System.Drawing.Size(130, 35);
            this.btn_HesapKapat.TabIndex = 9;
            this.btn_HesapKapat.Text = "Hesap Kapat";
            this.btn_HesapKapat.UseVisualStyleBackColor = false;
            this.btn_HesapKapat.Click += new System.EventHandler(this.btn_HesapKapat_Click);
            // 
            // btn_HesapOzeti
            // 
            this.btn_HesapOzeti.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_HesapOzeti.Location = new System.Drawing.Point(575, 10);
            this.btn_HesapOzeti.Name = "btn_HesapOzeti";
            this.btn_HesapOzeti.Size = new System.Drawing.Size(130, 35);
            this.btn_HesapOzeti.TabIndex = 8;
            this.btn_HesapOzeti.Text = "Hesap Özeti";
            this.btn_HesapOzeti.UseVisualStyleBackColor = false;
            this.btn_HesapOzeti.Click += new System.EventHandler(this.btn_HesapOzeti_Click);
            // 
            // btn_HesapAc
            // 
            this.btn_HesapAc.BackColor = System.Drawing.Color.Yellow;
            this.btn_HesapAc.Location = new System.Drawing.Point(437, 10);
            this.btn_HesapAc.Name = "btn_HesapAc";
            this.btn_HesapAc.Size = new System.Drawing.Size(130, 35);
            this.btn_HesapAc.TabIndex = 7;
            this.btn_HesapAc.Text = "Hesap Aç";
            this.btn_HesapAc.UseVisualStyleBackColor = false;
            this.btn_HesapAc.Click += new System.EventHandler(this.btn_HesapAc_Click);
            // 
            // pnl_Musteri
            // 
            this.pnl_Musteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl_Musteri.Controls.Add(this.dataGridView1);
            this.pnl_Musteri.Controls.Add(this.lbl_atanacakHesapno);
            this.pnl_Musteri.Controls.Add(this.label1);
            this.pnl_Musteri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Musteri.Location = new System.Drawing.Point(0, 63);
            this.pnl_Musteri.Name = "pnl_Musteri";
            this.pnl_Musteri.Size = new System.Drawing.Size(878, 457);
            this.pnl_Musteri.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(518, 172);
            this.dataGridView1.TabIndex = 2;
            // 
            // lbl_atanacakHesapno
            // 
            this.lbl_atanacakHesapno.AutoSize = true;
            this.lbl_atanacakHesapno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_atanacakHesapno.Location = new System.Drawing.Point(86, 17);
            this.lbl_atanacakHesapno.Name = "lbl_atanacakHesapno";
            this.lbl_atanacakHesapno.Size = new System.Drawing.Size(0, 21);
            this.lbl_atanacakHesapno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID\'niz:";
            // 
            // Frm_Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 520);
            this.Controls.Add(this.pnl_Musteri);
            this.Controls.Add(this.pnl_Musteri_Menu);
            this.IsMdiContainer = true;
            this.Name = "Frm_Musteri";
            this.Text = "Musteri";
            this.Load += new System.EventHandler(this.Frm_Musteri_Load);
            this.pnl_Musteri_Menu.ResumeLayout(false);
            this.pnl_Musteri.ResumeLayout(false);
            this.pnl_Musteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_ParaCek;
        private Button btn_ParaYatır;
        private Button btn_HesabaHavale;
        private Panel pnl_Musteri_Menu;
        private Panel pnl_Musteri;
        private Button btn_HesapAc;
        private Button btn_HesapKapat;
        private Button btn_HesapOzeti;
        private Label label1;
        private DataGridView dataGridView1;
        public Label lbl_atanacakHesapno;
    }
}