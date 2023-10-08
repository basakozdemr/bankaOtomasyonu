namespace nesneProje
{
    partial class Frm_BankaRapor
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
            this.msk_Bitis = new System.Windows.Forms.MaskedTextBox();
            this.msk_Baslangic = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_BankaRapor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BankaRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // msk_Bitis
            // 
            this.msk_Bitis.Location = new System.Drawing.Point(479, 95);
            this.msk_Bitis.Mask = "00/00/0000";
            this.msk_Bitis.Name = "msk_Bitis";
            this.msk_Bitis.Size = new System.Drawing.Size(119, 23);
            this.msk_Bitis.TabIndex = 19;
            this.msk_Bitis.ValidatingType = typeof(System.DateTime);
            // 
            // msk_Baslangic
            // 
            this.msk_Baslangic.Location = new System.Drawing.Point(479, 63);
            this.msk_Baslangic.Mask = "00/00/0000";
            this.msk_Baslangic.Name = "msk_Baslangic";
            this.msk_Baslangic.Size = new System.Drawing.Size(119, 23);
            this.msk_Baslangic.TabIndex = 18;
            this.msk_Baslangic.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(642, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_BankaRapor
            // 
            this.dgv_BankaRapor.AllowUserToAddRows = false;
            this.dgv_BankaRapor.AllowUserToDeleteRows = false;
            this.dgv_BankaRapor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_BankaRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BankaRapor.Location = new System.Drawing.Point(25, 140);
            this.dgv_BankaRapor.Name = "dgv_BankaRapor";
            this.dgv_BankaRapor.ReadOnly = true;
            this.dgv_BankaRapor.RowTemplate.Height = 25;
            this.dgv_BankaRapor.Size = new System.Drawing.Size(713, 198);
            this.dgv_BankaRapor.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bitiş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Başlangıç";
            // 
            // Frm_BankaRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(920, 515);
            this.Controls.Add(this.msk_Bitis);
            this.Controls.Add(this.msk_Baslangic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_BankaRapor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Frm_BankaRapor";
            this.Text = "Frm_BankaRapor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BankaRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox msk_Bitis;
        private MaskedTextBox msk_Baslangic;
        private Button button1;
        private DataGridView dgv_BankaRapor;
        private Label label3;
        private Label label2;
    }
}