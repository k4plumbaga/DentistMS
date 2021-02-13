
using System;

namespace DentistMS
{
    partial class SecretaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretaryForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.girisTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.wellcomeLabel = new System.Windows.Forms.Label();
            this.tdbLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.calculateTabPage = new System.Windows.Forms.TabPage();
            this.toplamFiyatHesaplaButton = new System.Windows.Forms.Button();
            this.toplamFiyatLabel = new System.Windows.Forms.Label();
            this.tedavilerLabel = new System.Windows.Forms.Label();
            this.removeFromListButton = new System.Windows.Forms.Button();
            this.addToListButton = new System.Windows.Forms.Button();
            this.deselectButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.fiyatListBox = new System.Windows.Forms.ListBox();
            this.fiyatCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.rontgenTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resimSecButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yeniHastaTabPage = new System.Windows.Forms.TabPage();
            this.yeniKayıtGroupBox = new System.Windows.Forms.GroupBox();
            this.randevuSaatiLabel = new System.Windows.Forms.Label();
            this.randevuSaatiPicker = new System.Windows.Forms.DateTimePicker();
            this.randevuTarihiLabel = new System.Windows.Forms.Label();
            this.randevuGünüPicker = new System.Windows.Forms.DateTimePicker();
            this.sekreterLabel = new System.Windows.Forms.Label();
            this.sekreterlerComboBox = new System.Windows.Forms.ComboBox();
            this.doktorLabel = new System.Windows.Forms.Label();
            this.doktorlarComboBox = new System.Windows.Forms.ComboBox();
            this.kayıtButton = new System.Windows.Forms.Button();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.adresLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.adLabel = new System.Windows.Forms.Label();
            this.hastaKayıtlarıTabPage = new System.Windows.Forms.TabPage();
            this.sekreterSecComboBox = new System.Windows.Forms.ComboBox();
            this.sekreterSecLabel = new System.Windows.Forms.Label();
            this.doktorSecComboBox = new System.Windows.Forms.ComboBox();
            this.doktorSecLabel = new System.Windows.Forms.Label();
            this.tarihSecLabel = new System.Windows.Forms.Label();
            this.tariheGöreSıralaPicker = new System.Windows.Forms.DateTimePicker();
            this.selectedIndexDeletebutton = new System.Windows.Forms.Button();
            this.yenileButton = new System.Windows.Forms.Button();
            this.hastaKayıtlarıDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centuryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicSansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siyahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kırmızıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıSeçenekleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıtalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altıÇiziliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üstüÇiziliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.yeniToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yazdırToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yardımToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.strikeoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontSizeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.redToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.blueToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.blackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.greenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secretaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.girisTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.calculateTabPage.SuspendLayout();
            this.rontgenTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.yeniHastaTabPage.SuspendLayout();
            this.yeniKayıtGroupBox.SuspendLayout();
            this.hastaKayıtlarıTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayıtlarıDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.girisTabPage);
            this.tabControl1.Controls.Add(this.calculateTabPage);
            this.tabControl1.Controls.Add(this.rontgenTabPage);
            this.tabControl1.Controls.Add(this.yeniHastaTabPage);
            this.tabControl1.Controls.Add(this.hastaKayıtlarıTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1183, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // girisTabPage
            // 
            this.girisTabPage.Controls.Add(this.pictureBox2);
            this.girisTabPage.Controls.Add(this.wellcomeLabel);
            this.girisTabPage.Controls.Add(this.tdbLinkLabel);
            this.girisTabPage.Controls.Add(this.dateLabel);
            this.girisTabPage.Location = new System.Drawing.Point(4, 30);
            this.girisTabPage.Margin = new System.Windows.Forms.Padding(5);
            this.girisTabPage.Name = "girisTabPage";
            this.girisTabPage.Padding = new System.Windows.Forms.Padding(5);
            this.girisTabPage.Size = new System.Drawing.Size(1175, 516);
            this.girisTabPage.TabIndex = 0;
            this.girisTabPage.Text = "Giriş";
            this.girisTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::DentistMS.Properties.Resources.teeth;
            this.pictureBox2.Location = new System.Drawing.Point(290, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(612, 349);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // wellcomeLabel
            // 
            this.wellcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wellcomeLabel.AutoSize = true;
            this.wellcomeLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wellcomeLabel.Location = new System.Drawing.Point(490, 5);
            this.wellcomeLabel.Name = "wellcomeLabel";
            this.wellcomeLabel.Size = new System.Drawing.Size(211, 40);
            this.wellcomeLabel.TabIndex = 3;
            this.wellcomeLabel.Text = "Hoş Geldiniz!";
            this.wellcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tdbLinkLabel
            // 
            this.tdbLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tdbLinkLabel.AutoSize = true;
            this.tdbLinkLabel.Location = new System.Drawing.Point(973, 490);
            this.tdbLinkLabel.Name = "tdbLinkLabel";
            this.tdbLinkLabel.Size = new System.Drawing.Size(199, 21);
            this.tdbLinkLabel.TabIndex = 2;
            this.tdbLinkLabel.TabStop = true;
            this.tdbLinkLabel.Text = "Türk Diş Hekimleri Birliği";
            this.tdbLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tdbLinkLabel_LinkClicked_1);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateLabel.Location = new System.Drawing.Point(5, 490);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 21);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Tarih";
            // 
            // calculateTabPage
            // 
            this.calculateTabPage.Controls.Add(this.toplamFiyatHesaplaButton);
            this.calculateTabPage.Controls.Add(this.toplamFiyatLabel);
            this.calculateTabPage.Controls.Add(this.tedavilerLabel);
            this.calculateTabPage.Controls.Add(this.removeFromListButton);
            this.calculateTabPage.Controls.Add(this.addToListButton);
            this.calculateTabPage.Controls.Add(this.deselectButton);
            this.calculateTabPage.Controls.Add(this.selectAllButton);
            this.calculateTabPage.Controls.Add(this.fiyatListBox);
            this.calculateTabPage.Controls.Add(this.fiyatCheckedListBox);
            this.calculateTabPage.Location = new System.Drawing.Point(4, 30);
            this.calculateTabPage.Margin = new System.Windows.Forms.Padding(5);
            this.calculateTabPage.Name = "calculateTabPage";
            this.calculateTabPage.Padding = new System.Windows.Forms.Padding(5);
            this.calculateTabPage.Size = new System.Drawing.Size(1175, 516);
            this.calculateTabPage.TabIndex = 1;
            this.calculateTabPage.Text = "Hesapla";
            this.calculateTabPage.UseVisualStyleBackColor = true;
            // 
            // toplamFiyatHesaplaButton
            // 
            this.toplamFiyatHesaplaButton.Location = new System.Drawing.Point(623, 258);
            this.toplamFiyatHesaplaButton.Name = "toplamFiyatHesaplaButton";
            this.toplamFiyatHesaplaButton.Size = new System.Drawing.Size(218, 58);
            this.toplamFiyatHesaplaButton.TabIndex = 8;
            this.toplamFiyatHesaplaButton.Text = "Toplam Hesapla";
            this.toplamFiyatHesaplaButton.UseVisualStyleBackColor = true;
            this.toplamFiyatHesaplaButton.Click += new System.EventHandler(this.toplamFiyatHesaplaButton_Click);
            // 
            // toplamFiyatLabel
            // 
            this.toplamFiyatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toplamFiyatLabel.AutoSize = true;
            this.toplamFiyatLabel.Location = new System.Drawing.Point(668, 338);
            this.toplamFiyatLabel.Name = "toplamFiyatLabel";
            this.toplamFiyatLabel.Size = new System.Drawing.Size(76, 21);
            this.toplamFiyatLabel.TabIndex = 7;
            this.toplamFiyatLabel.Text = "Toplam: ";
            // 
            // tedavilerLabel
            // 
            this.tedavilerLabel.AutoSize = true;
            this.tedavilerLabel.Location = new System.Drawing.Point(8, 9);
            this.tedavilerLabel.Name = "tedavilerLabel";
            this.tedavilerLabel.Size = new System.Drawing.Size(78, 21);
            this.tedavilerLabel.TabIndex = 6;
            this.tedavilerLabel.Text = "Tedaviler";
            // 
            // removeFromListButton
            // 
            this.removeFromListButton.Location = new System.Drawing.Point(623, 198);
            this.removeFromListButton.Name = "removeFromListButton";
            this.removeFromListButton.Size = new System.Drawing.Size(218, 54);
            this.removeFromListButton.TabIndex = 5;
            this.removeFromListButton.Text = "Listeden Kaldır";
            this.removeFromListButton.UseVisualStyleBackColor = true;
            this.removeFromListButton.Click += new System.EventHandler(this.removeFromListButton_Click);
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(623, 138);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(218, 54);
            this.addToListButton.TabIndex = 4;
            this.addToListButton.Text = "Listeye Ekle";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // deselectButton
            // 
            this.deselectButton.Location = new System.Drawing.Point(623, 78);
            this.deselectButton.Name = "deselectButton";
            this.deselectButton.Size = new System.Drawing.Size(218, 54);
            this.deselectButton.TabIndex = 3;
            this.deselectButton.Text = "Seçimleri Kaldır";
            this.deselectButton.UseVisualStyleBackColor = true;
            this.deselectButton.Click += new System.EventHandler(this.deselectButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(624, 18);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(218, 54);
            this.selectAllButton.TabIndex = 2;
            this.selectAllButton.Text = "Hepsini Seç";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // fiyatListBox
            // 
            this.fiyatListBox.FormattingEnabled = true;
            this.fiyatListBox.ItemHeight = 21;
            this.fiyatListBox.Location = new System.Drawing.Point(305, 18);
            this.fiyatListBox.Name = "fiyatListBox";
            this.fiyatListBox.Size = new System.Drawing.Size(312, 403);
            this.fiyatListBox.TabIndex = 1;
            // 
            // fiyatCheckedListBox
            // 
            this.fiyatCheckedListBox.FormattingEnabled = true;
            this.fiyatCheckedListBox.Items.AddRange(new object[] {
            "Diş çekme",
            "Dolgu",
            "Kanal Tedavisi",
            "Köprü",
            "Tel Tedavisi",
            "Protez",
            "Diş Taşı Temizliği",
            "Parlatma",
            "Diş Temizliği"});
            this.fiyatCheckedListBox.Location = new System.Drawing.Point(9, 33);
            this.fiyatCheckedListBox.Name = "fiyatCheckedListBox";
            this.fiyatCheckedListBox.Size = new System.Drawing.Size(290, 388);
            this.fiyatCheckedListBox.TabIndex = 0;
            // 
            // rontgenTabPage
            // 
            this.rontgenTabPage.AllowDrop = true;
            this.rontgenTabPage.AutoScroll = true;
            this.rontgenTabPage.Controls.Add(this.groupBox2);
            this.rontgenTabPage.Controls.Add(this.label1);
            this.rontgenTabPage.Controls.Add(this.listView1);
            this.rontgenTabPage.Controls.Add(this.groupBox1);
            this.rontgenTabPage.Controls.Add(this.pictureBox1);
            this.rontgenTabPage.Location = new System.Drawing.Point(4, 30);
            this.rontgenTabPage.Name = "rontgenTabPage";
            this.rontgenTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rontgenTabPage.Size = new System.Drawing.Size(1175, 516);
            this.rontgenTabPage.TabIndex = 2;
            this.rontgenTabPage.Text = "Röntgen";
            this.rontgenTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(394, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 437);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gösterim";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 157);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(67, 25);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Döşe";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 125);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 25);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Detaylı";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 93);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 25);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Liste";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Küçük Resim";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Büyük Resim";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kayıtlı Röntgen Dosyaları";
            // 
            // listView1
            // 
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.largeImageList;
            this.listView1.Location = new System.Drawing.Point(13, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 428);
            this.listView1.SmallImageList = this.smallImageList;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "largeImage.ico");
            this.largeImageList.Images.SetKeyName(1, "largeFolder.ico");
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "smallImage.ico");
            this.smallImageList.Images.SetKeyName(1, "smallFolder.ico");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resimSecButton);
            this.groupBox1.Location = new System.Drawing.Point(769, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosyalarım";
            // 
            // resimSecButton
            // 
            this.resimSecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resimSecButton.Location = new System.Drawing.Point(41, 157);
            this.resimSecButton.Name = "resimSecButton";
            this.resimSecButton.Size = new System.Drawing.Size(310, 39);
            this.resimSecButton.TabIndex = 0;
            this.resimSecButton.Text = "Bilgisayardan Resim Seç";
            this.resimSecButton.UseVisualStyleBackColor = true;
            this.resimSecButton.Click += new System.EventHandler(this.resimSecButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 468);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // yeniHastaTabPage
            // 
            this.yeniHastaTabPage.Controls.Add(this.yeniKayıtGroupBox);
            this.yeniHastaTabPage.Location = new System.Drawing.Point(4, 30);
            this.yeniHastaTabPage.Name = "yeniHastaTabPage";
            this.yeniHastaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.yeniHastaTabPage.Size = new System.Drawing.Size(1175, 516);
            this.yeniHastaTabPage.TabIndex = 6;
            this.yeniHastaTabPage.Text = "Yeni Hasta";
            this.yeniHastaTabPage.UseVisualStyleBackColor = true;
            // 
            // yeniKayıtGroupBox
            // 
            this.yeniKayıtGroupBox.BackColor = System.Drawing.Color.MistyRose;
            this.yeniKayıtGroupBox.Controls.Add(this.randevuSaatiLabel);
            this.yeniKayıtGroupBox.Controls.Add(this.randevuSaatiPicker);
            this.yeniKayıtGroupBox.Controls.Add(this.randevuTarihiLabel);
            this.yeniKayıtGroupBox.Controls.Add(this.randevuGünüPicker);
            this.yeniKayıtGroupBox.Controls.Add(this.sekreterLabel);
            this.yeniKayıtGroupBox.Controls.Add(this.sekreterlerComboBox);
            this.yeniKayıtGroupBox.Controls.Add(this.doktorLabel);
            this.yeniKayıtGroupBox.Controls.Add(this.doktorlarComboBox);
            this.yeniKayıtGroupBox.Controls.Add(this.kayıtButton);
            this.yeniKayıtGroupBox.Controls.Add(this.soyadTextBox);
            this.yeniKayıtGroupBox.Controls.Add(this.phoneTextBox);
            this.yeniKayıtGroupBox.Controls.Add(this.emailTextBox);
            this.yeniKayıtGroupBox.Controls.Add(this.addressTextBox);
            this.yeniKayıtGroupBox.Controls.Add(this.adTextBox);
            this.yeniKayıtGroupBox.Controls.Add(this.adresLabel);
            this.yeniKayıtGroupBox.Controls.Add(this.emailLabel);
            this.yeniKayıtGroupBox.Controls.Add(this.phoneLabel);
            this.yeniKayıtGroupBox.Controls.Add(this.soyadLabel);
            this.yeniKayıtGroupBox.Controls.Add(this.adLabel);
            this.yeniKayıtGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yeniKayıtGroupBox.Location = new System.Drawing.Point(3, 3);
            this.yeniKayıtGroupBox.Name = "yeniKayıtGroupBox";
            this.yeniKayıtGroupBox.Size = new System.Drawing.Size(1169, 510);
            this.yeniKayıtGroupBox.TabIndex = 0;
            this.yeniKayıtGroupBox.TabStop = false;
            this.yeniKayıtGroupBox.Text = "Yeni Hasta Kaydı";
            // 
            // randevuSaatiLabel
            // 
            this.randevuSaatiLabel.AutoSize = true;
            this.randevuSaatiLabel.Location = new System.Drawing.Point(765, 339);
            this.randevuSaatiLabel.Name = "randevuSaatiLabel";
            this.randevuSaatiLabel.Size = new System.Drawing.Size(117, 21);
            this.randevuSaatiLabel.TabIndex = 18;
            this.randevuSaatiLabel.Text = "Randevu Saati";
            // 
            // randevuSaatiPicker
            // 
            this.randevuSaatiPicker.CustomFormat = "HH:mm";
            this.randevuSaatiPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.randevuSaatiPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.randevuSaatiPicker.Location = new System.Drawing.Point(769, 363);
            this.randevuSaatiPicker.Name = "randevuSaatiPicker";
            this.randevuSaatiPicker.ShowUpDown = true;
            this.randevuSaatiPicker.Size = new System.Drawing.Size(290, 29);
            this.randevuSaatiPicker.TabIndex = 17;
            // 
            // randevuTarihiLabel
            // 
            this.randevuTarihiLabel.AutoSize = true;
            this.randevuTarihiLabel.Location = new System.Drawing.Point(765, 247);
            this.randevuTarihiLabel.Name = "randevuTarihiLabel";
            this.randevuTarihiLabel.Size = new System.Drawing.Size(123, 21);
            this.randevuTarihiLabel.TabIndex = 16;
            this.randevuTarihiLabel.Text = "Randevu Tarihi";
            // 
            // randevuGünüPicker
            // 
            this.randevuGünüPicker.Location = new System.Drawing.Point(769, 271);
            this.randevuGünüPicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.randevuGünüPicker.MinDate = new System.DateTime(2021, 2, 8, 0, 0, 0, 0);
            this.randevuGünüPicker.Name = "randevuGünüPicker";
            this.randevuGünüPicker.Size = new System.Drawing.Size(290, 29);
            this.randevuGünüPicker.TabIndex = 15;
            // 
            // sekreterLabel
            // 
            this.sekreterLabel.AutoSize = true;
            this.sekreterLabel.Location = new System.Drawing.Point(769, 156);
            this.sekreterLabel.Name = "sekreterLabel";
            this.sekreterLabel.Size = new System.Drawing.Size(104, 21);
            this.sekreterLabel.TabIndex = 14;
            this.sekreterLabel.Text = "Sekreter Seç";
            // 
            // sekreterlerComboBox
            // 
            this.sekreterlerComboBox.FormattingEnabled = true;
            this.sekreterlerComboBox.Location = new System.Drawing.Point(769, 180);
            this.sekreterlerComboBox.Name = "sekreterlerComboBox";
            this.sekreterlerComboBox.Size = new System.Drawing.Size(290, 29);
            this.sekreterlerComboBox.TabIndex = 13;
            // 
            // doktorLabel
            // 
            this.doktorLabel.AutoSize = true;
            this.doktorLabel.Location = new System.Drawing.Point(769, 55);
            this.doktorLabel.Name = "doktorLabel";
            this.doktorLabel.Size = new System.Drawing.Size(96, 21);
            this.doktorLabel.TabIndex = 12;
            this.doktorLabel.Text = "Doktor Seç";
            // 
            // doktorlarComboBox
            // 
            this.doktorlarComboBox.FormattingEnabled = true;
            this.doktorlarComboBox.Location = new System.Drawing.Point(769, 79);
            this.doktorlarComboBox.Name = "doktorlarComboBox";
            this.doktorlarComboBox.Size = new System.Drawing.Size(290, 29);
            this.doktorlarComboBox.TabIndex = 11;
            // 
            // kayıtButton
            // 
            this.kayıtButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.kayıtButton.Location = new System.Drawing.Point(769, 421);
            this.kayıtButton.Name = "kayıtButton";
            this.kayıtButton.Size = new System.Drawing.Size(290, 83);
            this.kayıtButton.TabIndex = 10;
            this.kayıtButton.Text = "Kayıt Oluştur";
            this.kayıtButton.UseVisualStyleBackColor = false;
            this.kayıtButton.Click += new System.EventHandler(this.kayıtButton_Click);
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(364, 79);
            this.soyadTextBox.MaxLength = 50;
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(291, 29);
            this.soyadTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(15, 180);
            this.phoneTextBox.MaxLength = 11;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(291, 29);
            this.phoneTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(364, 180);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(291, 29);
            this.emailTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(15, 271);
            this.addressTextBox.MaxLength = 50;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(640, 121);
            this.addressTextBox.TabIndex = 6;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(15, 79);
            this.adTextBox.MaxLength = 50;
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(291, 29);
            this.adTextBox.TabIndex = 5;
            // 
            // adresLabel
            // 
            this.adresLabel.AutoSize = true;
            this.adresLabel.Location = new System.Drawing.Point(11, 247);
            this.adresLabel.Name = "adresLabel";
            this.adresLabel.Size = new System.Drawing.Size(55, 21);
            this.adresLabel.TabIndex = 4;
            this.adresLabel.Text = "Adres";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(360, 156);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(68, 21);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-posta";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(11, 156);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(143, 21);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Telefon Numarası";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Location = new System.Drawing.Point(360, 55);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(58, 21);
            this.soyadLabel.TabIndex = 1;
            this.soyadLabel.Text = "Soyad";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(11, 55);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(33, 21);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "Ad";
            // 
            // hastaKayıtlarıTabPage
            // 
            this.hastaKayıtlarıTabPage.Controls.Add(this.sekreterSecComboBox);
            this.hastaKayıtlarıTabPage.Controls.Add(this.sekreterSecLabel);
            this.hastaKayıtlarıTabPage.Controls.Add(this.doktorSecComboBox);
            this.hastaKayıtlarıTabPage.Controls.Add(this.doktorSecLabel);
            this.hastaKayıtlarıTabPage.Controls.Add(this.tarihSecLabel);
            this.hastaKayıtlarıTabPage.Controls.Add(this.tariheGöreSıralaPicker);
            this.hastaKayıtlarıTabPage.Controls.Add(this.selectedIndexDeletebutton);
            this.hastaKayıtlarıTabPage.Controls.Add(this.yenileButton);
            this.hastaKayıtlarıTabPage.Controls.Add(this.hastaKayıtlarıDataGridView);
            this.hastaKayıtlarıTabPage.Location = new System.Drawing.Point(4, 30);
            this.hastaKayıtlarıTabPage.Name = "hastaKayıtlarıTabPage";
            this.hastaKayıtlarıTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hastaKayıtlarıTabPage.Size = new System.Drawing.Size(1175, 516);
            this.hastaKayıtlarıTabPage.TabIndex = 7;
            this.hastaKayıtlarıTabPage.Text = "Hasta Kayıtları";
            this.hastaKayıtlarıTabPage.UseVisualStyleBackColor = true;
            // 
            // sekreterSecComboBox
            // 
            this.sekreterSecComboBox.FormattingEnabled = true;
            this.sekreterSecComboBox.Location = new System.Drawing.Point(1020, 277);
            this.sekreterSecComboBox.Name = "sekreterSecComboBox";
            this.sekreterSecComboBox.Size = new System.Drawing.Size(147, 29);
            this.sekreterSecComboBox.TabIndex = 8;
            this.sekreterSecComboBox.SelectedIndexChanged += new System.EventHandler(this.sekreterSecComboBox_SelectedIndexChanged);
            // 
            // sekreterSecLabel
            // 
            this.sekreterSecLabel.AutoSize = true;
            this.sekreterSecLabel.BackColor = System.Drawing.Color.DarkGray;
            this.sekreterSecLabel.Location = new System.Drawing.Point(1020, 252);
            this.sekreterSecLabel.Name = "sekreterSecLabel";
            this.sekreterSecLabel.Size = new System.Drawing.Size(104, 21);
            this.sekreterSecLabel.TabIndex = 7;
            this.sekreterSecLabel.Text = "Sekreter Seç";
            // 
            // doktorSecComboBox
            // 
            this.doktorSecComboBox.FormattingEnabled = true;
            this.doktorSecComboBox.Location = new System.Drawing.Point(1020, 200);
            this.doktorSecComboBox.Name = "doktorSecComboBox";
            this.doktorSecComboBox.Size = new System.Drawing.Size(147, 29);
            this.doktorSecComboBox.TabIndex = 6;
            this.doktorSecComboBox.SelectedIndexChanged += new System.EventHandler(this.doktorSecComboBox_SelectedIndexChanged);
            // 
            // doktorSecLabel
            // 
            this.doktorSecLabel.AutoSize = true;
            this.doktorSecLabel.BackColor = System.Drawing.Color.DarkGray;
            this.doktorSecLabel.Location = new System.Drawing.Point(1020, 176);
            this.doktorSecLabel.Name = "doktorSecLabel";
            this.doktorSecLabel.Size = new System.Drawing.Size(96, 21);
            this.doktorSecLabel.TabIndex = 5;
            this.doktorSecLabel.Text = "Doktor Seç";
            // 
            // tarihSecLabel
            // 
            this.tarihSecLabel.AutoSize = true;
            this.tarihSecLabel.BackColor = System.Drawing.Color.DarkGray;
            this.tarihSecLabel.Location = new System.Drawing.Point(1020, 103);
            this.tarihSecLabel.Name = "tarihSecLabel";
            this.tarihSecLabel.Size = new System.Drawing.Size(81, 21);
            this.tarihSecLabel.TabIndex = 4;
            this.tarihSecLabel.Text = "Tarih Seç";
            // 
            // tariheGöreSıralaPicker
            // 
            this.tariheGöreSıralaPicker.CustomFormat = "yyyy-MM-dd";
            this.tariheGöreSıralaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tariheGöreSıralaPicker.Location = new System.Drawing.Point(1020, 127);
            this.tariheGöreSıralaPicker.Name = "tariheGöreSıralaPicker";
            this.tariheGöreSıralaPicker.Size = new System.Drawing.Size(147, 29);
            this.tariheGöreSıralaPicker.TabIndex = 3;
            this.tariheGöreSıralaPicker.ValueChanged += new System.EventHandler(this.tariheGöreSıralaPicker_ValueChanged);
            // 
            // selectedIndexDeletebutton
            // 
            this.selectedIndexDeletebutton.Location = new System.Drawing.Point(1020, 49);
            this.selectedIndexDeletebutton.Name = "selectedIndexDeletebutton";
            this.selectedIndexDeletebutton.Size = new System.Drawing.Size(147, 37);
            this.selectedIndexDeletebutton.TabIndex = 2;
            this.selectedIndexDeletebutton.Text = "Seçili Hastayı Sil";
            this.selectedIndexDeletebutton.UseVisualStyleBackColor = true;
            this.selectedIndexDeletebutton.Click += new System.EventHandler(this.selectedIndexDeletebutton_Click);
            // 
            // yenileButton
            // 
            this.yenileButton.Location = new System.Drawing.Point(1020, 6);
            this.yenileButton.Name = "yenileButton";
            this.yenileButton.Size = new System.Drawing.Size(147, 37);
            this.yenileButton.TabIndex = 1;
            this.yenileButton.Text = "Listeyi Tazele";
            this.yenileButton.UseVisualStyleBackColor = true;
            this.yenileButton.Click += new System.EventHandler(this.yenileButton_Click);
            // 
            // hastaKayıtlarıDataGridView
            // 
            this.hastaKayıtlarıDataGridView.AllowUserToAddRows = false;
            this.hastaKayıtlarıDataGridView.AllowUserToDeleteRows = false;
            this.hastaKayıtlarıDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastaKayıtlarıDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hastaKayıtlarıDataGridView.Location = new System.Drawing.Point(3, 3);
            this.hastaKayıtlarıDataGridView.Name = "hastaKayıtlarıDataGridView";
            this.hastaKayıtlarıDataGridView.ReadOnly = true;
            this.hastaKayıtlarıDataGridView.Size = new System.Drawing.Size(1169, 510);
            this.hastaKayıtlarıDataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1183, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
            this.fileToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıTipiToolStripMenuItem,
            this.yazıRengiToolStripMenuItem,
            this.yazıSeçenekleriToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.editToolStripMenuItem.Text = "Düzenle";
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimesNewRomanToolStripMenuItem,
            this.arialToolStripMenuItem,
            this.centuryToolStripMenuItem,
            this.comicSansToolStripMenuItem});
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipleri";
            // 
            // TimesNewRomanToolStripMenuItem
            // 
            this.TimesNewRomanToolStripMenuItem.Checked = true;
            this.TimesNewRomanToolStripMenuItem.CheckOnClick = true;
            this.TimesNewRomanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TimesNewRomanToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimesNewRomanToolStripMenuItem.Name = "TimesNewRomanToolStripMenuItem";
            this.TimesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.TimesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.TimesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.TimesNewRomanToolStripMenuItem_Click);
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.CheckOnClick = true;
            this.arialToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.arialToolStripMenuItem.Text = "Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
            // 
            // centuryToolStripMenuItem
            // 
            this.centuryToolStripMenuItem.CheckOnClick = true;
            this.centuryToolStripMenuItem.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.centuryToolStripMenuItem.Name = "centuryToolStripMenuItem";
            this.centuryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.centuryToolStripMenuItem.Text = "Century";
            this.centuryToolStripMenuItem.Click += new System.EventHandler(this.centuryToolStripMenuItem_Click);
            // 
            // comicSansToolStripMenuItem
            // 
            this.comicSansToolStripMenuItem.CheckOnClick = true;
            this.comicSansToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comicSansToolStripMenuItem.Name = "comicSansToolStripMenuItem";
            this.comicSansToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.comicSansToolStripMenuItem.Text = "Comic Sans MS";
            this.comicSansToolStripMenuItem.Click += new System.EventHandler(this.comicSansToolStripMenuItem_Click);
            // 
            // yazıRengiToolStripMenuItem
            // 
            this.yazıRengiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siyahToolStripMenuItem,
            this.kırmızıToolStripMenuItem,
            this.maviToolStripMenuItem,
            this.yeşilToolStripMenuItem});
            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            // 
            // siyahToolStripMenuItem
            // 
            this.siyahToolStripMenuItem.Checked = true;
            this.siyahToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.siyahToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.siyahToolStripMenuItem.Name = "siyahToolStripMenuItem";
            this.siyahToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.siyahToolStripMenuItem.Text = "Siyah";
            this.siyahToolStripMenuItem.Click += new System.EventHandler(this.siyahToolStripMenuItem_Click);
            // 
            // kırmızıToolStripMenuItem
            // 
            this.kırmızıToolStripMenuItem.CheckOnClick = true;
            this.kırmızıToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.kırmızıToolStripMenuItem.Name = "kırmızıToolStripMenuItem";
            this.kırmızıToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kırmızıToolStripMenuItem.Text = "Kırmızı";
            this.kırmızıToolStripMenuItem.Click += new System.EventHandler(this.kırmızıToolStripMenuItem_Click);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.CheckOnClick = true;
            this.maviToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.CheckOnClick = true;
            this.yeşilToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // yazıSeçenekleriToolStripMenuItem
            // 
            this.yazıSeçenekleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalınToolStripMenuItem,
            this.ıtalicToolStripMenuItem,
            this.altıÇiziliToolStripMenuItem,
            this.üstüÇiziliToolStripMenuItem});
            this.yazıSeçenekleriToolStripMenuItem.Name = "yazıSeçenekleriToolStripMenuItem";
            this.yazıSeçenekleriToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.yazıSeçenekleriToolStripMenuItem.Text = "Yazı Seçenekleri";
            // 
            // kalınToolStripMenuItem
            // 
            this.kalınToolStripMenuItem.Name = "kalınToolStripMenuItem";
            this.kalınToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kalınToolStripMenuItem.Text = "Kalın";
            this.kalınToolStripMenuItem.Click += new System.EventHandler(this.kalınToolStripMenuItem_Click);
            // 
            // ıtalicToolStripMenuItem
            // 
            this.ıtalicToolStripMenuItem.Name = "ıtalicToolStripMenuItem";
            this.ıtalicToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ıtalicToolStripMenuItem.Text = "Italic";
            this.ıtalicToolStripMenuItem.Click += new System.EventHandler(this.ıtalicToolStripMenuItem_Click);
            // 
            // altıÇiziliToolStripMenuItem
            // 
            this.altıÇiziliToolStripMenuItem.Name = "altıÇiziliToolStripMenuItem";
            this.altıÇiziliToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.altıÇiziliToolStripMenuItem.Text = "Altı çizili";
            this.altıÇiziliToolStripMenuItem.Click += new System.EventHandler(this.altıÇiziliToolStripMenuItem_Click);
            // 
            // üstüÇiziliToolStripMenuItem
            // 
            this.üstüÇiziliToolStripMenuItem.Name = "üstüÇiziliToolStripMenuItem";
            this.üstüÇiziliToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.üstüÇiziliToolStripMenuItem.Text = "Üstü çizili";
            this.üstüÇiziliToolStripMenuItem.Click += new System.EventHandler(this.üstüÇiziliToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripButton,
            this.yazdırToolStripButton,
            this.yardımToolStripButton,
            this.toolStripSeparator,
            this.boldToolStripButton,
            this.italicToolStripButton,
            this.underlineToolStripButton,
            this.strikeoutToolStripButton,
            this.toolStripSeparator1,
            this.fontSizeToolStripComboBox,
            this.toolStripSeparator2,
            this.redToolStripButton,
            this.blueToolStripButton,
            this.blackToolStripButton,
            this.greenToolStripButton,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(761, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // yeniToolStripButton
            // 
            this.yeniToolStripButton.Image = global::DentistMS.Properties.Resources.new_file;
            this.yeniToolStripButton.Name = "yeniToolStripButton";
            this.yeniToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.yeniToolStripButton.Text = "Yeni";
            this.yeniToolStripButton.Click += new System.EventHandler(this.yeniToolStripButton_Click);
            // 
            // yazdırToolStripButton
            // 
            this.yazdırToolStripButton.Image = global::DentistMS.Properties.Resources.print;
            this.yazdırToolStripButton.Name = "yazdırToolStripButton";
            this.yazdırToolStripButton.Size = new System.Drawing.Size(58, 22);
            this.yazdırToolStripButton.Text = "Yazdır";
            this.yazdırToolStripButton.Click += new System.EventHandler(this.yazdırToolStripButton_Click);
            // 
            // yardımToolStripButton
            // 
            this.yardımToolStripButton.Image = global::DentistMS.Properties.Resources.help;
            this.yardımToolStripButton.Name = "yardımToolStripButton";
            this.yardımToolStripButton.Size = new System.Drawing.Size(64, 22);
            this.yardımToolStripButton.Text = "Yardım";
            this.yardımToolStripButton.Click += new System.EventHandler(this.yardımToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // boldToolStripButton
            // 
            this.boldToolStripButton.Image = global::DentistMS.Properties.Resources.bold;
            this.boldToolStripButton.Name = "boldToolStripButton";
            this.boldToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.boldToolStripButton.Text = "Kalın";
            this.boldToolStripButton.Click += new System.EventHandler(this.boldToolStripButton_Click);
            // 
            // italicToolStripButton
            // 
            this.italicToolStripButton.Image = global::DentistMS.Properties.Resources.italic;
            this.italicToolStripButton.Name = "italicToolStripButton";
            this.italicToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.italicToolStripButton.Text = "İtalik";
            this.italicToolStripButton.Click += new System.EventHandler(this.italicToolStripButton_Click);
            // 
            // underlineToolStripButton
            // 
            this.underlineToolStripButton.Image = global::DentistMS.Properties.Resources.underline;
            this.underlineToolStripButton.Name = "underlineToolStripButton";
            this.underlineToolStripButton.Size = new System.Drawing.Size(73, 22);
            this.underlineToolStripButton.Text = "Altı Çizili";
            this.underlineToolStripButton.Click += new System.EventHandler(this.underlineToolStripButton_Click);
            // 
            // strikeoutToolStripButton
            // 
            this.strikeoutToolStripButton.Image = global::DentistMS.Properties.Resources.strikethrough;
            this.strikeoutToolStripButton.Name = "strikeoutToolStripButton";
            this.strikeoutToolStripButton.Size = new System.Drawing.Size(79, 22);
            this.strikeoutToolStripButton.Text = "Üstü Çizili";
            this.strikeoutToolStripButton.Click += new System.EventHandler(this.strikeoutToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // fontSizeToolStripComboBox
            // 
            this.fontSizeToolStripComboBox.AccessibleName = "";
            this.fontSizeToolStripComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "14 pt"});
            this.fontSizeToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSizeToolStripComboBox.Items.AddRange(new object[] {
            "10 pt",
            "11 pt",
            "12 pt",
            "14 pt",
            "16 pt",
            "18 pt",
            "20 pt"});
            this.fontSizeToolStripComboBox.Name = "fontSizeToolStripComboBox";
            this.fontSizeToolStripComboBox.Size = new System.Drawing.Size(75, 25);
            this.fontSizeToolStripComboBox.Tag = "punto";
            this.fontSizeToolStripComboBox.ToolTipText = "Yazı Boyutu";
            this.fontSizeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeToolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // redToolStripButton
            // 
            this.redToolStripButton.Image = global::DentistMS.Properties.Resources.red;
            this.redToolStripButton.Name = "redToolStripButton";
            this.redToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.redToolStripButton.Text = "Kırmızı";
            this.redToolStripButton.Click += new System.EventHandler(this.redToolStripButton_Click);
            // 
            // blueToolStripButton
            // 
            this.blueToolStripButton.Image = global::DentistMS.Properties.Resources.blue;
            this.blueToolStripButton.Name = "blueToolStripButton";
            this.blueToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.blueToolStripButton.Text = "Mavi";
            this.blueToolStripButton.Click += new System.EventHandler(this.blueToolStripButton_Click);
            // 
            // blackToolStripButton
            // 
            this.blackToolStripButton.Image = global::DentistMS.Properties.Resources.black;
            this.blackToolStripButton.Name = "blackToolStripButton";
            this.blackToolStripButton.Size = new System.Drawing.Size(55, 22);
            this.blackToolStripButton.Text = "Siyah";
            this.blackToolStripButton.Click += new System.EventHandler(this.blackToolStripButton_Click);
            // 
            // greenToolStripButton
            // 
            this.greenToolStripButton.Image = global::DentistMS.Properties.Resources.green;
            this.greenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenToolStripButton.Name = "greenToolStripButton";
            this.greenToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.greenToolStripButton.Text = "Yeşil";
            this.greenToolStripButton.Click += new System.EventHandler(this.greenToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            // 
            // secretaryBindingSource
            // 
            this.secretaryBindingSource.DataMember = "Secretary";
            // 
            // dentistBindingSource
            // 
            this.dentistBindingSource.DataMember = "Dentist";
            // 
            // SecretaryForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1183, 602);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SecretaryForm";
            this.Text = "Diş Hekimliği Yönetim Programı";
            this.Load += new System.EventHandler(this.secretaryForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.girisTabPage.ResumeLayout(false);
            this.girisTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.calculateTabPage.ResumeLayout(false);
            this.calculateTabPage.PerformLayout();
            this.rontgenTabPage.ResumeLayout(false);
            this.rontgenTabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.yeniHastaTabPage.ResumeLayout(false);
            this.yeniKayıtGroupBox.ResumeLayout(false);
            this.yeniKayıtGroupBox.PerformLayout();
            this.hastaKayıtlarıTabPage.ResumeLayout(false);
            this.hastaKayıtlarıTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayıtlarıDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage girisTabPage;
        private System.Windows.Forms.TabPage calculateTabPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centuryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comicSansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siyahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kırmızıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ToolStripMenuItem yazıSeçenekleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalınToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıtalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altıÇiziliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üstüÇiziliToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton boldToolStripButton;
        private System.Windows.Forms.ToolStripButton italicToolStripButton;
        private System.Windows.Forms.ToolStripButton underlineToolStripButton;
        private System.Windows.Forms.ToolStripButton strikeoutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox fontSizeToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton redToolStripButton;
        private System.Windows.Forms.ToolStripButton blueToolStripButton;
        private System.Windows.Forms.ToolStripButton blackToolStripButton;
        private System.Windows.Forms.ToolStripButton greenToolStripButton;
        private System.Windows.Forms.ToolStripButton yeniToolStripButton;
        private System.Windows.Forms.ToolStripButton yazdırToolStripButton;
        private System.Windows.Forms.ToolStripButton yardımToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TabPage rontgenTabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resimSecButton;
        private System.Windows.Forms.LinkLabel tdbLinkLabel;
        private System.Windows.Forms.Label wellcomeLabel;
        private System.Windows.Forms.ListBox fiyatListBox;
        private System.Windows.Forms.CheckedListBox fiyatCheckedListBox;
        private System.Windows.Forms.Button removeFromListButton;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Button deselectButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Label tedavilerLabel;
        private System.Windows.Forms.Label toplamFiyatLabel;
        private System.Windows.Forms.Button toplamFiyatHesaplaButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource secretaryBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.BindingSource dentistBindingSource;
        private System.Windows.Forms.TabPage yeniHastaTabPage;
        private System.Windows.Forms.GroupBox yeniKayıtGroupBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.Label adresLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Button kayıtButton;
        private System.Windows.Forms.TabPage hastaKayıtlarıTabPage;
        private System.Windows.Forms.DataGridView hastaKayıtlarıDataGridView;
        private System.Windows.Forms.Button yenileButton;
        private System.Windows.Forms.ComboBox doktorlarComboBox;
        private System.Windows.Forms.Label doktorLabel;
        private System.Windows.Forms.Label sekreterLabel;
        private System.Windows.Forms.ComboBox sekreterlerComboBox;
        private System.Windows.Forms.Button selectedIndexDeletebutton;
        private System.Windows.Forms.Label randevuTarihiLabel;
        private System.Windows.Forms.DateTimePicker randevuGünüPicker;
        private System.Windows.Forms.DateTimePicker randevuSaatiPicker;
        private System.Windows.Forms.Label randevuSaatiLabel;
        private System.Windows.Forms.DateTimePicker tariheGöreSıralaPicker;
        private System.Windows.Forms.Label tarihSecLabel;
        private System.Windows.Forms.ComboBox sekreterSecComboBox;
        private System.Windows.Forms.Label sekreterSecLabel;
        private System.Windows.Forms.ComboBox doktorSecComboBox;
        private System.Windows.Forms.Label doktorSecLabel;
    }
}

