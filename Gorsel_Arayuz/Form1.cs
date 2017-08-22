using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Blob;
using OpenCvSharp.UserInterface;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Extensions;
using System.Diagnostics;

namespace Gorsel_Arayuz
{

    public partial class Form1 : Form
    {
        int resim_Adet = 0,track_val=0;
        int x = 0, y = 0;
        string kaynak_klasor;
        PictureBox[] k_resimler;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private Bitmap boyutlandır(Bitmap bmp)
        {
            int yeniEn, yeniBoy;
            double oran, hedefEn = 350, hedefBoy = 350, resimEn, resimBoy;

                resimEn = bmp.Width;
                resimBoy = bmp.Height;

                if (hedefEn / resimEn < hedefBoy / resimBoy)
                {
                    oran = hedefEn / resimEn;
                }
                else
                {
                    oran = hedefBoy / resimBoy;
                }

                yeniEn = Convert.ToInt32(oran * resimEn);
                yeniBoy = Convert.ToInt32(oran * resimBoy);
                bmp = new Bitmap(bmp, yeniEn, yeniBoy);
               
            
            return bmp;
        }

        private void p_click(object sender, EventArgs e)
        {
            track.Value = 0;
            track.Visible = false;
            Bitmap bmp = new Bitmap(((PictureBox)sender).ImageLocation);
            goster.SizeMode = PictureBoxSizeMode.AutoSize;
            goster.Image = boyutlandır(bmp);
            resimAd.Text = ((PictureBox)sender).ImageLocation.Split('\\').Last();
        }
        
        private void klasor_Click(object sender, EventArgs e)
        {
            
            string Dirpath;
              
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr != DialogResult.Cancel)
            {
                Dirpath = folderBrowserDialog1.SelectedPath;
                kaynak_klasor = Dirpath;
                klasor_getir(Dirpath);
                groupBoyut.Visible = true;
            }

        }

        private static bool yuz_Tespit(String resim)
        {
            Mat result;
            CascadeClassifier cascade = new CascadeClassifier("haarcascade_frontalface_alt2.xml");
            bool tespit = false;
            using (var src = new Mat(resim, LoadMode.Color))
            using (var gray = new Mat())
            {
                result = src.Clone();
                Cv2.CvtColor(src, gray, ColorConversion.BgrToGray, 0);

                // Detect faces
                Rect[] faces = cascade.DetectMultiScale(
                    gray, 1.08, 2, HaarDetectionType.ScaleImage, new OpenCvSharp.CPlusPlus.Size(30, 30));

                // Render all detected faces
                foreach (Rect face in faces)
                {
                    tespit = true;
                }
            }
            return tespit;
        }

        private void ayikla_Click(object sender, EventArgs e)
        {
            FrmAyikla frm2 = new FrmAyikla();
            frm2.progressBar1.Value = 0;
            frm2.progressBar1.Maximum = resim_Adet;
            frm2.Show();
            
            int insan = 0, manzara = 0;
            string kaynak, hedef;
            kaynak = k_resimler[0].ImageLocation;
            hedef=kaynak_klasor+"\\";
            Directory.CreateDirectory(hedef + "insan");
            Directory.CreateDirectory(hedef + "manzara");
            groupBox1.Visible = true;

            
            for (int i = 0; i < resim_Adet; i++)
            {
               
                kaynak = k_resimler[i].ImageLocation;
                hedef = kaynak.Remove((kaynak.Length - kaynak.Split('\\').Last().Length));
                if (yuz_Tespit(k_resimler[i].ImageLocation))
                {
                    //İnsan Klasörüne kopyalama

                    File.Copy(kaynak, hedef + "insan\\" + kaynak.Split('\\').Last());
                    insan++;
                }
                else
                {
                    //Manzara Klasörüne Kopyalama

                    File.Copy(kaynak, hedef + "manzara\\" + kaynak.Split('\\').Last());

                    manzara++;

                }
                frm2.progressBar1.Value += 1;
            }
            MessageBox.Show("İnsan Resmi Adedi :" + insan + " \n Manzara Resmi Adedi :" + manzara);
            frm2.Close();
           
            
        }

        private void c3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (c3.Checked==true)
            {
                c1.Checked = true;
                c2.Checked = true;
            }
            else
            {
                c1.Checked = false;
                c2.Checked = false;
            }
            
        }

        private void kutu_temizle()
        {
            goster.Image = Properties.Resources.csharp;
            goster.SizeMode = PictureBoxSizeMode.StretchImage;
            goster.Width = 411; goster.Height = 345;
            resimAd.Text = "";
            for (int i = 0; i < resim_Adet; i++)
            {
                panel1.Controls.Remove(k_resimler[i]);
            }
            resim_Adet = 0; x = 0; y = 0;
        }

        private void klasor_getir(string Dirpath)
        {
            kutu_temizle();
            string[] resimler = new string[100];

            string[] files = Directory.GetFiles(Dirpath, "*.Jpg");
            foreach (string file in files)
            {
                int pos = file.LastIndexOf("||");
                string FName = file.Substring(pos + 1);
                resimler[resim_Adet] = FName;
                resim_Adet++;
            }

            k_resimler = new PictureBox[resim_Adet];
            for (int i = 0; i < resim_Adet; i++)
            {


                k_resimler[i] = new PictureBox();
                k_resimler[i].Name = "isci-" + i.ToString();
                k_resimler[i].Location = new System.Drawing.Point(x, y);
                k_resimler[i].ImageLocation = resimler[i];
                k_resimler[i].Visible = true;
                k_resimler[i].BorderStyle = BorderStyle.Fixed3D;
                k_resimler[i].BackColor = Color.Transparent;
                k_resimler[i].Width = 70;
                k_resimler[i].Height = 70;
                k_resimler[i].SizeMode = PictureBoxSizeMode.StretchImage;
                k_resimler[i].BringToFront();
                panel1.Controls.Add(k_resimler[i]);
                k_resimler[i].MouseClick += new MouseEventHandler(p_click);

                x += 80;
            }
            goster.SizeMode = PictureBoxSizeMode.AutoSize;
            Bitmap bmp = new Bitmap(k_resimler[0].ImageLocation);
            goster.Image = boyutlandır(bmp);
            resimAd.Text = k_resimler[0].ImageLocation.Split('\\').Last();
        }

        private void c1_CheckedChanged(object sender, EventArgs e)
        {
            if (c1.Checked==true && c2.Checked==true)
            {
                c3.Checked = true;
                klasor_getir(kaynak_klasor);
            }
            else if (c1.Checked==true)
            {
               
                klasor_getir(kaynak_klasor + "\\insan");
            }
            else if (c2.Checked==true)
            {
               
                klasor_getir(kaynak_klasor + "\\manzara");
            }
            else
            {
                c3.Checked = false;
                kutu_temizle();
            }
        }

        private void c2_CheckedChanged(object sender, EventArgs e)
        {
            if (c1.Checked == true && c2.Checked == true)
            {
                c3.Checked = true;
                klasor_getir(kaynak_klasor);
            }
            else if (c1.Checked == true)
            {             
                klasor_getir(kaynak_klasor + "\\insan");
            }
            else if (c2.Checked == true)
            {
                klasor_getir(kaynak_klasor + "\\manzara");
            }
            else
            {
                kutu_temizle();
            }
        }

        private void track_Scroll(object sender, EventArgs e)
        {
            goster.SizeMode = PictureBoxSizeMode.StretchImage;
            if (track_val > track.Value)
            {
                goster.Width -= 20;
                goster.Height -= 20;
            }
            else if(track_val<track.Value)
            {
                goster.Width += 20;
                goster.Height += 20;
            }
            track_val = track.Value;
            wi.Text = goster.Width.ToString();
            he.Text = goster.Height.ToString();
            
        }

        private void buyutec_Click(object sender, EventArgs e)
        {
            if (track.Visible)
            {
                track.Visible = false;
            }
            else
            {
                track.Visible = true;
            }
            
        }

        private void ayarla_Click(object sender, EventArgs e)
        {
            goster.SizeMode = PictureBoxSizeMode.StretchImage;
            goster.Width = Convert.ToInt32(wi.Text);
            goster.Height = Convert.ToInt32(he.Text);
            wi.Text = "";
            he.Text = "";
        }


    }

}
