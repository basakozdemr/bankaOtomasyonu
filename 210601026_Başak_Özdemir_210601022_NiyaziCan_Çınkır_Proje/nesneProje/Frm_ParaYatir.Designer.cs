namespace nesneProje
{
    partial class Frm_ParaYatir
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
            this.btn_ParaYatir = new System.Windows.Forms.Button();
            this.txt_YatirilacakMiktar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ParaYatir
            // 
            this.btn_ParaYatir.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ParaYatir.Location = new System.Drawing.Point(340, 215);
            this.btn_ParaYatir.Name = "btn_ParaYatir";
            this.btn_ParaYatir.Size = new System.Drawing.Size(120, 25);
            this.btn_ParaYatir.TabIndex = 9;
            this.btn_ParaYatir.Text = "PARA YATIR";
            this.btn_ParaYatir.UseVisualStyleBackColor = false;
            this.btn_ParaYatir.Click += new System.EventHandler(this.btn_ParaYatir_Click);
            // 
            // txt_YatirilacakMiktar
            // 
            this.txt_YatirilacakMiktar.Location = new System.Drawing.Point(325, 161);
            this.txt_YatirilacakMiktar.Mask = "00000";
            this.txt_YatirilacakMiktar.Name = "txt_YatirilacakMiktar";
            this.txt_YatirilacakMiktar.Size = new System.Drawing.Size(135, 23);
            this.txt_YatirilacakMiktar.TabIndex = 8;
            this.txt_YatirilacakMiktar.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yatırılacak Miktar";
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.Location = new System.Drawing.Point(327, 107);
            this.txt_HesapNo.Mask = "00000";
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.Size = new System.Drawing.Size(135, 23);
            this.txt_HesapNo.TabIndex = 6;
            this.txt_HesapNo.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hesap No";
            // 
            // Frm_ParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(941, 530);
            this.Controls.Add(this.btn_ParaYatir);
            this.Controls.Add(this.txt_YatirilacakMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_HesapNo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ParaYatir";
            this.Text = "Frm_ParaYatir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ParaYatir;
        private MaskedTextBox txt_YatirilacakMiktar;
        private Label label2;
        private MaskedTextBox txt_HesapNo;
        private Label label1;
    }
}