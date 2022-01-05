
namespace Projem
{
    partial class Fdefault
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
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.btnSıralama = new System.Windows.Forms.Button();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.BackColor = System.Drawing.Color.White;
            this.btnEmanetListele.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEmanetListele.Location = new System.Drawing.Point(49, 102);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(210, 37);
            this.btnEmanetListele.TabIndex = 5;
            this.btnEmanetListele.Text = "Emanet Listele";
            this.btnEmanetListele.UseVisualStyleBackColor = false;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.BackColor = System.Drawing.Color.White;
            this.btnEmanetVer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEmanetVer.Location = new System.Drawing.Point(49, 48);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(210, 37);
            this.btnEmanetVer.TabIndex = 4;
            this.btnEmanetVer.Text = "Emanet Kitap İşlemleri";
            this.btnEmanetVer.UseVisualStyleBackColor = false;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // btnSıralama
            // 
            this.btnSıralama.BackColor = System.Drawing.Color.White;
            this.btnSıralama.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSıralama.Location = new System.Drawing.Point(49, 155);
            this.btnSıralama.Name = "btnSıralama";
            this.btnSıralama.Size = new System.Drawing.Size(210, 37);
            this.btnSıralama.TabIndex = 8;
            this.btnSıralama.Text = "Sıralama";
            this.btnSıralama.UseVisualStyleBackColor = false;
            this.btnSıralama.Click += new System.EventHandler(this.btnSıralama_Click_1);
            // 
            // btnGrafik
            // 
            this.btnGrafik.BackColor = System.Drawing.Color.White;
            this.btnGrafik.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGrafik.Location = new System.Drawing.Point(49, 207);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(210, 37);
            this.btnGrafik.TabIndex = 9;
            this.btnGrafik.Text = "Grafik";
            this.btnGrafik.UseVisualStyleBackColor = false;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "V2.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fdefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmanetVer);
            this.Controls.Add(this.btnEmanetListele);
            this.Controls.Add(this.btnGrafik);
            this.Controls.Add(this.btnSıralama);
            this.DoubleBuffered = true;
            this.Name = "Fdefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fdefault_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fdefault_FormClosed);
            this.Load += new System.EventHandler(this.Fdefault_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.Button btnSıralama;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Label label1;
    }
}