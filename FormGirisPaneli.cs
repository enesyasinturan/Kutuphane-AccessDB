using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kutuphane
{
    public partial class FormGirisPaneli : Form
    {

        public static string girisSekli = "Misafir", kullaniciAdi, ad, soyad, email;
        OleDbConnection baglantiNesnesi = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0; Data Source=" + Application.StartupPath + "\\KutuphaneDatabase.accdb");

        public FormGirisPaneli()
        {
            InitializeComponent();
        }


        private void GirisPaneli_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            //this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;

            radioButtonYonetici.Checked = true;
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            labelGirisDurumu.Text = "";
            errorProviderKullaniciGirisi.Clear();

            if (textBoxKullaniciAdi.TextLength == 0 || textBoxParola.TextLength == 0)
            {
                labelGirisDurumu.Text = "Kullanıcı adı veya parola boş bırakılamaz";
                errorProviderKullaniciGirisi.SetError(labelGirisDurumu, "Kullanıcı adı veya parola boş bırakılamaz");
            }

            else if (radioButtonYonetici.Checked == true)
            {
                baglantiNesnesi.Open();
                OleDbCommand selectSorgu = new OleDbCommand("select *from Yoneticiler", baglantiNesnesi);
                OleDbDataReader kayitOkuma = selectSorgu.ExecuteReader();
                while (kayitOkuma.Read())
                {
                    if (kayitOkuma["kullaniciAdi"].ToString() == textBoxKullaniciAdi.Text && kayitOkuma["parola"].ToString() == textBoxParola.Text)
                    {
                        kullaniciAdi = kayitOkuma.GetValue(0).ToString();
                        ad = kayitOkuma.GetValue(2).ToString();
                        soyad = kayitOkuma.GetValue(3).ToString();
                        email = kayitOkuma.GetValue(4).ToString();
                        girisSekli = "Yönetici";
                        FormAnaSayfa kutuphaneAnasayfaNesnesi = new FormAnaSayfa();
                        kutuphaneAnasayfaNesnesi.Show();
                        this.Hide();
                        break;
                    }
                }
            }

            else if (radioButtonKullanici.Checked == true)
            {
                baglantiNesnesi.Open();
                OleDbCommand selectSorgu = new OleDbCommand("select *from Kullanicilar", baglantiNesnesi);
                OleDbDataReader kayitOkuma = selectSorgu.ExecuteReader();
                while (kayitOkuma.Read())
                {
                    if (kayitOkuma["kullaniciAdi"].ToString() == textBoxKullaniciAdi.Text && kayitOkuma["parola"].ToString() == textBoxParola.Text)
                    {
                        kullaniciAdi = kayitOkuma.GetValue(0).ToString();
                        ad = kayitOkuma.GetValue(2).ToString();
                        soyad = kayitOkuma.GetValue(3).ToString();
                        email = kayitOkuma.GetValue(4).ToString();
                        girisSekli = "Kullanıcı";
                        FormAnaSayfa kutuphaneAnasayfaNesnesi = new FormAnaSayfa();
                        kutuphaneAnasayfaNesnesi.Show();
                        this.Hide();
                        break;
                    }
                }
            }
            baglantiNesnesi.Close();
            labelGirisDurumu.Text = "Kullanıcı adı veya parola yanlış";
            errorProviderKullaniciGirisi.SetError(labelGirisDurumu, "Kullanıcı adı veya parola yanlış");
        }

            private void buttonMisafirGirisi_Click(object sender, EventArgs e)
        {
            FormAnaSayfa kutuphaneAnasayfaNesnesi = new FormAnaSayfa();
            kutuphaneAnasayfaNesnesi.Show();  
            this.Hide();
            girisSekli = "Misafir";
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }
    }
}
