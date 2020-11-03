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
    public partial class CalisanArayuzu : Form
    {
        
       
       
        List<string> kullaniciAdiSifre = new List<string>();
        public CalisanArayuzu()
        {
            InitializeComponent();
        }

        private void CalisanArayuzu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void verileriSil_Click(object sender, EventArgs e)
        {
            
            AgacListesiStaticClass.agaclistesi.delete(adiLabel.Text,telefonLabel.Text);
            AgacListesiStaticClass.agaclistesi.textiGuncelle();

            
            KullaniciAdiDosyaIslemleri.kullaniciAdiSifreSil(kullaniciAdiSifre, telefonLabel.Text);

            MessageBox.Show("Sistemden cikildi!");
            this.Close();


        }

     
        private void kisiBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            this.Close();
            AgacListesiStaticClass.telefonNo = telefonLabel.Text;
            AgacListesiStaticClass.sart = "1";
            AgacListesiStaticClass.kisiAdi = adiLabel.Text;
            EkleGuncelle form = new EkleGuncelle();
            form.Show();
            
        }

        private void CalisanArayuzu_Load(object sender, EventArgs e)
        {
            verileriArayuzeBas();
        }
        private void verileriArayuzeBas()
        {
            AgacListesiStaticClass.agaclistesi.treeDugumDondur(AgacListesiStaticClass.telefonNo);
            Liste.TreeNode node = AgacListesiStaticClass.agaclistesi.cekilecekNode;

            adiLabel.Text = node.kisiAdiSoyadi;
            adresiLabel.Text = node.kisiAdresi;
            telefonLabel.Text = node.kisiTelefonu;
            dogumTarihiLabel.Text = node.kisiDogumTarihi;
            yabanciDilLabel.Text = node.kisiYabanciDil;
            mailLabel.Text = node.kisiMail;
            ehliyetLabel.Text = node.kisiEhliyet;

            for (int i = 0; i < node.kisiEgitimListesi.count(); i++)
            {
                egitimBilgisiDataGrid.Rows.Add(
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
