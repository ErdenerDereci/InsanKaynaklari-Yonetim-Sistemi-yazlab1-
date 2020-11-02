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
        
        string dosya_yolu = @"C:\ikveriTabani.txt";
        TreeListe agaclistesi = new TreeListe();
        List<string> kullaniciAdiSifre = new List<string>();
        public CalisanArayuzu()
        {
            InitializeComponent();
        }

        private void CalisanArayuzu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agaclistesi.okut();
            agaclistesi.delete(adiLabel.Text,telefonLabel.Text);
            File.Delete(dosya_yolu);
            agaclistesi.yazdir();

            
            KullaniciAdiDosyaIslemleri.kullaniciAdiSifreSil(kullaniciAdiSifre, telefonLabel.Text);

            MessageBox.Show("Sistemden cikildi!");
            this.Close();


        }
    }  
}
