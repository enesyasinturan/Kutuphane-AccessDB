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
using System.Data.SqlClient;

namespace Kutuphane
{
    public partial class FormAnaSayfa : Form
    {
        //OleDbConnection baglantiNesnesi = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0; Data Source=" + Application.StartupPath + "\\KutuphaneDatabase.accdb");
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        void musteriGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=KutuphaneDatabase; Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM kitap", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewKitaplar.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteriGetir();

            //labelGirisSekli.Text = FormGirisPaneli.girisSekli;
            //this.ControlBox = false;
            //this.FormBorderStyle = FormBorderStyle.Sizable;

            //if (labelGirisSekli.Text == "Misafir")
            //{
            //    textBoxYazari.Enabled = false;
            //    numericUpDownSayfaSayisi.Enabled = false;
            //    textBoxYayimevi.Enabled = false;
            //    numericUpDownBasimYili.Enabled = false;
            //    dateTimePickerBaslangicTarihi.Enabled = false;
            //    buttonEkle.Enabled = false;
            //    buttonGuncelle.Enabled = false;
            //    buttonSil.Enabled = false;
            //    buttonKullanicilariYonet.Enabled = false;

            //    labelAdYazisi.Visible = false;
            //    labelSoyadYazisi.Visible = false;
            //    labelEmailYazisi.Visible = false;
            //    labelAd.Visible = false;
            //    labelSoyad.Visible = false;
            //    labelEmail.Visible = false;
            //    labelKullaniciAdi.Visible = false;
            //    labelKullaniciAdiYazisi.Visible = false;
            //}

            //if (labelGirisSekli.Text == "Kullanıcı")
            //    buttonKullanicilariYonet.Enabled = false;

            //labelKullaniciAdi.Text = FormGirisPaneli.kullaniciAdi;
            //labelAd.Text = FormGirisPaneli.ad;
            //labelSoyad.Text = FormGirisPaneli.soyad;
            //labelEmail.Text = FormGirisPaneli.email;


            //Listele();
            //numericUpDownSayfaSayisi.Minimum = 0;
            //numericUpDownSayfaSayisi.Maximum = 3000;
            //numericUpDownBasimYili.Maximum = 3000;
            //numericUpDownBasimYili.Minimum = 1800;
            //numericUpDownBasimYili.Value = 2021;

            //dateTimePickerBaslangicTarihi.MinDate = new DateTime(2010, 1, 1);
            //dateTimePickerBaslangicTarihi.MaxDate = new DateTime(2050, 12, 29);

            //FormGirisPaneli girisPanelNesnesi = new FormGirisPaneli();
            //girisPanelNesnesi.Close();
        }

        private void Listele()
        {
            try
            {
                baglantiNesnesi.Open();
                OleDbDataAdapter veriCagirmaNesnesi = new OleDbDataAdapter("select kitapAdi AS[Kitap Adı], kitapYazari AS[Yazarı], kitapSayfaSayisi AS[Sayfa Sayısı], kitapYayimevi AS[Yayımevi], kitapBasimYili AS[Basım Yılı], kitapBaslangicTarihi AS[Başlangıç Tarihi], kitapBitisTarihi AS[Bitiş Tarihi] from Kitaplar order by kitapBaslangicTarihi desc", baglantiNesnesi);
                DataSet veriTabaniDuzenlemeNesnesi = new DataSet();
                veriCagirmaNesnesi.Fill(veriTabaniDuzenlemeNesnesi);
                dataGridViewKitaplar.DataSource = veriTabaniDuzenlemeNesnesi.Tables[0];
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
            textBoxKitapAdi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[0].Value.ToString();
            textBoxYazari.Text = dataGridViewKitaplar.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDownSayfaSayisi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[2].Value.ToString();
            textBoxYayimevi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[3].Value.ToString();
            numericUpDownBasimYili.Text = dataGridViewKitaplar.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePickerBaslangicTarihi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Temizle()
        {
            textBoxKitapAdi.Clear();
            textBoxYazari.Clear();
            numericUpDownSayfaSayisi.Value = 0;
            textBoxYayimevi.Clear();
            numericUpDownBasimYili.Value = 2021;
            dateTimePickerBaslangicTarihi.Value = DateTime.Now;

            labelKitapAdi.ForeColor = Color.Black;
            labelYazarAdi.ForeColor = Color.Black;
            labelSayfaSayisi.ForeColor = Color.Black;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (textBoxKitapAdi.TextLength == 0)
            {
                labelKitapAdi.ForeColor = Color.Red;
                labelYazarAdi.ForeColor = Color.Black;
                labelSayfaSayisi.ForeColor = Color.Black;
                MessageBox.Show("Kitap ismi boş bırakılamaz.", "Doldurulmayan Alan Hatası");
            }
            else if (textBoxYazari.TextLength == 0)
            {
                labelYazarAdi.ForeColor = Color.Red;
                labelKitapAdi.ForeColor = Color.Black;
                labelSayfaSayisi.ForeColor = Color.Black;
                MessageBox.Show("Yazar adı boş bırakılamaz.", "Doldurulmayan Alan Hatası");
            }
            else if (numericUpDownSayfaSayisi.Value == 0)
            {
                labelSayfaSayisi.ForeColor = Color.Red;
                labelKitapAdi.ForeColor = Color.Black;
                labelYazarAdi.ForeColor = Color.Black;
                MessageBox.Show("Sayfa sayısı boş bırakılamaz.", "Doldurulmayan Alan Hatası");
            }

            else
            {
                labelKitapAdi.ForeColor = Color.Black;
                labelYazarAdi.ForeColor = Color.Black;
                labelSayfaSayisi.ForeColor = Color.Black;

                textBoxKitapAdi.ForeColor = Color.Black;
                try
                {
                    baglantiNesnesi.Open();
                    OleDbCommand veriYazmaNesnesi = new OleDbCommand("insert into Kitaplar(kitapAdi,kitapYazari,kitapSayfaSayisi,kitapYayimevi,kitapBasimYili, kitapBaslangicTarihi, kitapBitisTarihi) values('" + textBoxKitapAdi.Text + "','" + textBoxYazari.Text + "','" + numericUpDownSayfaSayisi.Value + "','" + textBoxYayimevi.Text + "','" + numericUpDownBasimYili.Value + "','" + dateTimePickerBaslangicTarihi.Value + "','" + DateTime.Now + "')", baglantiNesnesi);
                    veriYazmaNesnesi.ExecuteNonQuery();
                    baglantiNesnesi.Close();
                    Listele();
                    MessageBox.Show("Kitap kayıtlara eklendi.", "Kayıt İşlemi");
                    Temizle();
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Kayıt Hatası");
                    baglantiNesnesi.Close();
                }
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silenecek, devam etmek istiyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    baglantiNesnesi.Open();
                    OleDbCommand veriSilmeNesnesi = new OleDbCommand("delete from Kitaplar where kitapAdi='" + dataGridViewKitaplar.SelectedRows[0].Cells[0].Value.ToString() + "'", baglantiNesnesi);
                    veriSilmeNesnesi.ExecuteNonQuery();
                    baglantiNesnesi.Close();
                    MessageBox.Show("Kitap veri tabanından silindi.", "Silme İşlemi");
                    Listele();
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Silme Hatası");
                    baglantiNesnesi.Close();
                }
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            if (textBoxKitapAdi.TextLength == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kayıt üzerine çift tıklayınız.", "Güncelleme Hatası");
            }
            else
            {
                try
                {
                    baglantiNesnesi.Open();
                    //OleDbCommand guncellemeKomutNesnesi = new OleDbCommand("update Kitaplar set kitapYazari='" + textBoxYazari.Text + "' where kitapYazari= '"+ dataGridViewKitaplar.SelectedCells +"'", baglantiNesnesi);
                    OleDbCommand guncellemeKomutNesnesi = new OleDbCommand("update Kitaplar set kitapAdi = '" + textBoxKitapAdi.Text + "', kitapYazari = '" + textBoxYazari.Text + "', kitapSayfaSayisi = '" + numericUpDownSayfaSayisi.Value.ToString() + "', kitapYayimevi = '" + textBoxYayimevi.Text + "', kitapBasimYili = '" + numericUpDownBasimYili.Value.ToString() + "', kitapBaslangicTarihi='" + dateTimePickerBaslangicTarihi.Value.ToString() + "', kitapBitisTarihi='" + DateTime.Now + "'  where kitapAdi= '" + textBoxKitapAdi.Text + "'", baglantiNesnesi);
                    guncellemeKomutNesnesi.ExecuteNonQuery();
                    baglantiNesnesi.Close();
                    Listele();
                    MessageBox.Show("Kitap bilgileri güncellendi.", "Güncelleme İşlemi");
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Güncelleme Hatası");
                    baglantiNesnesi.Close();
                }
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            if (textBoxKitapAdi.TextLength == 0)
            {
                textBoxKitapAdi.ForeColor = Color.Red;
                MessageBox.Show("Lütfen aramak istediğiniz kitap ismini giriniz.", "Arama Hatası");
            }

            else
            {
                baglantiNesnesi.Open();
                OleDbDataAdapter aramaKomutNesnesi = new OleDbDataAdapter("select *from Kitaplar where kitapAdi='" + textBoxKitapAdi.Text + "'", baglantiNesnesi);
                DataSet kayitSaklamaNesnesi = new DataSet();
                aramaKomutNesnesi.Fill(kayitSaklamaNesnesi);
                if (kayitSaklamaNesnesi.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Aradığınız kitap kayıtlarda yoktur.");
                    baglantiNesnesi.Close();
                    Temizle();
                    Listele();
                }
                else
                {

                    dataGridViewKitaplar.DataSource = kayitSaklamaNesnesi.Tables[0];
                    baglantiNesnesi.Close();
                    MessageBox.Show("Aradığınız kayıt getirildi.");
                }
            }
        }

        private void dataGridViewKitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Doldur();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }

        private void buttonGirisPanelineGit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGirisPaneli.girisSekli = "Misafir";
            FormGirisPaneli girisPaneliNesnesi = new FormGirisPaneli();
            girisPaneliNesnesi.Show();
        }

        private void buttonKullanicilariYonet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKullaniciYonetimPaneli formKullaniciYonetimPaneliNesnesi = new FormKullaniciYonetimPaneli();
            formKullaniciYonetimPaneliNesnesi.Show();
        }
    }
}
