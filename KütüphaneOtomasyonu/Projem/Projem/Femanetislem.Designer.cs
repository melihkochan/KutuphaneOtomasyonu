
namespace Projem
{
    partial class Femanetislem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Femanetislem));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_üye = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_yas = new System.Windows.Forms.TextBox();
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.grp_hesap = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kitapsayısı = new System.Windows.Forms.TextBox();
            this.txt_sayfasayısı = new System.Windows.Forms.TextBox();
            this.txt_yayınevi = new System.Windows.Forms.TextBox();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.txt_kitapadı = new System.Windows.Forms.TextBox();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_teslim = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_kitapsayı = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_kayıtlıkitapsayı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_üye.SuspendLayout();
            this.grp_hesap.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1274294423_network_save.png");
            this.ımageList1.Images.SetKeyName(1, "1274295160_Library.png");
            this.ımageList1.Images.SetKeyName(2, "1274296711_user-group-new.png");
            this.ımageList1.Images.SetKeyName(3, "1274296747_address-book-add.png");
            this.ımageList1.Images.SetKeyName(4, "1274296819_add_group.png");
            this.ımageList1.Images.SetKeyName(5, "1274297017_folder_black_library.png");
            this.ımageList1.Images.SetKeyName(6, "1274297206_file-manager.png");
            this.ımageList1.Images.SetKeyName(7, "1274297618_bookmark-go.png");
            this.ımageList1.Images.SetKeyName(8, "1274297683_button_cancel.png");
            this.ımageList1.Images.SetKeyName(9, "1274297831_search_user.png");
            this.ımageList1.Images.SetKeyName(10, "1274297881_icontexto-aurora-folders-searches.png");
            this.ımageList1.Images.SetKeyName(11, "1274298004_Floppy-64.png");
            this.ımageList1.Images.SetKeyName(12, "1274298242_package-purge.png");
            this.ımageList1.Images.SetKeyName(13, "1274298334_camera_test.png");
            this.ımageList1.Images.SetKeyName(14, "1274298457_kget.png");
            this.ımageList1.Images.SetKeyName(15, "1274298505_cancel.png");
            this.ımageList1.Images.SetKeyName(16, "1274298823_kdmconfig.png");
            this.ımageList1.Images.SetKeyName(17, "images.jpg");
            this.ımageList1.Images.SetKeyName(18, "sil.png");
            this.ımageList1.Images.SetKeyName(19, "dosyayi_geri_yukle.jpg");
            this.ımageList1.Images.SetKeyName(20, "yedek1.png");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bk";
            this.saveFileDialog1.Filter = "\"Backup (*.bk)|*.bk|All files (*.*)|*.*\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bk";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Backup (*.bk)|*.bk|All files (*.*)|*.*\"";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // grp_üye
            // 
            this.grp_üye.Controls.Add(this.label4);
            this.grp_üye.Controls.Add(this.label3);
            this.grp_üye.Controls.Add(this.label2);
            this.grp_üye.Controls.Add(this.label1);
            this.grp_üye.Controls.Add(this.txt_telefon);
            this.grp_üye.Controls.Add(this.txt_yas);
            this.grp_üye.Controls.Add(this.txt_adsoyad);
            this.grp_üye.Controls.Add(this.txt_tc);
            this.grp_üye.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.grp_üye.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grp_üye.Location = new System.Drawing.Point(23, 42);
            this.grp_üye.Name = "grp_üye";
            this.grp_üye.Size = new System.Drawing.Size(289, 191);
            this.grp_üye.TabIndex = 1;
            this.grp_üye.TabStop = false;
            this.grp_üye.Text = "Üye Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC ";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txt_telefon.Location = new System.Drawing.Point(140, 146);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(100, 30);
            this.txt_telefon.TabIndex = 3;
            this.txt_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefon_KeyPress);
            // 
            // txt_yas
            // 
            this.txt_yas.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txt_yas.Location = new System.Drawing.Point(140, 110);
            this.txt_yas.Name = "txt_yas";
            this.txt_yas.Size = new System.Drawing.Size(100, 30);
            this.txt_yas.TabIndex = 2;
            this.txt_yas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yas_KeyPress);
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txt_adsoyad.Location = new System.Drawing.Point(140, 74);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(100, 30);
            this.txt_adsoyad.TabIndex = 1;
            this.txt_adsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_adsoyad_KeyPress);
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txt_tc.Location = new System.Drawing.Point(140, 36);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(100, 30);
            this.txt_tc.TabIndex = 0;
            this.txt_tc.TextChanged += new System.EventHandler(this.txt_tc_TextChanged);
            this.txt_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tc_KeyPress);
            // 
            // grp_hesap
            // 
            this.grp_hesap.Controls.Add(this.label12);
            this.grp_hesap.Controls.Add(this.label11);
            this.grp_hesap.Controls.Add(this.dateTimePicker2);
            this.grp_hesap.Controls.Add(this.dateTimePicker1);
            this.grp_hesap.Controls.Add(this.label10);
            this.grp_hesap.Controls.Add(this.label9);
            this.grp_hesap.Controls.Add(this.label8);
            this.grp_hesap.Controls.Add(this.label7);
            this.grp_hesap.Controls.Add(this.label6);
            this.grp_hesap.Controls.Add(this.label5);
            this.grp_hesap.Controls.Add(this.txt_kitapsayısı);
            this.grp_hesap.Controls.Add(this.txt_sayfasayısı);
            this.grp_hesap.Controls.Add(this.txt_yayınevi);
            this.grp_hesap.Controls.Add(this.txt_yazar);
            this.grp_hesap.Controls.Add(this.txt_kitapadı);
            this.grp_hesap.Controls.Add(this.txt_barkod);
            this.grp_hesap.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.grp_hesap.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grp_hesap.Location = new System.Drawing.Point(23, 239);
            this.grp_hesap.Name = "grp_hesap";
            this.grp_hesap.Size = new System.Drawing.Size(289, 262);
            this.grp_hesap.TabIndex = 2;
            this.grp_hesap.TabStop = false;
            this.grp_hesap.Text = "Hesap Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "İade Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Teslim Tarihi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(166, 227);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Kitap Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sayfa Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Yayın Evi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yazarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kitap Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Barkod No";
            // 
            // txt_kitapsayısı
            // 
            this.txt_kitapsayısı.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapsayısı.Location = new System.Drawing.Point(166, 166);
            this.txt_kitapsayısı.Name = "txt_kitapsayısı";
            this.txt_kitapsayısı.Size = new System.Drawing.Size(100, 21);
            this.txt_kitapsayısı.TabIndex = 5;
            this.txt_kitapsayısı.Text = "1";
            this.txt_kitapsayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kitapsayısı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapsayısı_KeyPress);
            // 
            // txt_sayfasayısı
            // 
            this.txt_sayfasayısı.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sayfasayısı.Location = new System.Drawing.Point(166, 140);
            this.txt_sayfasayısı.Name = "txt_sayfasayısı";
            this.txt_sayfasayısı.Size = new System.Drawing.Size(100, 21);
            this.txt_sayfasayısı.TabIndex = 4;
            this.txt_sayfasayısı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sayfasayısı_KeyPress);
            // 
            // txt_yayınevi
            // 
            this.txt_yayınevi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yayınevi.Location = new System.Drawing.Point(166, 112);
            this.txt_yayınevi.Name = "txt_yayınevi";
            this.txt_yayınevi.Size = new System.Drawing.Size(100, 21);
            this.txt_yayınevi.TabIndex = 3;
            this.txt_yayınevi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yayınevi_KeyPress);
            // 
            // txt_yazar
            // 
            this.txt_yazar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yazar.Location = new System.Drawing.Point(166, 86);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(100, 21);
            this.txt_yazar.TabIndex = 2;
            this.txt_yazar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yazar_KeyPress);
            // 
            // txt_kitapadı
            // 
            this.txt_kitapadı.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapadı.Location = new System.Drawing.Point(166, 62);
            this.txt_kitapadı.Name = "txt_kitapadı";
            this.txt_kitapadı.Size = new System.Drawing.Size(100, 21);
            this.txt_kitapadı.TabIndex = 1;
            this.txt_kitapadı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapadı_KeyPress);
            // 
            // txt_barkod
            // 
            this.txt_barkod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_barkod.Location = new System.Drawing.Point(166, 35);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(100, 21);
            this.txt_barkod.TabIndex = 0;
            this.txt_barkod.TextChanged += new System.EventHandler(this.txt_barkod_TextChanged);
            this.txt_barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_barkod_KeyPress);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.White;
            this.btn_ekle.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btn_ekle.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.ImageIndex = 11;
            this.btn_ekle.ImageList = this.ımageList1;
            this.btn_ekle.Location = new System.Drawing.Point(135, 507);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(154, 47);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Kaydet";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_teslim
            // 
            this.btn_teslim.BackColor = System.Drawing.Color.White;
            this.btn_teslim.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btn_teslim.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_teslim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teslim.ImageIndex = 4;
            this.btn_teslim.ImageList = this.ımageList1;
            this.btn_teslim.Location = new System.Drawing.Point(693, 455);
            this.btn_teslim.Name = "btn_teslim";
            this.btn_teslim.Size = new System.Drawing.Size(155, 46);
            this.btn_teslim.TabIndex = 4;
            this.btn_teslim.Text = "Teslim Et";
            this.btn_teslim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teslim.UseVisualStyleBackColor = false;
            this.btn_teslim.Click += new System.EventHandler(this.btn_teslim_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.White;
            this.btn_iptal.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btn_iptal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iptal.ImageIndex = 18;
            this.btn_iptal.ImageList = this.ımageList1;
            this.btn_iptal.Location = new System.Drawing.Point(865, 455);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(103, 46);
            this.btn_iptal.TabIndex = 5;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.White;
            this.btn_sil.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btn_sil.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.ImageIndex = 15;
            this.btn_sil.ImageList = this.ımageList1;
            this.btn_sil.Location = new System.Drawing.Point(984, 455);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(69, 46);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "Sil";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(390, 497);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 21);
            this.label15.TabIndex = 9;
            this.label15.Text = "Kitap Sayısı";
            // 
            // lbl_kitapsayı
            // 
            this.lbl_kitapsayı.AutoSize = true;
            this.lbl_kitapsayı.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_kitapsayı.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_kitapsayı.Location = new System.Drawing.Point(506, 503);
            this.lbl_kitapsayı.Name = "lbl_kitapsayı";
            this.lbl_kitapsayı.Size = new System.Drawing.Size(0, 21);
            this.lbl_kitapsayı.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(342, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 21);
            this.label13.TabIndex = 7;
            this.label13.Text = "Kayıtlı Kitap Sayısı";
            // 
            // lbl_kayıtlıkitapsayı
            // 
            this.lbl_kayıtlıkitapsayı.AutoSize = true;
            this.lbl_kayıtlıkitapsayı.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_kayıtlıkitapsayı.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_kayıtlıkitapsayı.Location = new System.Drawing.Point(506, 462);
            this.lbl_kayıtlıkitapsayı.Name = "lbl_kayıtlıkitapsayı";
            this.lbl_kayıtlıkitapsayı.Size = new System.Drawing.Size(0, 21);
            this.lbl_kayıtlıkitapsayı.TabIndex = 8;
            // 
            // Femanetislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 566);
            this.Controls.Add(this.lbl_kitapsayı);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl_kayıtlıkitapsayı);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_teslim);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.grp_hesap);
            this.Controls.Add(this.grp_üye);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Femanetislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap İşlemleri";
            this.Load += new System.EventHandler(this.Flogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_üye.ResumeLayout(false);
            this.grp_üye.PerformLayout();
            this.grp_hesap.ResumeLayout(false);
            this.grp_hesap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grp_üye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_yas;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.GroupBox grp_hesap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kitapsayısı;
        private System.Windows.Forms.TextBox txt_sayfasayısı;
        private System.Windows.Forms.TextBox txt_yayınevi;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.TextBox txt_kitapadı;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_teslim;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_kitapsayı;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_kayıtlıkitapsayı;
    }
}

