namespace nesneProje
{
    partial class Frm_MusteriEkle
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
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_BireyselMusteri = new System.Windows.Forms.RadioButton();
            this.rb_TicariMusteri = new System.Windows.Forms.RadioButton();
            this.Btn_MusteriEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblatamaYapılacak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(237, 132);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(209, 23);
            this.txt_AdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(147, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Tipi";
            // 
            // rb_BireyselMusteri
            // 
            this.rb_BireyselMusteri.AutoSize = true;
            this.rb_BireyselMusteri.Location = new System.Drawing.Point(237, 197);
            this.rb_BireyselMusteri.Name = "rb_BireyselMusteri";
            this.rb_BireyselMusteri.Size = new System.Drawing.Size(108, 19);
            this.rb_BireyselMusteri.TabIndex = 3;
            this.rb_BireyselMusteri.TabStop = true;
            this.rb_BireyselMusteri.Text = "Bireysel Müşteri";
            this.rb_BireyselMusteri.UseVisualStyleBackColor = true;
            // 
            // rb_TicariMusteri
            // 
            this.rb_TicariMusteri.AutoSize = true;
            this.rb_TicariMusteri.Location = new System.Drawing.Point(350, 197);
            this.rb_TicariMusteri.Name = "rb_TicariMusteri";
            this.rb_TicariMusteri.Size = new System.Drawing.Size(96, 19);
            this.rb_TicariMusteri.TabIndex = 4;
            this.rb_TicariMusteri.TabStop = true;
            this.rb_TicariMusteri.Text = "Ticari Müşteri";
            this.rb_TicariMusteri.UseVisualStyleBackColor = true;
            // 
            // Btn_MusteriEkle
            // 
            this.Btn_MusteriEkle.BackColor = System.Drawing.Color.SpringGreen;
            this.Btn_MusteriEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_MusteriEkle.Location = new System.Drawing.Point(306, 257);
            this.Btn_MusteriEkle.Name = "Btn_MusteriEkle";
            this.Btn_MusteriEkle.Size = new System.Drawing.Size(140, 40);
            this.Btn_MusteriEkle.TabIndex = 5;
            this.Btn_MusteriEkle.Text = "Müşteri Ekle";
            this.Btn_MusteriEkle.UseVisualStyleBackColor = false;
            this.Btn_MusteriEkle.Click += new System.EventHandler(this.Btn_MusteriEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID\'niz:";
            this.label3.Visible = false;
            // 
            // lblatamaYapılacak
            // 
            this.lblatamaYapılacak.AutoSize = true;
            this.lblatamaYapılacak.Location = new System.Drawing.Point(559, 140);
            this.lblatamaYapılacak.Name = "lblatamaYapılacak";
            this.lblatamaYapılacak.Size = new System.Drawing.Size(0, 15);
            this.lblatamaYapılacak.TabIndex = 7;
            // 
            // Frm_MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblatamaYapılacak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_MusteriEkle);
            this.Controls.Add(this.rb_TicariMusteri);
            this.Controls.Add(this.rb_BireyselMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Frm_MusteriEkle";
            this.Text = "Frm_MusteriEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_AdSoyad;
        private Label label2;
        private RadioButton rb_BireyselMusteri;
        private RadioButton rb_TicariMusteri;
        private Button Btn_MusteriEkle;
        private Label label3;
        private Label lblatamaYapılacak;
    }
}