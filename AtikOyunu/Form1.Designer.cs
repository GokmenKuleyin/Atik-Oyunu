namespace g191210054
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.surelabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.puanlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "YENİ OYUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 40);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "SÜRE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.surelabel);
            this.panel2.Location = new System.Drawing.Point(22, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 60);
            this.panel2.TabIndex = 3;
            // 
            // surelabel
            // 
            this.surelabel.AutoSize = true;
            this.surelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surelabel.Location = new System.Drawing.Point(77, 8);
            this.surelabel.Name = "surelabel";
            this.surelabel.Size = new System.Drawing.Size(64, 46);
            this.surelabel.TabIndex = 26;
            this.surelabel.Text = "60";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(10, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 40);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "PUAN";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.puanlabel);
            this.panel4.Location = new System.Drawing.Point(22, 456);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 58);
            this.panel4.TabIndex = 5;
            // 
            // puanlabel
            // 
            this.puanlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.puanlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanlabel.Location = new System.Drawing.Point(63, 2);
            this.puanlabel.Name = "puanlabel";
            this.puanlabel.Size = new System.Drawing.Size(93, 55);
            this.puanlabel.TabIndex = 30;
            this.puanlabel.Text = "0";
            this.puanlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(55, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "ATIK KUTULARI";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(316, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 68);
            this.panel5.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Navy;
            this.panel10.Controls.Add(this.button2);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Location = new System.Drawing.Point(12, 247);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(238, 339);
            this.panel10.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Info;
            this.progressBar1.Location = new System.Drawing.Point(316, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(186, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(508, 282);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(186, 23);
            this.progressBar2.TabIndex = 15;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(316, 520);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(186, 23);
            this.progressBar3.TabIndex = 16;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(508, 520);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(186, 23);
            this.progressBar4.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 26);
            this.button3.TabIndex = 18;
            this.button3.Text = "BOŞALT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(508, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 26);
            this.button4.TabIndex = 19;
            this.button4.Text = "BOŞALT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(316, 549);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 26);
            this.button5.TabIndex = 20;
            this.button5.Text = "BOŞALT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(508, 549);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 26);
            this.button6.TabIndex = 21;
            this.button6.Text = "BOŞALT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(316, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 116);
            this.listBox1.TabIndex = 22;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(508, 153);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(186, 116);
            this.listBox2.TabIndex = 23;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(316, 398);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(186, 116);
            this.listBox3.TabIndex = 24;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(508, 398);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(186, 116);
            this.listBox4.TabIndex = 25;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Navy;
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Location = new System.Drawing.Point(12, 12);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(238, 216);
            this.panel11.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.Info;
            this.button7.Location = new System.Drawing.Point(316, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 49);
            this.button7.TabIndex = 26;
            this.button7.Text = "ORGANİK ATIKLAR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.Info;
            this.button8.Location = new System.Drawing.Point(508, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(186, 49);
            this.button8.TabIndex = 27;
            this.button8.Text = "KAĞIT";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.SystemColors.Info;
            this.button9.Location = new System.Drawing.Point(316, 343);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(186, 49);
            this.button9.TabIndex = 28;
            this.button9.Text = "CAM";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.SystemColors.Info;
            this.button10.Location = new System.Drawing.Point(508, 343);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(186, 49);
            this.button10.TabIndex = 29;
            this.button10.Text = "METAL";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(305, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 574);
            this.panel6.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(729, 608);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label surelabel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label puanlabel;
        private System.Windows.Forms.Panel panel6;
    }
}

