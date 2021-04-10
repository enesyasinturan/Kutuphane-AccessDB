
namespace Kutuphane
{
    partial class FormKullaniciYonetimPaneli
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
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.labelKullaniciYonetimKullaniciAdi = new System.Windows.Forms.Label();
            this.labelKullaniciYonetimParola = new System.Windows.Forms.Label();
            this.labelKullaniciYonetimAd = new System.Windows.Forms.Label();
            this.labelKullaniciYonetimSoyad = new System.Windows.Forms.Label();
            this.labelKullaniciYonetimEmail = new System.Windows.Forms.Label();
            this.textBoxKullaniciYonetimKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciYonetimParola = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciYonetimAd = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciYonetimEmail = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciYonetimSoyad = new System.Windows.Forms.TextBox();
            this.buttonKullaniciYonetimEkle = new System.Windows.Forms.Button();
            this.buttonAnaSayfa = new System.Windows.Forms.Button();
            this.buttonKullaniciYonetimSil = new System.Windows.Forms.Button();
            this.buttonKullaniciTemizle = new System.Windows.Forms.Button();
            this.buttonKullaniciYonetimCikis = new System.Windows.Forms.Button();
            this.textBoxKullaniciYonetimKayitTarihi = new System.Windows.Forms.TextBox();
            this.labelKullaniciYonetimKayitTarihi = new System.Windows.Forms.Label();
            this.buttonKullaniciYonetimGuncelle = new System.Windows.Forms.Button();
            this.textBoxKullaniciYonetimGuncellemeTarihi = new System.Windows.Forms.TextBox();
            this.labelKullaniciYonetimGuncellemeTarihi = new System.Windows.Forms.Label();
            this.buttonKullaniciYonetimAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.AllowUserToAddRows = false;
            this.dataGridViewKullanicilar.AllowUserToDeleteRows = false;
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(0, 242);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.ReadOnly = true;
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(637, 150);
            this.dataGridViewKullanicilar.TabIndex = 0;
            this.dataGridViewKullanicilar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKullanicilar_CellDoubleClick);
            // 
            // labelKullaniciYonetimKullaniciAdi
            // 
            this.labelKullaniciYonetimKullaniciAdi.AutoSize = true;
            this.labelKullaniciYonetimKullaniciAdi.Location = new System.Drawing.Point(12, 21);
            this.labelKullaniciYonetimKullaniciAdi.Name = "labelKullaniciYonetimKullaniciAdi";
            this.labelKullaniciYonetimKullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.labelKullaniciYonetimKullaniciAdi.TabIndex = 1;
            this.labelKullaniciYonetimKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // labelKullaniciYonetimParola
            // 
            this.labelKullaniciYonetimParola.AutoSize = true;
            this.labelKullaniciYonetimParola.Location = new System.Drawing.Point(12, 53);
            this.labelKullaniciYonetimParola.Name = "labelKullaniciYonetimParola";
            this.labelKullaniciYonetimParola.Size = new System.Drawing.Size(37, 13);
            this.labelKullaniciYonetimParola.TabIndex = 2;
            this.labelKullaniciYonetimParola.Text = "Parola";
            // 
            // labelKullaniciYonetimAd
            // 
            this.labelKullaniciYonetimAd.AutoSize = true;
            this.labelKullaniciYonetimAd.Location = new System.Drawing.Point(12, 85);
            this.labelKullaniciYonetimAd.Name = "labelKullaniciYonetimAd";
            this.labelKullaniciYonetimAd.Size = new System.Drawing.Size(20, 13);
            this.labelKullaniciYonetimAd.TabIndex = 3;
            this.labelKullaniciYonetimAd.Text = "Ad";
            // 
            // labelKullaniciYonetimSoyad
            // 
            this.labelKullaniciYonetimSoyad.AutoSize = true;
            this.labelKullaniciYonetimSoyad.Location = new System.Drawing.Point(12, 117);
            this.labelKullaniciYonetimSoyad.Name = "labelKullaniciYonetimSoyad";
            this.labelKullaniciYonetimSoyad.Size = new System.Drawing.Size(37, 13);
            this.labelKullaniciYonetimSoyad.TabIndex = 4;
            this.labelKullaniciYonetimSoyad.Text = "Soyad";
            // 
            // labelKullaniciYonetimEmail
            // 
            this.labelKullaniciYonetimEmail.AutoSize = true;
            this.labelKullaniciYonetimEmail.Location = new System.Drawing.Point(12, 149);
            this.labelKullaniciYonetimEmail.Name = "labelKullaniciYonetimEmail";
            this.labelKullaniciYonetimEmail.Size = new System.Drawing.Size(36, 13);
            this.labelKullaniciYonetimEmail.TabIndex = 5;
            this.labelKullaniciYonetimEmail.Text = "E-Mail";
            // 
            // textBoxKullaniciYonetimKullaniciAdi
            // 
            this.textBoxKullaniciYonetimKullaniciAdi.Location = new System.Drawing.Point(107, 18);
            this.textBoxKullaniciYonetimKullaniciAdi.Name = "textBoxKullaniciYonetimKullaniciAdi";
            this.textBoxKullaniciYonetimKullaniciAdi.Size = new System.Drawing.Size(150, 20);
            this.textBoxKullaniciYonetimKullaniciAdi.TabIndex = 6;
            // 
            // textBoxKullaniciYonetimParola
            // 
            this.textBoxKullaniciYonetimParola.Location = new System.Drawing.Point(107, 50);
            this.textBoxKullaniciYonetimParola.Name = "textBoxKullaniciYonetimParola";
            this.textBoxKullaniciYonetimParola.Size = new System.Drawing.Size(150, 20);
            this.textBoxKullaniciYonetimParola.TabIndex = 7;
            // 
            // textBoxKullaniciYonetimAd
            // 
            this.textBoxKullaniciYonetimAd.Location = new System.Drawing.Point(107, 82);
            this.textBoxKullaniciYonetimAd.Name = "textBoxKullaniciYonetimAd";
            this.textBoxKullaniciYonetimAd.Size = new System.Drawing.Size(150, 20);
            this.textBoxKullaniciYonetimAd.TabIndex = 8;
            // 
            // textBoxKullaniciYonetimEmail
            // 
            this.textBoxKullaniciYonetimEmail.Location = new System.Drawing.Point(107, 146);
            this.textBoxKullaniciYonetimEmail.Name = "textBoxKullaniciYonetimEmail";
            this.textBoxKullaniciYonetimEmail.Size = new System.Drawing.Size(150, 20);
            this.textBoxKullaniciYonetimEmail.TabIndex = 10;
            // 
            // textBoxKullaniciYonetimSoyad
            // 
            this.textBoxKullaniciYonetimSoyad.Location = new System.Drawing.Point(107, 114);
            this.textBoxKullaniciYonetimSoyad.Name = "textBoxKullaniciYonetimSoyad";
            this.textBoxKullaniciYonetimSoyad.Size = new System.Drawing.Size(150, 20);
            this.textBoxKullaniciYonetimSoyad.TabIndex = 9;
            // 
            // buttonKullaniciYonetimEkle
            // 
            this.buttonKullaniciYonetimEkle.Location = new System.Drawing.Point(290, 18);
            this.buttonKullaniciYonetimEkle.Name = "buttonKullaniciYonetimEkle";
            this.buttonKullaniciYonetimEkle.Size = new System.Drawing.Size(160, 45);
            this.buttonKullaniciYonetimEkle.TabIndex = 11;
            this.buttonKullaniciYonetimEkle.Text = "Kullanıcı Kaydet";
            this.buttonKullaniciYonetimEkle.UseVisualStyleBackColor = true;
            this.buttonKullaniciYonetimEkle.Click += new System.EventHandler(this.buttonKullaniciYonetimEkle_Click);
            // 
            // buttonAnaSayfa
            // 
            this.buttonAnaSayfa.Location = new System.Drawing.Point(290, 181);
            this.buttonAnaSayfa.Name = "buttonAnaSayfa";
            this.buttonAnaSayfa.Size = new System.Drawing.Size(160, 45);
            this.buttonAnaSayfa.TabIndex = 12;
            this.buttonAnaSayfa.Text = "Ana Sayfaya Git";
            this.buttonAnaSayfa.UseVisualStyleBackColor = true;
            this.buttonAnaSayfa.Click += new System.EventHandler(this.buttonAnaSayfa_Click);
            // 
            // buttonKullaniciYonetimSil
            // 
            this.buttonKullaniciYonetimSil.Location = new System.Drawing.Point(290, 73);
            this.buttonKullaniciYonetimSil.Name = "buttonKullaniciYonetimSil";
            this.buttonKullaniciYonetimSil.Size = new System.Drawing.Size(77, 48);
            this.buttonKullaniciYonetimSil.TabIndex = 13;
            this.buttonKullaniciYonetimSil.Text = "Sil";
            this.buttonKullaniciYonetimSil.UseVisualStyleBackColor = true;
            this.buttonKullaniciYonetimSil.Click += new System.EventHandler(this.buttonKullaniciYonetimSil_Click);
            // 
            // buttonKullaniciTemizle
            // 
            this.buttonKullaniciTemizle.Location = new System.Drawing.Point(290, 126);
            this.buttonKullaniciTemizle.Name = "buttonKullaniciTemizle";
            this.buttonKullaniciTemizle.Size = new System.Drawing.Size(77, 48);
            this.buttonKullaniciTemizle.TabIndex = 14;
            this.buttonKullaniciTemizle.Text = "Temizle";
            this.buttonKullaniciTemizle.UseVisualStyleBackColor = true;
            this.buttonKullaniciTemizle.Click += new System.EventHandler(this.buttonKullaniciTemizle_Click);
            // 
            // buttonKullaniciYonetimCikis
            // 
            this.buttonKullaniciYonetimCikis.Location = new System.Drawing.Point(466, 181);
            this.buttonKullaniciYonetimCikis.Name = "buttonKullaniciYonetimCikis";
            this.buttonKullaniciYonetimCikis.Size = new System.Drawing.Size(160, 45);
            this.buttonKullaniciYonetimCikis.TabIndex = 15;
            this.buttonKullaniciYonetimCikis.Text = "Çıkış";
            this.buttonKullaniciYonetimCikis.UseVisualStyleBackColor = true;
            this.buttonKullaniciYonetimCikis.Click += new System.EventHandler(this.buttonKullaniciYonetimCikis_Click);
            // 
            // textBoxKullaniciYonetimKayitTarihi
            // 
            this.textBoxKullaniciYonetimKayitTarihi.Location = new System.Drawing.Point(107, 181);
            this.textBoxKullaniciYonetimKayitTarihi.Name = "textBoxKullaniciYonetimKayitTarihi";
            this.textBoxKullaniciYonetimKayitTarihi.Size = new System.Drawing.Size(150, 20);
            this.textBoxKullaniciYonetimKayitTarihi.TabIndex = 18;
            // 
            // labelKullaniciYonetimKayitTarihi
            // 
            this.labelKullaniciYonetimKayitTarihi.AutoSize = true;
            this.labelKullaniciYonetimKayitTarihi.Location = new System.Drawing.Point(12, 184);
            this.labelKullaniciYonetimKayitTarihi.Name = "labelKullaniciYonetimKayitTarihi";
            this.labelKullaniciYonetimKayitTarihi.Size = new System.Drawing.Size(59, 13);
            this.labelKullaniciYonetimKayitTarihi.TabIndex = 17;
            this.labelKullaniciYonetimKayitTarihi.Text = "Kayıt Tarihi";
            // 
            // buttonKullaniciYonetimGuncelle
            // 
            this.buttonKullaniciYonetimGuncelle.Location = new System.Drawing.Point(373, 73);
            this.buttonKullaniciYonetimGuncelle.Name = "buttonKullaniciYonetimGuncelle";
            this.buttonKullaniciYonetimGuncelle.Size = new System.Drawing.Size(77, 48);
            this.buttonKullaniciYonetimGuncelle.TabIndex = 19;
            this.buttonKullaniciYonetimGuncelle.Text = "Güncelle";
            this.buttonKullaniciYonetimGuncelle.UseVisualStyleBackColor = true;
            this.buttonKullaniciYonetimGuncelle.Click += new System.EventHandler(this.buttonKullaniciYonetimGuncelle_Click);
            // 
            // textBoxKullaniciYonetimGuncellemeTarihi
            // 
            this.textBoxKullaniciYonetimGuncellemeTarihi.Location = new System.Drawing.Point(107, 216);
            this.textBoxKullaniciYonetimGuncellemeTarihi.Name = "textBoxKullaniciYonetimGuncellemeTarihi";
            this.textBoxKullaniciYonetimGuncellemeTarihi.Size = new System.Drawing.Size(150, 20);
            this.textBoxKullaniciYonetimGuncellemeTarihi.TabIndex = 21;
            // 
            // labelKullaniciYonetimGuncellemeTarihi
            // 
            this.labelKullaniciYonetimGuncellemeTarihi.AutoSize = true;
            this.labelKullaniciYonetimGuncellemeTarihi.Location = new System.Drawing.Point(12, 219);
            this.labelKullaniciYonetimGuncellemeTarihi.Name = "labelKullaniciYonetimGuncellemeTarihi";
            this.labelKullaniciYonetimGuncellemeTarihi.Size = new System.Drawing.Size(92, 13);
            this.labelKullaniciYonetimGuncellemeTarihi.TabIndex = 20;
            this.labelKullaniciYonetimGuncellemeTarihi.Text = "Güncelleme Tarihi";
            // 
            // buttonKullaniciYonetimAra
            // 
            this.buttonKullaniciYonetimAra.Location = new System.Drawing.Point(373, 126);
            this.buttonKullaniciYonetimAra.Name = "buttonKullaniciYonetimAra";
            this.buttonKullaniciYonetimAra.Size = new System.Drawing.Size(75, 47);
            this.buttonKullaniciYonetimAra.TabIndex = 22;
            this.buttonKullaniciYonetimAra.Text = "Ara";
            this.buttonKullaniciYonetimAra.UseVisualStyleBackColor = true;
            this.buttonKullaniciYonetimAra.Click += new System.EventHandler(this.buttonKullaniciYonetimAra_Click);
            // 
            // FormKullaniciYonetimPaneli
            // 
            this.AcceptButton = this.buttonKullaniciYonetimEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonKullaniciYonetimCikis;
            this.ClientSize = new System.Drawing.Size(637, 392);
            this.ControlBox = false;
            this.Controls.Add(this.buttonKullaniciYonetimAra);
            this.Controls.Add(this.textBoxKullaniciYonetimGuncellemeTarihi);
            this.Controls.Add(this.labelKullaniciYonetimGuncellemeTarihi);
            this.Controls.Add(this.buttonKullaniciYonetimGuncelle);
            this.Controls.Add(this.textBoxKullaniciYonetimKayitTarihi);
            this.Controls.Add(this.labelKullaniciYonetimKayitTarihi);
            this.Controls.Add(this.buttonKullaniciYonetimCikis);
            this.Controls.Add(this.buttonKullaniciTemizle);
            this.Controls.Add(this.buttonKullaniciYonetimSil);
            this.Controls.Add(this.buttonAnaSayfa);
            this.Controls.Add(this.buttonKullaniciYonetimEkle);
            this.Controls.Add(this.textBoxKullaniciYonetimEmail);
            this.Controls.Add(this.textBoxKullaniciYonetimSoyad);
            this.Controls.Add(this.textBoxKullaniciYonetimAd);
            this.Controls.Add(this.textBoxKullaniciYonetimParola);
            this.Controls.Add(this.textBoxKullaniciYonetimKullaniciAdi);
            this.Controls.Add(this.labelKullaniciYonetimEmail);
            this.Controls.Add(this.labelKullaniciYonetimSoyad);
            this.Controls.Add(this.labelKullaniciYonetimAd);
            this.Controls.Add(this.labelKullaniciYonetimParola);
            this.Controls.Add(this.labelKullaniciYonetimKullaniciAdi);
            this.Controls.Add(this.dataGridViewKullanicilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormKullaniciYonetimPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Yönetim Paneli";
            this.Load += new System.EventHandler(this.FormKullaniciYonetimPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
        private System.Windows.Forms.Label labelKullaniciYonetimKullaniciAdi;
        private System.Windows.Forms.Label labelKullaniciYonetimParola;
        private System.Windows.Forms.Label labelKullaniciYonetimAd;
        private System.Windows.Forms.Label labelKullaniciYonetimSoyad;
        private System.Windows.Forms.Label labelKullaniciYonetimEmail;
        private System.Windows.Forms.TextBox textBoxKullaniciYonetimKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxKullaniciYonetimParola;
        private System.Windows.Forms.TextBox textBoxKullaniciYonetimAd;
        private System.Windows.Forms.TextBox textBoxKullaniciYonetimEmail;
        private System.Windows.Forms.TextBox textBoxKullaniciYonetimSoyad;
        private System.Windows.Forms.Button buttonKullaniciYonetimEkle;
        private System.Windows.Forms.Button buttonAnaSayfa;
        private System.Windows.Forms.Button buttonKullaniciYonetimSil;
        private System.Windows.Forms.Button buttonKullaniciTemizle;
        private System.Windows.Forms.Button buttonKullaniciYonetimCikis;
        private System.Windows.Forms.TextBox textBoxKullaniciYonetimKayitTarihi;
        private System.Windows.Forms.Label labelKullaniciYonetimKayitTarihi;
        private System.Windows.Forms.Button buttonKullaniciYonetimGuncelle;
        private System.Windows.Forms.TextBox textBoxKullaniciYonetimGuncellemeTarihi;
        private System.Windows.Forms.Label labelKullaniciYonetimGuncellemeTarihi;
        private System.Windows.Forms.Button buttonKullaniciYonetimAra;
    }
}