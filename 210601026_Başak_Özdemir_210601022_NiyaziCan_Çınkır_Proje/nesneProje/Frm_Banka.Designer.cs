namespace nesneProje
{
    partial class Frm_Banka
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
            this.pnl_Musteri_Menu = new System.Windows.Forms.Panel();
            this.Btn_Musteri_Ekle = new System.Windows.Forms.Button();
            this.Btn_Rapor = new System.Windows.Forms.Button();
            this.pnl_Banka = new System.Windows.Forms.Panel();
            this.pnl_Musteri_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Musteri_Menu
            // 
            this.pnl_Musteri_Menu.BackColor = System.Drawing.Color.White;
            this.pnl_Musteri_Menu.Controls.Add(this.Btn_Musteri_Ekle);
            this.pnl_Musteri_Menu.Controls.Add(this.Btn_Rapor);
            this.pnl_Musteri_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Musteri_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Musteri_Menu.Name = "pnl_Musteri_Menu";
            this.pnl_Musteri_Menu.Size = new System.Drawing.Size(746, 53);
            this.pnl_Musteri_Menu.TabIndex = 7;
            // 
            // Btn_Musteri_Ekle
            // 
            this.Btn_Musteri_Ekle.BackColor = System.Drawing.Color.SpringGreen;
            this.Btn_Musteri_Ekle.Location = new System.Drawing.Point(12, 3);
            this.Btn_Musteri_Ekle.Name = "Btn_Musteri_Ekle";
            this.Btn_Musteri_Ekle.Size = new System.Drawing.Size(153, 35);
            this.Btn_Musteri_Ekle.TabIndex = 3;
            this.Btn_Musteri_Ekle.Text = "Müşteri Ekle";
            this.Btn_Musteri_Ekle.UseVisualStyleBackColor = false;
            this.Btn_Musteri_Ekle.Click += new System.EventHandler(this.Btn_Musteri_Ekle_Click);
            // 
            // Btn_Rapor
            // 
            this.Btn_Rapor.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Rapor.Location = new System.Drawing.Point(171, 3);
            this.Btn_Rapor.Name = "Btn_Rapor";
            this.Btn_Rapor.Size = new System.Drawing.Size(153, 35);
            this.Btn_Rapor.TabIndex = 4;
            this.Btn_Rapor.Text = "Banka Gelir-Gider Raporu";
            this.Btn_Rapor.UseVisualStyleBackColor = false;
            this.Btn_Rapor.Click += new System.EventHandler(this.Btn_Rapor_Click);
            // 
            // pnl_Banka
            // 
            this.pnl_Banka.BackColor = System.Drawing.Color.Beige;
            this.pnl_Banka.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Banka.Location = new System.Drawing.Point(0, 44);
            this.pnl_Banka.Name = "pnl_Banka";
            this.pnl_Banka.Size = new System.Drawing.Size(746, 406);
            this.pnl_Banka.TabIndex = 8;
            // 
            // Frm_Banka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.pnl_Banka);
            this.Controls.Add(this.pnl_Musteri_Menu);
            this.IsMdiContainer = true;
            this.Name = "Frm_Banka";
            this.Text = "Frm_Banka";
            this.pnl_Musteri_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Musteri_Menu;
        private Button Btn_Musteri_Ekle;
        private Button Btn_Rapor;
        private Panel pnl_Banka;
    }
}