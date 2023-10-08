namespace nesneProje
{
    partial class Frm_HesapAc
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
            this.btn_HesapAc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MusteriID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_HesapAc
            // 
            this.btn_HesapAc.BackColor = System.Drawing.Color.Yellow;
            this.btn_HesapAc.Location = new System.Drawing.Point(295, 226);
            this.btn_HesapAc.Name = "btn_HesapAc";
            this.btn_HesapAc.Size = new System.Drawing.Size(140, 35);
            this.btn_HesapAc.TabIndex = 8;
            this.btn_HesapAc.Text = "Hesap Aç";
            this.btn_HesapAc.UseVisualStyleBackColor = false;
            this.btn_HesapAc.Click += new System.EventHandler(this.btn_HesapAc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(244, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Müşteri ID";
            // 
            // txt_MusteriID
            // 
            this.txt_MusteriID.Location = new System.Drawing.Point(336, 171);
            this.txt_MusteriID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MusteriID.Mask = "00000";
            this.txt_MusteriID.Name = "txt_MusteriID";
            this.txt_MusteriID.Size = new System.Drawing.Size(110, 23);
            this.txt_MusteriID.TabIndex = 10;
            this.txt_MusteriID.ValidatingType = typeof(int);
            // 
            // Frm_HesapAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1007, 555);
            this.Controls.Add(this.txt_MusteriID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_HesapAc);
            this.Name = "Frm_HesapAc";
            this.Text = "Frm_HesapAc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_HesapAc;
        private Label label3;
        private MaskedTextBox txt_MusteriID;
    }
}