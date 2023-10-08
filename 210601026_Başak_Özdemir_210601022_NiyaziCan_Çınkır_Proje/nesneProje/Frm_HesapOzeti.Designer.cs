namespace nesneProje
{
    partial class Frm_HesapOzeti
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
            this.txt_HesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_HesapOzeti = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.msk_txtbaslangic = new System.Windows.Forms.MaskedTextBox();
            this.msk_txtbitis = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Bakiye = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HesapOzeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bakiye)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.Location = new System.Drawing.Point(191, 85);
            this.txt_HesapNo.Mask = "00000";
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.Size = new System.Drawing.Size(113, 23);
            this.txt_HesapNo.TabIndex = 3;
            this.txt_HesapNo.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Başlangıç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bitiş";
            // 
            // dgv_HesapOzeti
            // 
            this.dgv_HesapOzeti.AllowUserToAddRows = false;
            this.dgv_HesapOzeti.AllowUserToDeleteRows = false;
            this.dgv_HesapOzeti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_HesapOzeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HesapOzeti.Location = new System.Drawing.Point(235, 152);
            this.dgv_HesapOzeti.Name = "dgv_HesapOzeti";
            this.dgv_HesapOzeti.ReadOnly = true;
            this.dgv_HesapOzeti.RowTemplate.Height = 25;
            this.dgv_HesapOzeti.Size = new System.Drawing.Size(456, 219);
            this.dgv_HesapOzeti.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(607, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msk_txtbaslangic
            // 
            this.msk_txtbaslangic.Location = new System.Drawing.Point(444, 70);
            this.msk_txtbaslangic.Mask = "00/00/0000";
            this.msk_txtbaslangic.Name = "msk_txtbaslangic";
            this.msk_txtbaslangic.Size = new System.Drawing.Size(119, 23);
            this.msk_txtbaslangic.TabIndex = 10;
            this.msk_txtbaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // msk_txtbitis
            // 
            this.msk_txtbitis.Location = new System.Drawing.Point(444, 102);
            this.msk_txtbitis.Mask = "00/00/0000";
            this.msk_txtbitis.Name = "msk_txtbitis";
            this.msk_txtbitis.Size = new System.Drawing.Size(119, 23);
            this.msk_txtbitis.TabIndex = 11;
            this.msk_txtbitis.ValidatingType = typeof(System.DateTime);
            // 
            // dgv_Bakiye
            // 
            this.dgv_Bakiye.AllowUserToAddRows = false;
            this.dgv_Bakiye.AllowUserToDeleteRows = false;
            this.dgv_Bakiye.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Bakiye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bakiye.ColumnHeadersVisible = false;
            this.dgv_Bakiye.Location = new System.Drawing.Point(573, 398);
            this.dgv_Bakiye.Name = "dgv_Bakiye";
            this.dgv_Bakiye.ReadOnly = true;
            this.dgv_Bakiye.RowHeadersVisible = false;
            this.dgv_Bakiye.RowTemplate.Height = 25;
            this.dgv_Bakiye.Size = new System.Drawing.Size(118, 29);
            this.dgv_Bakiye.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(573, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bakiye";
            // 
            // Frm_HesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1062, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Bakiye);
            this.Controls.Add(this.msk_txtbitis);
            this.Controls.Add(this.msk_txtbaslangic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_HesapOzeti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_HesapNo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_HesapOzeti";
            this.Text = "Frm_HesapOzeti";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HesapOzeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bakiye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txt_HesapNo;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgv_HesapOzeti;
        private Button button1;
        private MaskedTextBox msk_txtbaslangic;
        private MaskedTextBox msk_txtbitis;
        private DataGridView dgv_Bakiye;
        private Label label4;
    }
}