using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
   
            DialogResult result=MessageBox.Show("Yeni müşteri eklemek istediğinize emin misiniz?","Yeni Müşteri",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes) 
            {
                MusteriEkle();

                bildirimcubugu = new NotifyIcon();
                bildirimcubugu.BalloonTipText = "Toplam müşteri kaydı:" +sanalDatabase.musteriler.Count.ToString();
                bildirimcubugu.BalloonTipTitle = "Müşteri Adet";
                bildirimcubugu.Visible = true;
                bildirimcubugu.Icon = SystemIcons.Information;
                bildirimcubugu.ShowBalloonTip(2000);

             
                lst_musteriler.DataSource = sanalDatabase.musteriler.ToList();
                EkranTemizle();
            }
        }

        private void EkranTemizle()
        {

           

            ((TextBox)((GroupBox)this.Controls["groupBox1"]).Controls["txt_ad"]).Text= string.Empty;

         
        }

        private void MusteriEkle()
        {
            
           
            Musteri M = new Musteri()
            {   
                ID=Guid.NewGuid(),         
                Ad=txt_ad.Text,
                Soyad=txt_soyad.Text,
                Email=txt_email.Text,
                Telefon=txt_tel.Text    
            };
            sanalDatabase.musteriler.Add(M);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onizleme onizleme = new Onizleme();
            ((TextBox)onizleme.Controls["txt_ad"]).Text = txt_ad.Text;
            ((TextBox)onizleme.Controls["txt_soyad"]).Text = txt_soyad.Text;
            ((TextBox)onizleme.Controls["txt_email"]).Text = txt_email.Text;
            ((TextBox)onizleme.Controls["txt_tel"]).Text = txt_tel.Text;
            onizleme.ShowDialog();
        }
    }
}
