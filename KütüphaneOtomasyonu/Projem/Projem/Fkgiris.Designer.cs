
namespace Projem
{
    partial class Fkgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fkgiris));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kad = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kaydet.png");
            this.ımageList1.Images.SetKeyName(1, "3.png");
            this.ımageList1.Images.SetKeyName(2, "4.png");
            this.ımageList1.Images.SetKeyName(3, "çöp kutusu.png");
            this.ımageList1.Images.SetKeyName(4, "güncelle.png");
            this.ımageList1.Images.SetKeyName(5, "iptal.png");
            this.ımageList1.Images.SetKeyName(6, "kaydet.png");
            this.ımageList1.Images.SetKeyName(7, "kgiriş.png");
            this.ımageList1.Images.SetKeyName(8, "pngegg.png");
            this.ımageList1.Images.SetKeyName(9, "pngwing.com.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(39, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giriş Ekranı";
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.BackColor = System.Drawing.Color.White;
            this.btn_kayıt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_kayıt.FlatAppearance.BorderSize = 5;
            this.btn_kayıt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_kayıt.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btn_kayıt.ForeColor = System.Drawing.Color.Red;
            this.btn_kayıt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayıt.ImageKey = "(yok)";
            this.btn_kayıt.ImageList = this.ımageList1;
            this.btn_kayıt.Location = new System.Drawing.Point(79, 340);
            this.btn_kayıt.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(115, 44);
            this.btn_kayıt.TabIndex = 13;
            this.btn_kayıt.Text = "Kayıt Ol";
            this.btn_kayıt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayıt.UseVisualStyleBackColor = false;
            this.btn_kayıt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projem.Properties.Resources.kgiriş;
            this.pictureBox1.Location = new System.Drawing.Point(63, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(45, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_kad
            // 
            this.txt_kad.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_kad.Location = new System.Drawing.Point(49, 203);
            this.txt_kad.Name = "txt_kad";
            this.txt_kad.Size = new System.Drawing.Size(171, 24);
            this.txt_kad.TabIndex = 9;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.White;
            this.btn_giris.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btn_giris.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_giris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_giris.ImageIndex = 0;
            this.btn_giris.ImageList = this.ımageList1;
            this.btn_giris.Location = new System.Drawing.Point(59, 297);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(155, 40);
            this.btn_giris.TabIndex = 11;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(45, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_sifre.Location = new System.Drawing.Point(49, 266);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(171, 24);
            this.txt_sifre.TabIndex = 10;
            // 
            // Fkgiris
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 424);
            this.Controls.Add(this.btn_kayıt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kad);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label3);
            this.Name = "Fkgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI GİRİŞ - KAYIT EKRANI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fkgiris_FormClosed);
            this.Load += new System.EventHandler(this.Fkgiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kad;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sifre;
    }
}