namespace nesneProje
{
    partial class Frm_Havale
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
            this.txt_AliciHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_HavaleMiktar = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_HavaleYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_AliciHesapNo
            // 
            this.txt_AliciHesapNo.Location = new System.Drawing.Point(358, 161);
            this.txt_AliciHesapNo.Mask = "00000";
            this.txt_AliciHesapNo.Name = "txt_AliciHesapNo";
            this.txt_AliciHesapNo.Size = new System.Drawing.Size(135, 23);
            this.txt_AliciHesapNo.TabIndex = 7;
            this.txt_AliciHesapNo.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Havale Yapılacak Hesap No";
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.Location = new System.Drawing.Point(360, 107);
            this.txt_HesapNo.Mask = "00000";
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.Size = new System.Drawing.Size(135, 23);
            this.txt_HesapNo.TabIndex = 5;
            this.txt_HesapNo.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hesap No";
            // 
            // txt_HavaleMiktar
            // 
            this.txt_HavaleMiktar.Location = new System.Drawing.Point(358, 213);
            this.txt_HavaleMiktar.Mask = "00000";
            this.txt_HavaleMiktar.Name = "txt_HavaleMiktar";
            this.txt_HavaleMiktar.Size = new System.Drawing.Size(135, 23);
            this.txt_HavaleMiktar.TabIndex = 10;
            this.txt_HavaleMiktar.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Havale Yapılacak Miktar";
            // 
            // btn_HavaleYap
            // 
            this.btn_HavaleYap.BackColor = System.Drawing.Color.Aqua;
            this.btn_HavaleYap.Location = new System.Drawing.Point(386, 274);
            this.btn_HavaleYap.Name = "btn_HavaleYap";
            this.btn_HavaleYap.Size = new System.Drawing.Size(107, 49);
            this.btn_HavaleYap.TabIndex = 11;
            this.btn_HavaleYap.Text = "HAVALE YAP";
            this.btn_HavaleYap.UseVisualStyleBackColor = false;
            this.btn_HavaleYap.Click += new System.EventHandler(this.btn_HavaleYap_Click);
            // 
            // Frm_Havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(984, 497);
            this.Controls.Add(this.btn_HavaleYap);
            this.Controls.Add(this.txt_HavaleMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AliciHesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_HesapNo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Havale";
            this.Text = "Frm_Havale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txt_AliciHesapNo;
        private Label label2;
        private MaskedTextBox txt_HesapNo;
        private Label label1;
        private MaskedTextBox txt_HavaleMiktar;
        private Label label3;
        private Button btn_HavaleYap;
    }
}