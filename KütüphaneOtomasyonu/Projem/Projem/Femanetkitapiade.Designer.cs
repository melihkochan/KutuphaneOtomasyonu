
namespace Projem
{
    partial class Femanetkitapiade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Femanetkitapiade));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnteslim = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btniptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttcara = new System.Windows.Forms.TextBox();
            this.txtbarkodara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnteslim
            // 
            this.btnteslim.BackColor = System.Drawing.Color.White;
            this.btnteslim.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnteslim.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnteslim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteslim.ImageIndex = 1;
            this.btnteslim.ImageList = this.ımageList1;
            this.btnteslim.Location = new System.Drawing.Point(221, 344);
            this.btnteslim.Name = "btnteslim";
            this.btnteslim.Size = new System.Drawing.Size(120, 51);
            this.btnteslim.TabIndex = 1;
            this.btnteslim.Text = "Teslim et";
            this.btnteslim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnteslim.UseVisualStyleBackColor = false;
            this.btnteslim.Click += new System.EventHandler(this.btnteslim_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "pngwing.com.png");
            this.ımageList1.Images.SetKeyName(1, "pngegg.png");
            this.ımageList1.Images.SetKeyName(2, "x.png");
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.White;
            this.btniptal.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btniptal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btniptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniptal.ImageIndex = 0;
            this.btniptal.ImageList = this.ımageList1;
            this.btniptal.Location = new System.Drawing.Point(347, 343);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(112, 52);
            this.btniptal.TabIndex = 2;
            this.btniptal.Text = "İptal";
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(116, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tc\'ye göre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(353, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod No\'ya göre";
            // 
            // txttcara
            // 
            this.txttcara.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txttcara.ForeColor = System.Drawing.Color.DarkBlue;
            this.txttcara.Location = new System.Drawing.Point(227, 39);
            this.txttcara.Name = "txttcara";
            this.txttcara.Size = new System.Drawing.Size(120, 30);
            this.txttcara.TabIndex = 5;
            this.txttcara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            this.txttcara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttcara_KeyPress);
            // 
            // txtbarkodara
            // 
            this.txtbarkodara.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtbarkodara.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtbarkodara.Location = new System.Drawing.Point(541, 44);
            this.txtbarkodara.Name = "txtbarkodara";
            this.txtbarkodara.Size = new System.Drawing.Size(120, 30);
            this.txtbarkodara.TabIndex = 6;
            this.txtbarkodara.TextChanged += new System.EventHandler(this.txtbarkodara_TextChanged);
            this.txtbarkodara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarkodara_KeyPress);
            // 
            // Femanetkitapiade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(774, 431);
            this.Controls.Add(this.txtbarkodara);
            this.Controls.Add(this.txttcara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnteslim);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Femanetkitapiade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap İade";
            this.Load += new System.EventHandler(this.Femanetkitapiade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnteslim;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttcara;
        private System.Windows.Forms.TextBox txtbarkodara;
    }
}