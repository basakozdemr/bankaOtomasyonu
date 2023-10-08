namespace nesneProje
{
    partial class Frm_HesapKapat
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
            this.btn_HesapKapat = new System.Windows.Forms.Button();
            this.txt_HesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_HesapKapat
            // 
            this.btn_HesapKapat.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_HesapKapat.Location = new System.Drawing.Point(354, 226);
            this.btn_HesapKapat.Name = "btn_HesapKapat";
            this.btn_HesapKapat.Size = new System.Drawing.Size(95, 35);
            this.btn_HesapKapat.TabIndex = 10;
            this.btn_HesapKapat.Text = "Hesap Kapat";
            this.btn_HesapKapat.UseVisualStyleBackColor = false;
            this.btn_HesapKapat.Click += new System.EventHandler(this.btn_HesapKapat_Click);
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.Location = new System.Drawing.Point(372, 147);
            this.txt_HesapNo.Mask = "00000";
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.Size = new System.Drawing.Size(135, 23);
            this.txt_HesapNo.TabIndex = 12;
            this.txt_HesapNo.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hesap No";
            // 
            // Frm_HesapKapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1013, 550);
            this.Controls.Add(this.txt_HesapNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_HesapKapat);
            this.Name = "Frm_HesapKapat";
            this.Text = "Frm_HesapKapat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_HesapKapat;
        private MaskedTextBox txt_HesapNo;
        private Label label1;
    }
}