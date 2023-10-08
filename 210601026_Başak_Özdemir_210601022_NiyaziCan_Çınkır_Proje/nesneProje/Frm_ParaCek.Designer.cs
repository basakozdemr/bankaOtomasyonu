namespace nesneProje
{
    partial class Frm_ParaCek
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_HesapNo = new System.Windows.Forms.MaskedTextBox();
            this.txt_CekilecekMiktar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ParaCek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No";
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.Location = new System.Drawing.Point(341, 114);
            this.txt_HesapNo.Mask = "00000";
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.Size = new System.Drawing.Size(135, 23);
            this.txt_HesapNo.TabIndex = 1;
            this.txt_HesapNo.ValidatingType = typeof(int);
            // 
            // txt_CekilecekMiktar
            // 
            this.txt_CekilecekMiktar.Location = new System.Drawing.Point(339, 168);
            this.txt_CekilecekMiktar.Mask = "00000";
            this.txt_CekilecekMiktar.Name = "txt_CekilecekMiktar";
            this.txt_CekilecekMiktar.Size = new System.Drawing.Size(135, 23);
            this.txt_CekilecekMiktar.TabIndex = 3;
            this.txt_CekilecekMiktar.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çekilecek Miktar";
            // 
            // btn_ParaCek
            // 
            this.btn_ParaCek.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_ParaCek.Location = new System.Drawing.Point(354, 222);
            this.btn_ParaCek.Name = "btn_ParaCek";
            this.btn_ParaCek.Size = new System.Drawing.Size(120, 25);
            this.btn_ParaCek.TabIndex = 4;
            this.btn_ParaCek.Text = "PARA ÇEK";
            this.btn_ParaCek.UseVisualStyleBackColor = false;
            this.btn_ParaCek.Click += new System.EventHandler(this.btn_ParaCek_Click);
            // 
            // Frm_ParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(869, 533);
            this.Controls.Add(this.btn_ParaCek);
            this.Controls.Add(this.txt_CekilecekMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_HesapNo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ParaCek";
            this.Text = "Frm_ParaCek";
            this.Load += new System.EventHandler(this.Frm_ParaCek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox txt_HesapNo;
        private MaskedTextBox txt_CekilecekMiktar;
        private Label label2;
        private Button btn_ParaCek;
    }
}