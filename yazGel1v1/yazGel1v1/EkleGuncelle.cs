﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Liste;
namespace yazGel1v1
{
    public partial class EkleGuncelle : Form
    {
        

        List<string> kullaniciAdiSifre = new List<string>();
        
        public EkleGuncelle()
        {
            InitializeComponent();
        }

        

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiLabel.Text == "-")
            {
               AgacListesiStaticClass.agaclistesi.ekle(kisiAdiText.Text, kisiAdresiText.Text, telefonText.Text, mailText.Text, dogumTarihiText.Text, yabanciDilText.Text, ehliyetText.Text, egitimBilgisiEkle(), isyeriEkle());

                kullaniciAdiSifre.Add(telefonText.Text);
                kullaniciAdiSifre.Add(sifreText.Text);
                KullaniciAdiDosyaIslemleri.kullaniciAdiSifreDosyayaYaz(kullaniciAdiSifre);
                AgacListesiStaticClass.agaclistesi.textiGuncelle();
                
                MessageBox.Show("Kayit basarili!");
            }else
            {
                AgacListesiStaticClass.agaclistesi.delete(AgacListesiStaticClass.kisiAdi,kullaniciAdiLabel.Text);
                AgacListesiStaticClass.agaclistesi.ekle(kisiAdiText.Text, kisiAdresiText.Text, telefonText.Text, mailText.Text, dogumTarihiText.Text, yabanciDilText.Text, ehliyetText.Text, egitimBilgisiEkle(), isyeriEkle());
                AgacListesiStaticClass.agaclistesi.textiGuncelle();
                AgacListesiStaticClass.telefonNo = telefonText.Text;
                
                MessageBox.Show("Guncelleme basarili!");
                this.Close();
                CalisanArayuzu form = new CalisanArayuzu();
                form.Show();
                
            }
            

        }
        public void kullaniciAdiSifreListeyeAt()
        {
            kullaniciAdiSifre.Clear();
            string dosya_yolu = @"C:\kullaniciAdiSifre.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                kullaniciAdiSifre.Add(yazi);
                yazi = sw.ReadLine();
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();

        }

        private void EkleGuncelle_Load(object sender, EventArgs e)
        {
            if (AgacListesiStaticClass.sart == "1")
            {
                verileriArayuzeBas();
            }
            else
            {
                isyeriBilgileriDataGrid.Rows[0].Cells[0].Value = 1;
                isyeriBilgileriDataGrid.Rows[0].Cells[1].Value = 1;
                isyeriBilgileriDataGrid.Rows[0].Cells[2].Value = 1;
                isyeriBilgileriDataGrid.Rows[0].Cells[3].Value = 1;

                egitimBilgisiDataGridEkle.Rows[0].Cells[0].Value = 1;
                egitimBilgisiDataGridEkle.Rows[0].Cells[1].Value = 1;
                egitimBilgisiDataGridEkle.Rows[0].Cells[2].Value = 1;
                egitimBilgisiDataGridEkle.Rows[0].Cells[3].Value = 1;
                egitimBilgisiDataGridEkle.Rows[0].Cells[4].Value = 1;
                egitimBilgisiDataGridEkle.Rows[0].Cells[5].Value = 1;
            }

            
        }
        private IsyeriBilgileriListesi isyeriEkle()
        {
            int i = 0;
            IsyeriBilgileriListesi liste = new IsyeriBilgileriListesi();
            while(true)
            {
                
                try
                {
                    if (isyeriBilgileriDataGrid.Rows[i].Cells[0].Value != null)
                    {
                        liste.ekle(
                        isyeriBilgileriDataGrid.Rows[i].Cells[0].Value.ToString(),
                        isyeriBilgileriDataGrid.Rows[i].Cells[1].Value.ToString(),
                        isyeriBilgileriDataGrid.Rows[i].Cells[2].Value.ToString(),
                        isyeriBilgileriDataGrid.Rows[i].Cells[3].Value.ToString()
                                  );
                        i++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                catch
                {
                    break;
                }
                
            }

            return liste;
        }
        private EgitimBilgileriListe egitimBilgisiEkle()
        {
            int i = 0;
            EgitimBilgileriListe liste = new EgitimBilgileriListe();
            while (true)
            {

                try
                {
                    if (egitimBilgisiDataGridEkle.Rows[i].Cells[0].Value != null)
                    {
                       liste.ekle(
                       egitimBilgisiDataGridEkle.Rows[i].Cells[0].Value.ToString(),
                       egitimBilgisiDataGridEkle.Rows[i].Cells[1].Value.ToString(),
                       egitimBilgisiDataGridEkle.Rows[i].Cells[2].Value.ToString(),
                       egitimBilgisiDataGridEkle.Rows[i].Cells[3].Value.ToString(),
                       egitimBilgisiDataGridEkle.Rows[i].Cells[4].Value.ToString(),
                       egitimBilgisiDataGridEkle.Rows[i].Cells[5].Value.ToString()
                                );

                       i++;
                    }
                    else
                    {
                        break;
                    }

                }
                catch
                {
                    break;
                }

            }
            return liste;
        }

        private void kisiAdiText_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressColorChange(kisiAdiText);
        }
        private void keyPressColorChange(TextBox textBox)
        {
            if (kullaniciAdiLabel.Text != "-")
            {
                textBox.ForeColor = Color.Red;
            }
        }

        private void dogumTarihiText_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressColorChange(dogumTarihiText);
        }

        private void telefonText_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressColorChange(telefonText);
        }

        private void yabanciDilText_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressColorChange(yabanciDilText);
        }

        private void kisiAdresiText_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressColorChange(kisiAdresiText);
        }

        private void mailText_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressColorChange(mailText);
        }

        private void ehliyetText_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressColorChange(ehliyetText);
        }

        private void sifreText_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressColorChange(sifreText);
        }

        private void sifreTekrarText_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressColorChange(sifreTekrarText);
        }
        private void verileriArayuzeBas()
        {
            AgacListesiStaticClass.agaclistesi.treeDugumDondur(AgacListesiStaticClass.telefonNo);
            Liste.TreeNode node = AgacListesiStaticClass.agaclistesi.cekilecekNode;

            
            kullaniciAdiLabel.Text = node.kisiTelefonu;
            kisiAdiText.Text = node.kisiAdiSoyadi;
            kisiAdresiText.Text = node.kisiAdresi;
            telefonText.Text = node.kisiTelefonu;
            dogumTarihiText.Text = node.kisiDogumTarihi;
            yabanciDilText.Text = node.kisiYabanciDil;
            mailText.Text = node.kisiMail;
            ehliyetText.Text = node.kisiEhliyet;

            for (int i = 0; i < node.kisiEgitimListesi.count(); i++)
            {
                egitimBilgisiDataGridEkle.Rows.Add(
                    node.kisiEgitimListesi.egitimListesi(i).okulAdi,
                    node.kisiEgitimListesi.egitimListesi(i).okulturu,
                    node.kisiEgitimListesi.egitimListesi(i).bolum,
                    node.kisiEgitimListesi.egitimListesi(i).baslangicTarihi,
                    node.kisiEgitimListesi.egitimListesi(i).bitisTarihi,
                    node.kisiEgitimListesi.egitimListesi(i).notOrtalamasi
                    );
            }
            for (int i = 0; i < node.kisiIsyeriBilgileriListesi.count(); i++)
            {
                isyeriBilgileriDataGrid.Rows.Add(
                    node.kisiIsyeriBilgileriListesi.isyeribilgileri(i).isyeriAdi,
                    node.kisiIsyeriBilgileriListesi.isyeribilgileri(i).isyeriAdresi,
                    node.kisiIsyeriBilgileriListesi.isyeribilgileri(i).gorevi,
                    node.kisiIsyeriBilgileriListesi.isyeribilgileri(i).suresi

                    );
            }
        }
    }
}
