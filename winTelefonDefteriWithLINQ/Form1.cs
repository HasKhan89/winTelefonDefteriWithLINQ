using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winTelefonDefteriWithLINQ
{
    public partial class Form1 : Form
    {
        ObservableCollection<Kisi> Kisiler = new ObservableCollection<Kisi>();

        // constructor..
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kisiler.CollectionChanged += Kisiler_CollectionChanged;

            // Daha önceden veri kaydedilmiş ise..
            if(File.Exists(Application.StartupPath + "//data.xml"))
            {
                string xml = File.ReadAllText(Application.StartupPath + "//data.xml");

                Wissen.SC501.Common.Tools.XmlSerialization ser =
                    new Wissen.SC501.Common.Tools.XmlSerialization();

                ObservableCollection<Kisi> okunanData = 
                    ser.FromXML<ObservableCollection<Kisi>>(xml);

                okunanData.ToList().ForEach(x => Kisiler.Add(x));
                return; // Dosyadan okuduysak örnek data oluşturmaya gerek yok.
            }


            // sample data..
            for (int i = 0; i < 20; i++)
            {
                Kisi kisi = new Kisi()
                {
                    ID = i + 1,
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    Tel = FakeData.PhoneNumberData.GetPhoneNumber()
                };

                Kisiler.Add(kisi);
            }
        }

        private void Kisiler_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            LoadKisiler();
        }

        private void LoadKisiler()
        {
            lstKisiler.Items.Clear();

            Kisiler.ToList().ForEach(
                kisi => lstKisiler.Items.Add(kisi));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int max_id = 0;

            // Eğer kişiler listesinde kişi varsa linq ile max değer sorgulanır.
            if (Kisiler.Count > 0)
            {
                max_id = (from kisi in Kisiler
                          select kisi.ID).Max();
            }

            Kisi k = new Kisi()
            {
                ID = max_id + 1,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Tel = txtTel.Text
            };

            Kisiler.Add(k);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex > -1)
            {
                Kisi secilenKisi = lstKisiler.SelectedItem as Kisi;

                if (secilenKisi != null)
                {
                    secilenKisi.Ad = txtAd.Text;
                    secilenKisi.Soyad = txtSoyad.Text;
                    secilenKisi.Tel = txtTel.Text;

                    LoadKisiler();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex > -1)
            {
                Kisi secilenKisi = lstKisiler.SelectedItem as Kisi;

                if (secilenKisi != null)
                {
                    DialogResult result = MessageBox.Show(secilenKisi.ToString() + " adlı kişi silinsin mi?", "Kişi Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        Kisiler.Remove(secilenKisi);
                    }

                }

            }
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex > -1)
            {
                Kisi secilenKisi = lstKisiler.SelectedItem as Kisi;

                if (secilenKisi != null)
                {
                    txtAd.Text = secilenKisi.Ad;
                    txtSoyad.Text = secilenKisi.Soyad;
                    txtTel.Text = secilenKisi.Tel;
                }
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string metin = txtArama.Text.ToLower();

            if (string.IsNullOrEmpty(metin) == false)
            {
                // Aranılan metin var.
                grpGuncelle.Enabled = false;
            }
            else
            {
                // Aranılan metin boş..
                grpGuncelle.Enabled = true;
                LoadKisiler();
                return;
            }

            List<Kisi> bulunanlar = null;

            if(rdbIcerir.Checked)
            {
                bulunanlar = (from kisi in Kisiler
                              where kisi.Ad.ToLower().Contains(metin) ||
                                kisi.Soyad.ToLower().Contains(metin)
                              orderby kisi.Ad, kisi.Soyad
                              select kisi).ToList();
            }
            else
            {
                bulunanlar = (from kisi in Kisiler
                              where kisi.ToString().ToLower().StartsWith(metin)
                              orderby kisi.Ad, kisi.Soyad
                              select kisi).ToList();
            }

            lstKisiler.Items.Clear();

            bulunanlar.ForEach(kisi => lstKisiler.Items.Add(kisi));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Wissen.SC501.Common.Tools.XmlSerialization ser = new Wissen.SC501.Common.Tools.XmlSerialization();

            string xml = ser.ToXML(Kisiler);

            File.WriteAllText(Application.StartupPath + "//data.xml", xml);
        }
    }
}
