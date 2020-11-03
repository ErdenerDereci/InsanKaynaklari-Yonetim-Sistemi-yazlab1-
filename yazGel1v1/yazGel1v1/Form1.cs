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
       
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AgacListesiStaticClass.agaclistesi.okut();


        }

        private void giris_Click(object sender, EventArgs e)
        {

            if (kontrolEt())
            {
                CalisanArayuzu form = new CalisanArayuzu();
                AgacListesiStaticClass.telefonNo = kullaniciAdi.Text;
                form.ShowDialog();  
            }
            else
            {
                MessageBox.Show("Kullanici adi sifre hatali");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgacListesiStaticClass.sart = "0";
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
    }
}
