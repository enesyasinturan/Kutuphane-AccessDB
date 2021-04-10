
namespace Kutuphane
{
    partial class FormGirisPaneli
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
            this.components = new System.ComponentModel.Container();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.buttonMisafirGirisi = new System.Windows.Forms.Button();
            this.labelGirisDurumu = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.radioButtonYonetici = new System.Windows.Forms.RadioButton();
            this.radioButtonKullanici = new System.Windows.Forms.RadioButton();
            this.errorProviderKullaniciGirisi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKullaniciGirisi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(12, 24);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.labelKullaniciAdi.TabIndex = 0;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(12, 68);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(37, 13);
            this.labelParola.TabIndex = 1;
            this.labelParola.Text = "Parola";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(91, 21);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(126, 20);
            this.textBoxKullaniciAdi.TabIndex = 2;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(91, 61);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(126, 20);
            this.textBoxParola.TabIndex = 3;
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Location = new System.Drawing.Point(15, 135);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(126, 42);
            this.buttonGirisYap.TabIndex = 4;
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // buttonMisafirGirisi
            // 
            this.buttonMisafirGirisi.Location = new System.Drawing.Point(147, 136);
            this.buttonMisafirGirisi.Name = "buttonMisafirGirisi";
            this.buttonMisafirGirisi.Size = new System.Drawing.Size(126, 41);
            this.buttonMisafirGirisi.TabIndex = 5;
            this.buttonMisafirGirisi.Text = "Misafir Girişi";
            this.buttonMisafirGirisi.UseVisualStyleBackColor = true;
            this.buttonMisafirGirisi.Click += new System.EventHandler(this.buttonMisafirGirisi_Click);
            // 
            // labelGirisDurumu
            // 
            this.labelGirisDurumu.AutoSize = true;
            this.labelGirisDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelGirisDurumu.ForeColor = System.Drawing.Color.Red;
            this.labelGirisDurumu.Location = new System.Drawing.Point(60, 107);
            this.labelGirisDurumu.Name = "labelGirisDurumu";
            this.labelGirisDurumu.Size = new System.Drawing.Size(0, 13);
            this.labelGirisDurumu.TabIndex = 6;
            // 
            // buttonCikis
            // 
            this.buttonCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCikis.Location = new System.Drawing.Point(79, 183);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(126, 42);
            this.buttonCikis.TabIndex = 7;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // radioButtonYonetici
            // 
            this.radioButtonYonetici.AutoSize = true;
            this.radioButtonYonetici.Location = new System.Drawing.Point(91, 87);
            this.radioButtonYonetici.Name = "radioButtonYonetici";
            this.radioButtonYonetici.Size = new System.Drawing.Size(63, 17);
            this.radioButtonYonetici.TabIndex = 8;
            this.radioButtonYonetici.TabStop = true;
            this.radioButtonYonetici.Text = "Yönetici";
            this.radioButtonYonetici.UseVisualStyleBackColor = true;
            // 
            // radioButtonKullanici
            // 
            this.radioButtonKullanici.AutoSize = true;
            this.radioButtonKullanici.Location = new System.Drawing.Point(160, 87);
            this.radioButtonKullanici.Name = "radioButtonKullanici";
            this.radioButtonKullanici.Size = new System.Drawing.Size(64, 17);
            this.radioButtonKullanici.TabIndex = 9;
            this.radioButtonKullanici.TabStop = true;
            this.radioButtonKullanici.Text = "Kullanıcı";
            this.radioButtonKullanici.UseVisualStyleBackColor = true;
            // 
            // errorProviderKullaniciGirisi
            // 
            this.errorProviderKullaniciGirisi.ContainerControl = this;
            // 
            // FormGirisPaneli
            // 
            this.AcceptButton = this.buttonGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCikis;
            this.ClientSize = new System.Drawing.Size(289, 233);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonKullanici);
            this.Controls.Add(this.radioButtonYonetici);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.labelGirisDurumu);
            this.Controls.Add(this.buttonMisafirGirisi);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.Load += new System.EventHandler(this.GirisPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKullaniciGirisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.Button buttonMisafirGirisi;
        private System.Windows.Forms.Label labelGirisDurumu;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.RadioButton radioButtonYonetici;
        private System.Windows.Forms.RadioButton radioButtonKullanici;
        private System.Windows.Forms.ErrorProvider errorProviderKullaniciGirisi;
    }
}