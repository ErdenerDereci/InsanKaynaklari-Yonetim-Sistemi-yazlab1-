using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Liste;
namespace yazGel1v1
{
    public partial class Form1 : Form
    {
        List<string> kullaniciAdiSifre = new List<string>();
        CalisanArayuzu form = new CalisanArayuzu();
        TreeListe agaclistesi = new TreeListe();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            agaclistesi.okut();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (kontrolEt())
            {
                CalisanArayuzu form = new CalisanArayuzu();
                verileriYolla(form);
                form.ShowDialog();
                
                
            }
            else
            {
                MessageBox.Show("Kullanici adi sifre hatali");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EkleGuncelle form = new EkleGuncelle();
            form.ShowDialog();
            
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
        public bool kontrolEt()
        {
            kullaniciAdiSifreListeyeAt();
            for (int i = 0; i < kullaniciAdiSifre.Count; i = i + 2){
                if(kullaniciAdi.Text==kullaniciAdiSifre[i] && sifre.Text== kullaniciAdiSifre[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        public void verileriYolla(CalisanArayuzu calisanArayuzu)
        {
            agaclistesi.treeDugumDondur(kullaniciAdi.Text);
            Liste.TreeNode node = agaclistesi.cekilecekNode;

            calisanArayuzu.adiLabel.Text = node.kisiAdiSoyadi;
            calisanArayuzu.adresiLabel.Text = node.kisiAdresi;
            calisanArayuzu.telefonLabel.Text = node.kisiTelefonu;
            calisanArayuzu.dogumTarihiLabel.Text = node.kisiDogumTarihi;
            calisanArayuzu.yabanciDilLabel.Text = node.kisiYabanciDil;
            calisanArayuzu.mailLabel.Text = node.kisiMail;
            calisanArayuzu.ehliyetLabel.Text = node.kisiEhliyet;

            for(int i =0; i<node.kisiEgitimListesi.count(); i++)
            {
                calisanArayuzu.egitimBilgisiDataGrid.Rows.Add(
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
                calisanArayuzu.isyeriBilgileriDataGrid.Rows.Add(
                    node.kisiIsyeriBilgileriListesi.isyeribilgileri(i).isyeriAdi,
                    node.kisiIsyeriBilgileriListesi.isyeribilgileri(i).isyeriAdresi,
                    node.kisiIsyeriBilgileriListesi.isyeribilgileri(i).gorevi,
                    node.kisiIsyeriBilgileriListesi.isyeribilgileri(i).suresi
                    
                    );
            }

        }
    }
}
