namespace Gorsel_Arayuz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.klasor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resimAd = new System.Windows.Forms.Label();
            this.ayikla = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.CheckBox();
            this.c3 = new System.Windows.Forms.CheckBox();
            this.c1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goster = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoyut = new System.Windows.Forms.GroupBox();
            this.track = new System.Windows.Forms.TrackBar();
            this.buyutec = new System.Windows.Forms.Button();
            this.ayarla = new System.Windows.Forms.Button();
            this.he = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track)).BeginInit();
            this.SuspendLayout();
            // 
            // klasor
            // 
            this.klasor.Location = new System.Drawing.Point(527, 38);
            this.klasor.Name = "klasor";
            this.klasor.Size = new System.Drawing.Size(96, 23);
            this.klasor.TabIndex = 1;
            this.klasor.Text = "Klasör Seç";
            this.klasor.UseVisualStyleBackColor = true;
            this.klasor.Click += new System.EventHandler(this.klasor_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 88);
            this.panel1.TabIndex = 2;
            // 
            // resimAd
            // 
            this.resimAd.AutoSize = true;
            this.resimAd.BackColor = System.Drawing.Color.Transparent;
            this.resimAd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimAd.Location = new System.Drawing.Point(18, 13);
            this.resimAd.Name = "resimAd";
            this.resimAd.Size = new System.Drawing.Size(0, 20);
            this.resimAd.TabIndex = 3;
            // 
            // ayikla
            // 
            this.ayikla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ayikla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ayikla.Location = new System.Drawing.Point(527, 78);
            this.ayikla.Name = "ayikla";
            this.ayikla.Size = new System.Drawing.Size(96, 23);
            this.ayikla.TabIndex = 4;
            this.ayikla.Text = "Resimleri Ayıkla";
            this.ayikla.UseVisualStyleBackColor = true;
            this.ayikla.Click += new System.EventHandler(this.ayikla_Click);
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Location = new System.Drawing.Point(40, 65);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(112, 17);
            this.c2.TabIndex = 8;
            this.c2.Text = "Manzara Resimleri";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.CheckedChanged += new System.EventHandler(this.c2_CheckedChanged);
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Location = new System.Drawing.Point(23, 19);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(90, 17);
            this.c3.TabIndex = 9;
            this.c3.Text = "Tüm Resimler";
            this.c3.UseVisualStyleBackColor = true;
            this.c3.CheckedChanged += new System.EventHandler(this.c3_CheckedChanged);
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Location = new System.Drawing.Point(40, 42);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(97, 17);
            this.c1.TabIndex = 7;
            this.c1.Text = "İnsan Resimleri";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.CheckedChanged += new System.EventHandler(this.c1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.c1);
            this.groupBox1.Controls.Add(this.c3);
            this.groupBox1.Controls.Add(this.c2);
            this.groupBox1.Location = new System.Drawing.Point(493, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Görüntülenicek Resimler";
            this.groupBox1.Visible = false;
            // 
            // goster
            // 
            this.goster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.goster.Image = global::Gorsel_Arayuz.Properties.Resources.csharp;
            this.goster.Location = new System.Drawing.Point(3, 2);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(411, 345);
            this.goster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goster.TabIndex = 0;
            this.goster.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.goster);
            this.panel2.Location = new System.Drawing.Point(12, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 399);
            this.panel2.TabIndex = 11;
            // 
            // groupBoyut
            // 
            this.groupBoyut.BackColor = System.Drawing.Color.Transparent;
            this.groupBoyut.Controls.Add(this.track);
            this.groupBoyut.Controls.Add(this.buyutec);
            this.groupBoyut.Controls.Add(this.ayarla);
            this.groupBoyut.Controls.Add(this.he);
            this.groupBoyut.Controls.Add(this.label2);
            this.groupBoyut.Controls.Add(this.wi);
            this.groupBoyut.Controls.Add(this.label1);
            this.groupBoyut.Location = new System.Drawing.Point(493, 129);
            this.groupBoyut.Name = "groupBoyut";
            this.groupBoyut.Size = new System.Drawing.Size(212, 132);
            this.groupBoyut.TabIndex = 12;
            this.groupBoyut.TabStop = false;
            this.groupBoyut.Text = "Boyutlandırma";
            this.groupBoyut.Visible = false;
            // 
            // track
            // 
            this.track.Location = new System.Drawing.Point(157, 19);
            this.track.Name = "track";
            this.track.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track.Size = new System.Drawing.Size(45, 104);
            this.track.TabIndex = 14;
            this.track.Visible = false;
            this.track.Scroll += new System.EventHandler(this.track_Scroll);
            // 
            // buyutec
            // 
            this.buyutec.Image = global::Gorsel_Arayuz.Properties.Resources.buyutec;
            this.buyutec.Location = new System.Drawing.Point(99, 30);
            this.buyutec.Name = "buyutec";
            this.buyutec.Size = new System.Drawing.Size(52, 50);
            this.buyutec.TabIndex = 13;
            this.buyutec.UseVisualStyleBackColor = true;
            this.buyutec.Click += new System.EventHandler(this.buyutec_Click);
            // 
            // ayarla
            // 
            this.ayarla.Location = new System.Drawing.Point(11, 82);
            this.ayarla.Name = "ayarla";
            this.ayarla.Size = new System.Drawing.Size(75, 23);
            this.ayarla.TabIndex = 4;
            this.ayarla.Text = "Ayarla";
            this.ayarla.UseVisualStyleBackColor = true;
            this.ayarla.Click += new System.EventHandler(this.ayarla_Click);
            // 
            // he
            // 
            this.he.Location = new System.Drawing.Point(29, 56);
            this.he.Name = "he";
            this.he.Size = new System.Drawing.Size(57, 20);
            this.he.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "H :";
            // 
            // wi
            // 
            this.wi.Location = new System.Drawing.Point(29, 30);
            this.wi.Name = "wi";
            this.wi.Size = new System.Drawing.Size(57, 20);
            this.wi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "W :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Gorsel_Arayuz.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(718, 541);
            this.Controls.Add(this.groupBoyut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ayikla);
            this.Controls.Add(this.resimAd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.klasor);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Yüz Tespit V1.0";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoyut.ResumeLayout(false);
            this.groupBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox goster;
        private System.Windows.Forms.Button klasor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resimAd;
        private System.Windows.Forms.Button ayikla;
        private System.Windows.Forms.CheckBox c2;
        private System.Windows.Forms.CheckBox c3;
        private System.Windows.Forms.CheckBox c1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoyut;
        private System.Windows.Forms.TrackBar track;
        private System.Windows.Forms.Button buyutec;
        private System.Windows.Forms.Button ayarla;
        private System.Windows.Forms.TextBox he;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wi;
        private System.Windows.Forms.Label label1;
    }
}

