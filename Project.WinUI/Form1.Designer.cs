
namespace Project.WinUI
{
    partial class Form1
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
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAktif = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnPasif = new System.Windows.Forms.Button();
            this.btnGuncellenen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 18;
            this.lstSonuc.Location = new System.Drawing.Point(179, 45);
            this.lstSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(302, 454);
            this.lstSonuc.TabIndex = 0;
            this.lstSonuc.Click += new System.EventHandler(this.lstSonuc_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(13, 305);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 35);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(13, 13);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(112, 35);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnAktif
            // 
            this.btnAktif.Location = new System.Drawing.Point(13, 88);
            this.btnAktif.Margin = new System.Windows.Forms.Padding(4);
            this.btnAktif.Name = "btnAktif";
            this.btnAktif.Size = new System.Drawing.Size(112, 35);
            this.btnAktif.TabIndex = 1;
            this.btnAktif.Text = "Aktif";
            this.btnAktif.UseVisualStyleBackColor = true;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(12, 212);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 24);
            this.txtIsim.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(13, 261);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 24);
            this.txtDescription.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(13, 373);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(13, 424);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnPasif
            // 
            this.btnPasif.Location = new System.Drawing.Point(13, 130);
            this.btnPasif.Name = "btnPasif";
            this.btnPasif.Size = new System.Drawing.Size(112, 28);
            this.btnPasif.TabIndex = 5;
            this.btnPasif.Text = "Pasif";
            this.btnPasif.UseVisualStyleBackColor = true;
            this.btnPasif.Click += new System.EventHandler(this.btnPasif_Click);
            // 
            // btnGuncellenen
            // 
            this.btnGuncellenen.Location = new System.Drawing.Point(13, 164);
            this.btnGuncellenen.Name = "btnGuncellenen";
            this.btnGuncellenen.Size = new System.Drawing.Size(112, 28);
            this.btnGuncellenen.TabIndex = 5;
            this.btnGuncellenen.Text = "Guncellenen";
            this.btnGuncellenen.UseVisualStyleBackColor = true;
            this.btnGuncellenen.Click += new System.EventHandler(this.btnGuncellenen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 643);
            this.Controls.Add(this.btnGuncellenen);
            this.Controls.Add(this.btnPasif);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnAktif);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSonuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAktif;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPasif;
        private System.Windows.Forms.Button btnGuncellenen;
    }
}

