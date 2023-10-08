namespace nesneProje
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Banka = new System.Windows.Forms.Button();
            this.Btn_Musteri = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Banka
            // 
            this.btn_Banka.BackColor = System.Drawing.Color.Red;
            this.btn_Banka.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Banka.Location = new System.Drawing.Point(592, 318);
            this.btn_Banka.Name = "btn_Banka";
            this.btn_Banka.Size = new System.Drawing.Size(120, 77);
            this.btn_Banka.TabIndex = 12;
            this.btn_Banka.Text = "BANKA GİRİŞ";
            this.btn_Banka.UseVisualStyleBackColor = false;
            this.btn_Banka.Click += new System.EventHandler(this.btn_Banka_Click);
            // 
            // Btn_Musteri
            // 
            this.Btn_Musteri.BackColor = System.Drawing.Color.Red;
            this.Btn_Musteri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Musteri.Location = new System.Drawing.Point(123, 188);
            this.Btn_Musteri.Name = "Btn_Musteri";
            this.Btn_Musteri.Size = new System.Drawing.Size(120, 45);
            this.Btn_Musteri.TabIndex = 11;
            this.Btn_Musteri.Text = "GİRİŞ";
            this.Btn_Musteri.UseVisualStyleBackColor = false;
            this.Btn_Musteri.Click += new System.EventHandler(this.Btn_Musteri_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(123, 97);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(174, 23);
            this.txt_id.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Musteri);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(184, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 269);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Giriş";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Banka);
            this.Name = "Frm_Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_Banka;
        private Button Btn_Musteri;
        private Label label2;
        private GroupBox groupBox1;
        public TextBox txt_id;
    }
}