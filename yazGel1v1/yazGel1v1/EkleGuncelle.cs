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
        string dosya_yolu = @"C:\ikveriTabani.txt";

        List<string> kullaniciAdiSifre = new List<string>();
        Liste.TreeListe agaclistesi = new TreeListe();
        public EkleGuncelle()
        {
            InitializeComponent();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            
            agaclistesi.ekle(kisiAdiText.Text, kisiAdresiText.Text, telefonText.Text,mailText.Text, dogumTarihiText.Text, yabanciDilText.Text,ehliyetText.Text,egitimBilgisiEkle(),isyeriEkle());

            kullaniciAdiSifre.Add(telefonText.Text);
            kullaniciAdiSifre.Add(sifreText.Text);
            KullaniciAdiDosyaIslemleri.kullaniciAdiSifreDosyayaYaz(kullaniciAdiSifre);
            File.Delete(dosya_yolu);
            agaclistesi.yazdir();
            MessageBox.Show("Kayit basarili!");

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
            agaclistesi.okut();
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
        private IsyeriBilgileriListesi isyeriEkle()
        {
            int i = 0;
            IsyeriBilgileriListesi liste = new IsyeriBilgileriListesi();
            while(isyeriBilgileriDataGrid.Rows[i].Cells[0].Value!= null)
            {
                liste.ekle(
                    isyeriBilgileriDataGrid.Rows[i].Cells[0].Value.ToString(),
                    isyeriBilgileriDataGrid.Rows[i].Cells[1].Value.ToString(),
                    isyeriBilgileriDataGrid.Rows[i].Cells[2].Value.ToString(),
                    isyeriBilgileriDataGrid.Rows[i].Cells[3].Value.ToString()
                    );
                i++;
            }

            return liste;
        }
        private EgitimBilgileriListe egitimBilgisiEkle()
        {
            EgitimBilgileriListe liste = new EgitimBilgileriListe();
            for(int i=0; i<egitimBilgisiDataGridEkle.Rows.Count-1; i++)
            {
                liste.ekle(
                    egitimBilgisiDataGridEkle.Rows[i].Cells[0].Value.ToString(),
                    egitimBilgisiDataGridEkle.Rows[i].Cells[1].Value.ToString(),
                    egitimBilgisiDataGridEkle.Rows[i].Cells[2].Value.ToString(),
                    egitimBilgisiDataGridEkle.Rows[i].Cells[3].Value.ToString(),
                    egitimBilgisiDataGridEkle.Rows[i].Cells[4].Value.ToString(),
                    egitimBilgisiDataGridEkle.Rows[i].Cells[5].Value.ToString()
                    );
            }
           
            return liste;
        }
        
        
    }
}
