/****************************************************************************
**				       	 SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje Ödevi
**				ÖĞRENCİ ADI............: Alaattin Gökmen Kuleyin
**				ÖĞRENCİ NUMARASI.......: G191210054
**              DERSİN ALINDIĞI GRUP...: 2A
**
****************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace g191210054
{
    public partial class Form1 : Form
    {
        
        int kalansure = 60;
        private static readonly Random Random = new Random();
        private int rastgele;
        private readonly Oyun _oyun = new Oyun();
        private int Puan;

        public int BosaltmaPuani { get; set; }

        public Form1()
        {
            InitializeComponent();
            button1.Text = "YENİ OYUN";
            button2.Text = "ÇIKIŞ";
            label1.Text = "SÜRE";
            label2.Text = "PUAN";
            label3.Text = "ATIK KUTULARI";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            _oyun.KalanSureDegisti += Oyun_KalanSureDegisti;
            progressBar1.Maximum = 700;
            progressBar2.Maximum = 1200;
            progressBar3.Maximum = 2200;
            progressBar4.Maximum = 2300;
            
        }
        
        //Oyunu bitirme butonu.
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Oyunu başlatma butonu.
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            _oyun.Baslat();
            ResimDegistir();
            puanlabel.Text = Puan + "";
        }
        //Oyunda kalan süreyi sürekli ayarlayan kod.
        private void Oyun_KalanSureDegisti(object sender, EventArgs e)
        {
            if (kalansure > 0)
            {
                kalansure -= 1;
                surelabel.Text = kalansure + " ";
            }

            if (kalansure == 0)
            {
                button1.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                _oyun.Bitir();
            }
        }
        
        

        //Rastgele resim atayan kod.
        public void ResimDegistir()
        {
            rastgele=Random.Next(1,9);
            

            if (rastgele==1)
            {
                pictureBox1.Image = Image.FromFile(@"gorseller\cambardagi.jpg");  
            }
            else if(rastgele==2)
            {
                pictureBox1.Image = Image.FromFile(@"gorseller\gazete.jpg");
            }
            else if (rastgele == 3)
            {
                pictureBox1.Image = Image.FromFile(@"gorseller\dergi.jpg");
            }
            else if (rastgele == 4)
            {
                pictureBox1.Image = Image.FromFile(@"gorseller\camsise.jpg");
            }
            else if (rastgele == 5)
            {
                pictureBox1.Image = Image.FromFile(@"gorseller\domates.jpg");
            }
            else if (rastgele == 6)
            {
                pictureBox1.Image = Image.FromFile(@"gorseller\salcakutusu.jpg");

            }
            else if (rastgele == 7)
            {
                pictureBox1.Image = Image.FromFile(@"gorseller\salatalik.jpg");
            }
            else if (rastgele == 8)
            {
                pictureBox1.Image = Image.FromFile(@"gorseller\kolakutusu.jpg");
            }
            puanlabel.Text = Puan + "";
            
        }
        //ORGANİK ATIK BUTONU
        private void button7_Click(object sender, EventArgs e)
        {
            if (rastgele==5||rastgele==7)
            {
               if (rastgele == 5 && progressBar1.Value+150<progressBar1.Maximum)
                { 
                    
                    listBox1.Items.Add("Domates (150)");
                    Puan += 150;
                    progressBar1.Value += 150;
                    ResimDegistir();
                }
                else if(rastgele==7 &&progressBar1.Value+120<progressBar1.Maximum)
                {
                    listBox1.Items.Add("Salatalik(120)");
                    Puan += 120;
                    progressBar1.Value += 120;
                    ResimDegistir();
                }
                
            }
            
            
        }
        //KAĞIT ATIK BUTONU
        private void button8_Click(object sender, EventArgs e)
        {
            if (rastgele==2||rastgele==3)
            {
                if (rastgele == 2 && progressBar2.Value+250 <progressBar2.Maximum) 
                {
                    listBox2.Items.Add("Gazete(250)");
                    Puan += 250;
                    progressBar2.Value += 250;
                    ResimDegistir();
                }
                else if (rastgele==3 && progressBar2.Value+200 <progressBar2.Maximum)
                {
                    listBox2.Items.Add("Dergi(200)");
                    Puan += 200;
                    progressBar2.Value += 200;
                    ResimDegistir();
                }
            }
            
            
        }
        //CAM ATIK BUTONU
        private void button9_Click(object sender, EventArgs e)
        {
            if (rastgele==1||rastgele==4)
            {
                if (rastgele == 1 && progressBar4.Value+250 < progressBar4.Maximum) 
                {
                    listBox3.Items.Add("Bardak(250)");
                    Puan += 250;
                    progressBar3.Value += 250;
                    ResimDegistir();
                }
                else if(rastgele==4 && progressBar3.Value+600 <progressBar3.Maximum)
                {
                    listBox3.Items.Add("Cam Şişe(600)");
                    Puan += 600;
                    progressBar3.Value += 600;
                    ResimDegistir();
                }
                
            }
            
            
        }
        //METAL ATIK BUTONU
        private void Button10_Click(object sender, EventArgs e)
        {
            if (rastgele==6||rastgele==8)
            {
                if (rastgele == 6 && progressBar4.Value+550 <progressBar4.Maximum) 
                {
                    listBox4.Items.Add("SalçaKutusu(550)");
                    Puan += 550;
                    progressBar4.Value += 550;
                    ResimDegistir();
                }
                else if (rastgele==8 && progressBar4.Value+350 <progressBar4.Maximum)
                {
                    listBox4.Items.Add("Kola Kutusu(350)");
                    Puan += 350;
                    progressBar4.Value += 350;
                    ResimDegistir();
                }
                
            }
            
            
        }
        //ORGANİK ATIK BOŞALT BUTONU
        private void Button3_Click(object sender, EventArgs e)
        {
           
            if(progressBar1.Value>=progressBar1.Maximum*3/4)
            {
                kalansure += 3;
                progressBar1.Value = 0;
                listBox1.Items.Clear();
            }
            
            
        }
        //KAĞIT ATIK BOŞALT BUTONU
        private void button4_Click(object sender, EventArgs e)
        {
            if(progressBar2.Value>=progressBar2.Maximum*3/4)
            {
                BosaltmaPuani = 1000;
                Puan += BosaltmaPuani;
                puanlabel.Text = Puan + "";
                kalansure += 3;
                progressBar2.Value = 0;
                listBox2.Items.Clear();
            }
            
           
        }
        //CAM ATIK BOŞALT BUTONU
        private void button5_Click(object sender, EventArgs e)
        {
            if(progressBar3.Value>=progressBar3.Maximum*3/4)
            {
                BosaltmaPuani = 600;
                Puan += BosaltmaPuani;
                puanlabel.Text = Puan + "";
                kalansure += 3;
                progressBar3.Value = 0;
                listBox3.Items.Clear();
            }
            
            
        }
        //METAL ATIK BOŞALT BUTONU
        private void button6_Click(object sender, EventArgs e)
        {
            if(progressBar4.Value>=progressBar4.Maximum*3/4)
            {
                BosaltmaPuani = 800;
                Puan += BosaltmaPuani;
                puanlabel.Text = Puan + "";
                kalansure += 3;
                progressBar4.Value = 0;
                listBox4.Items.Clear();
            }
            
            
        }

       
    }
}