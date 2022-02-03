using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazarEserDB
{
    public partial class Form1 : Form
    {
        YazarEserDBEntities db = new YazarEserDBEntities();

        public Form1()
        {
            InitializeComponent();
            YazarlariYukle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //yeni yazar eklenir
            YazarlariYukle();
            EserleriYukle();
        }
        private void YazarlariYukle()
        {
            //yazar panelinde
            LstYazarEkle();
            //eser panelinde
            EserlerCmbYazarYukle();
            //anasayfa panelinde
            //TODO: yazarları yükle
            AnasayfaCmbYazarYukle();
        }
        private void LstYazarEkle()
        {
            lstYazarlar.DataSource = db.Yazarlar.ToList();
            lstYazarlar.DisplayMember = "TamAd";
            lstYazarlar.ValueMember = "Id";
        }

        private void EserlerCmbYazarYukle()
        {
            cmbEserYazarlar.Items.Clear();
            cmbEserYazarlar.Items.Add("--Anonim Yazar");
            foreach (var item in db.Yazarlar)
            {
                cmbEserYazarlar.Items.Add(item);
            }
            cmbEserYazarlar.DisplayMember = "TamAd";//nesnenin icindeki property adıyla eşleşirse o propertydeki değeri gösterir.
            cmbEserYazarlar.SelectedIndex = 0;
        }

        private void AnasayfaCmbYazarYukle()
        {
            cmbAnasayfaYazarlar.Items.Clear();
            cmbAnasayfaYazarlar.Items.Add("---Tüm Yazarlar---");
            foreach (var item in db.Yazarlar)
            {
                cmbAnasayfaYazarlar.Items.Add(item);
            }
            cmbAnasayfaYazarlar.DisplayMember = "TamAd";
            cmbAnasayfaYazarlar.SelectedIndex = 0;
        }

        private void GuncelleCevir()
        {
            if (lstYazarlar.SelectedItem != null)
            {
                btnEkle.Text = "GUNCELLE";
                btnIptal.Visible = true;
                grpYazar.Text = "Yazar Guncelleme ";

                Yazar guncellenecekYazar = (Yazar)lstYazarlar.SelectedItem;
                txtTamAd.Text = guncellenecekYazar.TamAd;
                txtResimYolu.Text = guncellenecekYazar.ResimYolu;
            }
        }
        private void EkleCevir()
        {
            btnEkle.Text = "EKLE";
            btnIptal.Visible = false;
            grpYazar.Text = "Yazar Ekle ";
            txtResimYolu.Clear();
            txtTamAd.Clear();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "EKLE")
            {
                if (!string.IsNullOrEmpty(txtTamAd.Text) || !string.IsNullOrEmpty(txtResimYolu.Text))
                {
                    db.Yazarlar.Add(new Yazar()
                    {
                        TamAd = txtTamAd.Text,
                        ResimYolu = txtResimYolu.Text,
                    });
                    db.SaveChanges(); //yaarlara yeni yazar ekler
                    txtResimYolu.Clear();
                    txtTamAd.Clear();
                }
                else
                {
                    MessageBox.Show("Eksik Alan Bırakmayınız");
                }
            }
            else if (btnEkle.Text == "GUNCELLE")
            {
                //seçili yazar güncellenir
                Yazar guncellenecekYazar = (Yazar)lstYazarlar.SelectedItem;
                guncellenecekYazar.TamAd = txtTamAd.Text;
                guncellenecekYazar.ResimYolu = txtResimYolu.Text;
                db.SaveChanges();
                EkleCevir();
            }
            YazarlariYukle();
        }

        private void lstYazarlar_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            GuncelleCevir();
        }
        private void lstYazarlar_KeyDown_1(object sender, KeyEventArgs e)
        {
            //basılan tuş delete ise seçili yazarı siliniz
            if (lstYazarlar.SelectedItem != null && e.KeyCode == Keys.Delete)
            {
                Yazar silinecekYazar = (Yazar)lstYazarlar.SelectedItem;
                db.Yazarlar.Remove(silinecekYazar);
                db.SaveChanges();
                YazarlariYukle();
            }
            txtTamAd.Clear();
            txtResimYolu.Clear();
        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            //groupbox yazar ekle moduna geçecek
            EkleCevir();
        }
        private void btnEserEkle_Click(object sender, EventArgs e)
        {
            //combobox in ilk elemanını seçiniz olarak veriniz
            //combobox dan secili yazara göre ya da combobox da anonim secili ise anonim olarak eser ekleyiniz
            //ekle dedikten sonra listele metodu ile lst eserlerde listeleyiniz
            if (btnEserEkle.Text == "Eser Ekle")
            {
                if (!string.IsNullOrEmpty(txtEserBaslik.Text) && !string.IsNullOrEmpty(txtEserIcerik.Text))
                {
                    Eser eser = new Eser()
                    {
                        Baslik = txtEserBaslik.Text,
                        Icerik = txtEserIcerik.Text,
                    };
                    if (cmbEserYazarlar.SelectedIndex != 0)//yazar seçilmiştir
                    {
                        eser.Yazar = (Yazar)cmbEserYazarlar.SelectedItem;
                    }
                    db.Eserler.Add(eser);
                    db.SaveChanges();
                    EserleriYukle();
                    txtEserBaslik.Clear();
                    txtEserIcerik.Clear();
                    cmbEserYazarlar.SelectedIndex = 0;

                }
            }
            else if (btnEserEkle.Text == "GUNCELLE")
            {
                Eser guncellenecekEser = (Eser)lstEserler.SelectedItem;
                guncellenecekEser.Baslik = txtEserBaslik.Text;
                guncellenecekEser.Icerik = txtEserIcerik.Text;
                if (cmbEserYazarlar.SelectedIndex == 0)
                {
                    guncellenecekEser.YazarId = null;
                }
                else
                {
                    guncellenecekEser.YazarId = ((Yazar)cmbEserYazarlar.SelectedItem).Id;
                }
                db.SaveChanges();
                EserEkleCevir();
            }
            EserleriYukle();

        }
        private void EserleriYukle()
        {
            EserPanelYukle();
            AnasayfaEserYazarFotoYukle();
        }
        private void AnasayfaEserYazarFotoYukle()
        {
            if (cmbAnasayfaYazarlar.SelectedIndex == 0)//tum yazarları listele
            {
                lstAnasayfaEserler.DataSource = db.Eserler.ToList();
                lstAnasayfaEserler.DisplayMember = "Baslik";
                pboYazarFoto.ImageLocation = " https://t4.ftcdn.net/jpg/02/38/86/89/360_F_238868953_D6dfKSahj9HBXzzNleaPmfQI8gtN1jq5.jpg";

            }
            else if (cmbAnasayfaYazarlar.SelectedItem != null)//seçili yazarın eserleri
            {
                Yazar seciliYazar = (Yazar)cmbAnasayfaYazarlar.SelectedItem;
                lstAnasayfaEserler.DataSource = seciliYazar.Eserler.ToList();
                pboYazarFoto.ImageLocation = seciliYazar.ResimYolu;
            }


        }

        private void EserPanelYukle()
        {
            lstEserler.DataSource = db.Eserler.ToList();
            lstEserler.DisplayMember = "Baslik";
        }

        private void lstEserler_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstEserler.SelectedItem != null && e.KeyCode == Keys.Delete)
            {
                Eser silinecekEser = (Eser)lstEserler.SelectedItem;
                db.Eserler.Remove(silinecekEser);
                db.SaveChanges();
                EserleriYukle();
            }

        }
        private void lstEserler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //eserguncelle cevir
            EserGuncelleCevir();

        }
        private void EserGuncelleCevir()
        {
            if (lstEserler.SelectedItem != null)
            {
                btnEserEkle.Text = "GUNCELLE";
                groupBox1.Text = "Guncelleme Ekranı";
                btnIptal.Visible = true;

                Eser guncellenecekEser = (Eser)lstEserler.SelectedItem;
                txtEserBaslik.Text = guncellenecekEser.Baslik;
                txtEserIcerik.Text = guncellenecekEser.Icerik;
                //cmbEserYazarlar.SelectedItem = guncellenecekEser.Yazar;
                if (guncellenecekEser.Yazar == null)
                {
                    cmbEserYazarlar.SelectedIndex = 0;

                }
                else
                {
                    cmbEserYazarlar.SelectedItem = guncellenecekEser.Yazar;
                }
            }
        }

        private void btnEserIptal_Click(object sender, EventArgs e)
        {
            EserEkleCevir();
            txtEserBaslik.Clear();
            txtEserIcerik.Clear();
            cmbEserYazarlar.SelectedIndex = 0;
        }

        private void EserEkleCevir()
        {
            btnEserEkle.Text = "Ekle";
            groupBox1.Text = "Eser Ekle";
            btnIptal.Visible = false;
        }

        private void cmbAnasayfaYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnasayfaEserYazarFotoYukle();
            txtAnasayfaEserAciklama.Clear();
        }

        private void lstAnasayfaEserler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAnasayfaEserler.SelectedItem!=null)
            {
                Eser eser = (Eser)lstAnasayfaEserler.SelectedItem;
                txtAnasayfaEserAciklama.Text = eser.Icerik;
            }
            else
            {
                txtAnasayfaEserAciklama.Clear();
            }
        }
    }
}
