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
    public partial class KutuphaneAnasayfa : Form
    {


        public KutuphaneAnasayfa()
        {
            InitializeComponent();
        }

        OleDbConnection baglantiNesnesi = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0; Data Source=" + Application.StartupPath + "\\KutuphaneDatabase.accdb");

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                baglantiNesnesi.Open();
                OleDbDataAdapter veriCagirmaNesnesi = new OleDbDataAdapter("select *from Kitaplar", baglantiNesnesi);
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

        private void Temizle()
        {
            textBoxKitapAdi.Clear();
            textBoxYazari.Clear();
            textBoxSayfaSayisi.Clear();
            textBoxYayimevi.Clear();
            textBoxBasimYili.Clear();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if(textBoxKitapAdi.TextLength == 0)
            {
                labelKitapAdi.ForeColor = Color.Red;
                labelYazarAdi.ForeColor = Color.Black;
                labelSayfaSayisi.ForeColor = Color.Black;
                MessageBox.Show("Kitap ismi boş bırakılamaz.","Doldurulmayan Alan Hatası");
            }
            else if(textBoxYazari.TextLength == 0)
            {
                labelYazarAdi.ForeColor = Color.Red;
                labelKitapAdi.ForeColor = Color.Black;
                labelSayfaSayisi.ForeColor = Color.Black;
                MessageBox.Show("Yazar adı boş bırakılamaz.", "Doldurulmayan Alan Hatası");
            }
            else if (textBoxSayfaSayisi.TextLength == 0)
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
                try
                {
                    baglantiNesnesi.Open();
                    OleDbCommand veriYazmaNesnesi = new OleDbCommand("insert into Kitaplar(kitapAdi,kitapYazari,kitapSayfaSayisi,kitapYayimevi,kitapBasimYili,kitapBaslangicTarihi,kitapBitisTarihi) values('" + textBoxKitapAdi.Text + "','"+ textBoxYazari.Text + "','"+ textBoxSayfaSayisi.Text + "','"+ textBoxYayimevi.Text + "','"+ textBoxBasimYili.Text + "','"+dateTimePickerBaslangicTarihi.ToString() +"','"+ dateTimePickerBitisTarihi.ToString() +"'",baglantiNesnesi);
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
            try
            {
                baglantiNesnesi.Open();
                OleDbCommand veriSilmeNesnesi = new OleDbCommand("delete from Kitaplar where kitapAdi='" + dataGridViewKitaplar.SelectedRows[0].Cells[1].Value.ToString() + "'", baglantiNesnesi);
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

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantiNesnesi.Open();
                OleDbCommand guncellemeKomutNesnesi = new OleDbCommand("update Kitaplar set kitapYazari='" + textBoxYazari.Text + "' where id= '"+ dataGridViewKitaplar.SelectedCells +"'", baglantiNesnesi);
                guncellemeKomutNesnesi.ExecuteNonQuery();
                baglantiNesnesi.Close();
                Listele();
                MessageBox.Show("Kitap bilgileri güncellendi.","Güncelleme İşlemi");
            }
            catch (Exception hataMesaji)
            {
                MessageBox.Show(hataMesaji.Message, "Güncelleme Hatası");
                baglantiNesnesi.Close();
            }
            
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridViewKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            

            textBoxKitapAdi.Text = dataGridViewKitaplar.SelectedCells[0].Value.ToString();
            textBoxYazari.Text = dataGridViewKitaplar.SelectedCells[1].Value.ToString();
            textBoxSayfaSayisi.Text = dataGridViewKitaplar.SelectedCells[2].Value.ToString();
            textBoxYayimevi.Text = dataGridViewKitaplar.SelectedCells[3].Value.ToString();
            textBoxBasimYili.Text = dataGridViewKitaplar.SelectedCells[4].Value.ToString();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            if(textBoxKitapAdi.TextLength == 0)
            {
                textBoxKitapAdi.ForeColor = Color.Red;
                MessageBox.Show("Lütfen aramak istediğiniz kitap ismini giriniz.", "Arama Hatası");
            }

            else
            {
                try
                {
                    baglantiNesnesi.Open();
                    OleDbDataAdapter aramaKomutNesnesi = new OleDbDataAdapter("select *from Kitaplar where kitapAdi='" + textBoxKitapAdi.Text + "'", baglantiNesnesi);
                    DataSet kayitSaklamaNesnesi = new DataSet();
                    aramaKomutNesnesi.Fill(kayitSaklamaNesnesi);
                    dataGridViewKitaplar.DataSource = kayitSaklamaNesnesi.Tables[0];
                    baglantiNesnesi.Close();
                    MessageBox.Show("Aradığınız kayıt getirildi.");
                    
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Aradığınız kitap kayıtlarda yoktur.");
                    baglantiNesnesi.Close();
                }
            }
        }
    }
}
