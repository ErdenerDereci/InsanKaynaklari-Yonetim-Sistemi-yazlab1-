using System;
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
        public EkleGuncelle()
        {
            InitializeComponent();
        }
        private void kaydet_Click(object sender, EventArgs e)
        {
            if (hucreKontrol(egitimBilgisiDataGridEkle))
            {
                MessageBox.Show("Ilgili alanlari doldurun!");
            } else if (hucreKontrol(isyeriBilgileriDataGrid))
            {
                MessageBox.Show("Ilgili alanlari doldurun!");
            } else if (textboxKontrol())
            {
                MessageBox.Show("Ilgili alanlari doldurun!");
            } else if (sifreKontrol())
            {
                MessageBox.Show("Sifreler eslesmiyor.");
            }else if (egitimBilgisiDataGridEkle.Rows.Count == 1)
            {
                MessageBox.Show("Egitim bilgisi eklemek zorunludur!!!");
            }
            else
            {
                if (kullaniciAdiLabel.Text == "-")
                {
                    if (KullaniciAdiDosyaIslemleri.telefonKontrol(telefonText.Text))
                    {
                        MessageBox.Show("Bu telefon numarasi zaten kayitli");
                    }
                    else
                    {
                        AgacListesiStaticClass.agaclistesi.ekle(kisiAdiText.Text, kisiAdresiText.Text, telefonText.Text, mailText.Text, dogumTarihiText.Text, yabanciDilText.Text, ehliyetText.Text, egitimBilgisiEkle(), isyeriEkle());
                        KullaniciAdiDosyaIslemleri.kullaniciAdiSifreEkle(telefonText.Text, sifreText.Text);
                        AgacListesiStaticClass.agaclistesi.textiGuncelle();

                        MessageBox.Show("Kayit basarili!");
                        this.Close();
                    }
                    
                }
                else
                {
                    AgacListesiStaticClass.agaclistesi.delete(AgacListesiStaticClass.kisiAdi, kullaniciAdiLabel.Text);
                    AgacListesiStaticClass.agaclistesi.ekle(kisiAdiText.Text, kisiAdresiText.Text, telefonText.Text, mailText.Text, dogumTarihiText.Text, yabanciDilText.Text, ehliyetText.Text, egitimBilgisiEkle(), isyeriEkle());
                    AgacListesiStaticClass.agaclistesi.textiGuncelle();
                    AgacListesiStaticClass.telefonNo = telefonText.Text;
                    KullaniciAdiDosyaIslemleri.kullaniciAdiGuncelle(kullaniciAdiLabel.Text, telefonText.Text);
                    KullaniciAdiDosyaIslemleri.sifreGuncelle(telefonText.Text,sifreText.Text);
                    MessageBox.Show("Guncelleme basarili!");
                    this.Close();



                }
            }
            
        }
        private bool sifreKontrol()
        {
            if (sifreTekrarText.Text == sifreText.Text)
            {
                return false;
            }
            return true;
        }
        private void EkleGuncelle_Load(object sender, EventArgs e)
        {
            if (AgacListesiStaticClass.sart == "1")
            {
                verileriArayuzeBas();
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

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
            AgacListesiStaticClass.agaclistesi.filtrelemeFonksiyonu(AgacListesiStaticClass.telefonNo,"telefon","inOrder");
            Liste.TreeNode node = AgacListesiStaticClass.agaclistesi.cekilecekNode;

            sifreText.Text = KullaniciAdiDosyaIslemleri.sifreBul(node.kisiTelefonu);
            sifreTekrarText.Text = sifreText.Text;
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
                    node.kisiEgitimListesi.egitimListesiDugum(i).okulAdi,
                    node.kisiEgitimListesi.egitimListesiDugum(i).okulturu,
                    node.kisiEgitimListesi.egitimListesiDugum(i).bolum,
                    node.kisiEgitimListesi.egitimListesiDugum(i).baslangicTarihi,
                    node.kisiEgitimListesi.egitimListesiDugum(i).bitisTarihi,
                    node.kisiEgitimListesi.egitimListesiDugum(i).notOrtalamasi
                    );
            }
            for (int i = 0; i < node.kisiIsyeriBilgileriListesi.count(); i++)
            {
                isyeriBilgileriDataGrid.Rows.Add(
                    node.kisiIsyeriBilgileriListesi.isyeribilgileriDugum(i).isyeriAdi,
                    node.kisiIsyeriBilgileriListesi.isyeribilgileriDugum(i).isyeriAdresi,
                    node.kisiIsyeriBilgileriListesi.isyeribilgileriDugum(i).gorevi,
                    node.kisiIsyeriBilgileriListesi.isyeribilgileriDugum(i).suresi

                    );
            }
        }
       
        private bool hucreKontrol(DataGridView datagrid)
        {
            int sayac1;
            int sayac2;
            for (int i = 0; i < datagrid.Rows.Count; i++)
            {
                sayac1 = 0;
                sayac2 = 0;
                for (int j=0; j<datagrid.Columns.Count; j++)
                {
                    if (datagrid.Rows[i].Cells[j].Value == null)
                    {
                        sayac1++;
                    }
                    if(datagrid.Rows[i].Cells[j].Value != null)
                    {
                        sayac2++;
                    }
                }

                if(sayac1!=0 && sayac2 != 0)
                {
                    return true;
                }
                
            }
            return false;
        }
        private bool textboxKontrol()
        {
            if (
                sifreText.Text=="" ||
                sifreTekrarText.Text == "" ||
                kisiAdiText.Text == "" ||
                kisiAdresiText.Text == "" ||
                telefonText.Text == "" || 
                dogumTarihiText.Text == "" ||
                mailText.Text == "" ||
                ehliyetText.Text == "")
            {
                return true;
            }
            return false;
        }
        

        
    }
}
