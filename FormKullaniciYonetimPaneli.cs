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
    public partial class FormKullaniciYonetimPaneli : Form
    {
        public FormKullaniciYonetimPaneli()
        {
            InitializeComponent();
        }

        OleDbConnection baglantiNesnesi = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0; Data Source=" + Application.StartupPath + "\\KutuphaneDatabase.accdb");


        private void FormKullaniciYonetimPaneli_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            textBoxKullaniciYonetimKayitTarihi.Enabled = false;
            textBoxKullaniciYonetimGuncellemeTarihi.Enabled = false;
            dataGridViewKullanicilar.MultiSelect = false;
            dataGridViewKullanicilar.MultiSelect = false;
            dataGridViewKullanicilar.ReadOnly = true;
            dataGridViewKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Listele();

        }

        private void Listele()
        {
            try
            {
                baglantiNesnesi.Open();
                OleDbDataAdapter veriCagirmaNesnesi = new OleDbDataAdapter("select kullaniciAdi AS[Kullanıcı Adı], parola AS[Parola], ad AS[Ad], soyad AS[Soyad], email AS[E-Mail], kayitTarihi AS[Kayıt Tarihi], guncellemeTarihi AS[Güncelleme Tarihi] from Kullanicilar", baglantiNesnesi);
                DataSet veriTabaniDuzenlemeNesnesi = new DataSet();
                veriCagirmaNesnesi.Fill(veriTabaniDuzenlemeNesnesi);
                dataGridViewKullanicilar.DataSource = veriTabaniDuzenlemeNesnesi.Tables[0];
                baglantiNesnesi.Close();
            }
            catch (Exception hataMesaji)
            {
                MessageBox.Show(hataMesaji.Message, "Veri Çekme Hatası");
                baglantiNesnesi.Close();
            }
        }

        private void Doldur()
        {
            textBoxKullaniciYonetimKullaniciAdi.Text = dataGridViewKullanicilar.SelectedRows[0].Cells[0].Value.ToString();
            textBoxKullaniciYonetimParola.Text = dataGridViewKullanicilar.SelectedRows[0].Cells[1].Value.ToString();
            textBoxKullaniciYonetimAd.Text = dataGridViewKullanicilar.SelectedRows[0].Cells[2].Value.ToString();
            textBoxKullaniciYonetimSoyad.Text = dataGridViewKullanicilar.SelectedRows[0].Cells[3].Value.ToString();
            textBoxKullaniciYonetimEmail.Text = dataGridViewKullanicilar.SelectedRows[0].Cells[4].Value.ToString();
            textBoxKullaniciYonetimKayitTarihi.Text = dataGridViewKullanicilar.SelectedRows[0].Cells[5].Value.ToString();
            textBoxKullaniciYonetimGuncellemeTarihi.Text = dataGridViewKullanicilar.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Temizle()
        {
            textBoxKullaniciYonetimKullaniciAdi.Clear();
            textBoxKullaniciYonetimParola.Clear();
            textBoxKullaniciYonetimAd.Clear();
            textBoxKullaniciYonetimSoyad.Clear();
            textBoxKullaniciYonetimEmail.Clear();
            textBoxKullaniciYonetimKayitTarihi.Clear();

            labelKullaniciYonetimKullaniciAdi.ForeColor = Color.Black;
            labelKullaniciYonetimParola.ForeColor = Color.Black;
            labelKullaniciYonetimAd.ForeColor = Color.Black;
            labelKullaniciYonetimSoyad.ForeColor = Color.Black;
            labelKullaniciYonetimEmail.ForeColor = Color.Black;
        }




        private void buttonKullaniciYonetimCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAnaSayfa formAnaSayfaNesnesi = new FormAnaSayfa();
            formAnaSayfaNesnesi.Show();
        }

        private void buttonKullaniciYonetimEkle_Click(object sender, EventArgs e)
        {
            if (textBoxKullaniciYonetimKullaniciAdi.TextLength == 0)
            {
                labelKullaniciYonetimKullaniciAdi.ForeColor = Color.Red;
                labelKullaniciYonetimParola.ForeColor = Color.Black;
                labelKullaniciYonetimAd.ForeColor = Color.Black;
                labelKullaniciYonetimSoyad.ForeColor = Color.Black;
                labelKullaniciYonetimEmail.ForeColor = Color.Black;
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.", "Doldurulmayan Alan Hatası");
            }
            else if (textBoxKullaniciYonetimParola.TextLength == 0)
            {
                labelKullaniciYonetimKullaniciAdi.ForeColor = Color.Black;
                labelKullaniciYonetimParola.ForeColor = Color.Red;
                labelKullaniciYonetimAd.ForeColor = Color.Black;
                labelKullaniciYonetimSoyad.ForeColor = Color.Black;
                labelKullaniciYonetimEmail.ForeColor = Color.Black;
                MessageBox.Show("Parola boş bırakılamaz.", "Doldurulmayan Alan Hatası");
            }
            else if (textBoxKullaniciYonetimAd.TextLength == 0)
            {
                labelKullaniciYonetimKullaniciAdi.ForeColor = Color.Black;
                labelKullaniciYonetimParola.ForeColor = Color.Black;
                labelKullaniciYonetimAd.ForeColor = Color.Red;
                labelKullaniciYonetimSoyad.ForeColor = Color.Black;
                labelKullaniciYonetimEmail.ForeColor = Color.Black;
                MessageBox.Show("Ad alanı boş bırakılamaz.", "Doldurulmayan Alan Hatası");
            }

            else if (textBoxKullaniciYonetimSoyad.TextLength == 0)
            {
                labelKullaniciYonetimKullaniciAdi.ForeColor = Color.Black;
                labelKullaniciYonetimParola.ForeColor = Color.Black;
                labelKullaniciYonetimAd.ForeColor = Color.Black;
                labelKullaniciYonetimSoyad.ForeColor = Color.Red;
                labelKullaniciYonetimEmail.ForeColor = Color.Black;
                MessageBox.Show("Soyad alanı boş bırakılamaz.", "Doldurulmayan Alan Hatası");
            }

            else
            {
                labelKullaniciYonetimKullaniciAdi.ForeColor = Color.Black;
                labelKullaniciYonetimParola.ForeColor = Color.Black;
                labelKullaniciYonetimAd.ForeColor = Color.Black;
                labelKullaniciYonetimSoyad.ForeColor = Color.Black;

                try
                {
                    baglantiNesnesi.Open();
                    OleDbCommand veriYazmaNesnesi = new OleDbCommand("insert into Kullanicilar(kullaniciAdi, parola, ad, soyad, email, kayitTarihi) values('" + textBoxKullaniciYonetimKullaniciAdi.Text + "','" + textBoxKullaniciYonetimParola.Text + "','" + textBoxKullaniciYonetimAd.Text + "','" + textBoxKullaniciYonetimSoyad.Text + "','" + textBoxKullaniciYonetimEmail.Text + "','" + DateTime.Now + "')", baglantiNesnesi);
                    veriYazmaNesnesi.ExecuteNonQuery();
                    baglantiNesnesi.Close();
                    Listele();
                    MessageBox.Show("Yeni kullanıcı başarıyla eklendi.", "Kayıt İşlemi");
                    Temizle();
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Kayıt Hatası");
                    baglantiNesnesi.Close();
                }
            }
        }

        private void dataGridViewKullanicilar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Doldur();
        }

        private void buttonKullaniciTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void buttonKullaniciYonetimSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silenecek, devam etmek istiyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    baglantiNesnesi.Open();
                    OleDbCommand veriSilmeNesnesi = new OleDbCommand("delete from Kullanicilar where kullaniciAdi='" + dataGridViewKullanicilar.SelectedRows[0].Cells[0].Value.ToString() + "'", baglantiNesnesi);
                    veriSilmeNesnesi.ExecuteNonQuery();
                    baglantiNesnesi.Close();
                    MessageBox.Show("Kullanıcı veri tabanından silindi.", "Silme İşlemi");
                    Listele();
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Silme Hatası");
                    baglantiNesnesi.Close();
                }
            }
        }

        private void buttonKullaniciYonetimGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxKullaniciYonetimKullaniciAdi.TextLength == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kayıt üzerine çift tıklayınız.", "Güncelleme Hatası");
            }
            else
            {
                try
                {
                    baglantiNesnesi.Open();
                    OleDbCommand guncellemeKomutNesnesi = new OleDbCommand("update Kullanicilar set kullaniciAdi = '" + textBoxKullaniciYonetimKullaniciAdi.Text + "', parola = '" + textBoxKullaniciYonetimParola.Text + "', ad = '" + textBoxKullaniciYonetimAd.Text + "', soyad = '" + textBoxKullaniciYonetimSoyad.Text + "', email = '" + textBoxKullaniciYonetimEmail.Text + "', guncellemeTarihi='"+ DateTime.Now +"' where kullaniciAdi= '" + textBoxKullaniciYonetimKullaniciAdi.Text + "'", baglantiNesnesi);
                    guncellemeKomutNesnesi.ExecuteNonQuery();
                    baglantiNesnesi.Close();

                    //baglantiNesnesi.Open();
                    //OleDbCommand veriYazmaNesnesi = new OleDbCommand("insert into Kullanicilar set guncellemeTarihi='" + DateTime.Now.ToString() + "')", baglantiNesnesi);
                    //veriYazmaNesnesi.ExecuteNonQuery();
                    //baglantiNesnesi.Close();

                    Listele();
                    MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Güncelleme İşlemi");
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Güncelleme Hatası");
                    baglantiNesnesi.Close();
                }
            }
        }

        private void buttonKullaniciYonetimAra_Click(object sender, EventArgs e)
        {
            if (textBoxKullaniciYonetimKullaniciAdi.TextLength == 0)
            {
                textBoxKullaniciYonetimKullaniciAdi.ForeColor = Color.Red;
                MessageBox.Show("Lütfen aramak istediğiniz kullanıcının kullanıcı adını giriniz.", "Arama Hatası");
            }

            else
            {
                baglantiNesnesi.Open();
                OleDbDataAdapter aramaKomutNesnesi = new OleDbDataAdapter("select *from Kullanicilar where kullaniciAdi='" + textBoxKullaniciYonetimKullaniciAdi.Text + "'", baglantiNesnesi);
                DataSet kayitSaklamaNesnesi = new DataSet();
                aramaKomutNesnesi.Fill(kayitSaklamaNesnesi);
                if (kayitSaklamaNesnesi.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Aradığınız kullanıcı kayıtlarda yoktur.");
                    baglantiNesnesi.Close();
                    Temizle();
                    Listele();
                }
                else
                {

                    dataGridViewKullanicilar.DataSource = kayitSaklamaNesnesi.Tables[0];
                    baglantiNesnesi.Close();
                    MessageBox.Show("Aradığınız kayıt getirildi.");
                }
            }
        }
    } 
}
