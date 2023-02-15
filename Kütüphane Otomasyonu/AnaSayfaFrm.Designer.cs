namespace Kütüphane_Otomasyonu
{
    partial class AnaSayfaFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfaFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetIade = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUyeListele);
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(38, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(321, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeListele.ForeColor = System.Drawing.Color.Black;
            this.btnUyeListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeListele.ImageIndex = 3;
            this.btnUyeListele.ImageList = this.ımageList1;
            this.btnUyeListele.Location = new System.Drawing.Point(36, 69);
            this.btnUyeListele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(198, 38);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Üye Listeleme İşlemleri";
            this.btnUyeListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUyeListele.UseVisualStyleBackColor = true;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "uyeEkleForm.png");
            this.ımageList1.Images.SetKeyName(1, "kitapEkle.png");
            this.ımageList1.Images.SetKeyName(2, "kitaplarıGoruntule.png");
            this.ımageList1.Images.SetKeyName(3, "uyeIslemleri.png");
            this.ımageList1.Images.SetKeyName(4, "oduncVer.png");
            this.ımageList1.Images.SetKeyName(5, "oduncTakip.png");
            this.ımageList1.Images.SetKeyName(6, "oduncVerButon.png");
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEkle.ForeColor = System.Drawing.Color.Black;
            this.btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeEkle.ImageIndex = 0;
            this.btnUyeEkle.ImageList = this.ımageList1;
            this.btnUyeEkle.Location = new System.Drawing.Point(36, 25);
            this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(198, 36);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye Ekleme İşlemleri";
            this.btnUyeEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(808, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(330, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapListele.ForeColor = System.Drawing.Color.Black;
            this.btnKitapListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapListele.ImageIndex = 2;
            this.btnKitapListele.ImageList = this.ımageList1;
            this.btnKitapListele.Location = new System.Drawing.Point(45, 69);
            this.btnKitapListele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(209, 38);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ForeColor = System.Drawing.Color.Black;
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapEkle.ImageIndex = 1;
            this.btnKitapEkle.ImageList = this.ımageList1;
            this.btnKitapEkle.Location = new System.Drawing.Point(45, 20);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(209, 39);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnEmanetIade);
            this.groupBox3.Controls.Add(this.btnEmanetListele);
            this.groupBox3.Controls.Add(this.btnEmanetVer);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(421, 208);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(321, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnEmanetIade
            // 
            this.btnEmanetIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetIade.ForeColor = System.Drawing.Color.Black;
            this.btnEmanetIade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetIade.ImageIndex = 6;
            this.btnEmanetIade.ImageList = this.ımageList1;
            this.btnEmanetIade.Location = new System.Drawing.Point(36, 122);
            this.btnEmanetIade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmanetIade.Name = "btnEmanetIade";
            this.btnEmanetIade.Size = new System.Drawing.Size(261, 37);
            this.btnEmanetIade.TabIndex = 2;
            this.btnEmanetIade.Text = "Emanet Kitap İade İşlemleri";
            this.btnEmanetIade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetIade.UseVisualStyleBackColor = true;
            this.btnEmanetIade.Click += new System.EventHandler(this.btnEmanetIade_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetListele.ForeColor = System.Drawing.Color.Black;
            this.btnEmanetListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetListele.ImageIndex = 5;
            this.btnEmanetListele.ImageList = this.ımageList1;
            this.btnEmanetListele.Location = new System.Drawing.Point(36, 81);
            this.btnEmanetListele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(261, 35);
            this.btnEmanetListele.TabIndex = 1;
            this.btnEmanetListele.Text = "Emanet Kitap Listeleme İşlemleri";
            this.btnEmanetListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetListele.UseVisualStyleBackColor = true;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetVer.ForeColor = System.Drawing.Color.Black;
            this.btnEmanetVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetVer.ImageIndex = 4;
            this.btnEmanetVer.ImageList = this.ımageList1;
            this.btnEmanetVer.Location = new System.Drawing.Point(36, 36);
            this.btnEmanetVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(261, 39);
            this.btnEmanetVer.TabIndex = 0;
            this.btnEmanetVer.Text = "Emanet Kitap Verme İşlemleri";
            this.btnEmanetVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // AnaSayfaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::Kütüphane_Otomasyonu.Properties.Resources.john_morgan_VRQ7siT4U2U_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AnaSayfaFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaSayfaFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEmanetIade;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

