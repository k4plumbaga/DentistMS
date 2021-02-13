﻿using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DentistMS
{
    public partial class SecretaryForm : Form
    {
        private System.Collections.Specialized.StringCollection folderCol;

        public SecretaryForm()
        {
            InitializeComponent();
            this.dateLabel.Text = "Tarih: " + DateTime.Now.ToString("yyyy-MM-dd");

            folderCol = new System.Collections.Specialized.StringCollection();
            CreateHeadersAndFillListView();

            String path = System.AppContext.BaseDirectory;
            string[] paths = { path, "images" };
            string fullPath = Path.Combine(paths);


            PaintListView(fullPath);
            folderCol.Add(fullPath);

            this.fontSizeToolStripComboBox.SelectedItem = fontSizeToolStripComboBox.Items[3];
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecretaryForm newForm = new SecretaryForm();
            newForm.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Laser Ayyıldız tarafından oluşturulmuştur. Her türlü dilek, şikayet ve yardım talebi için laserayyildiz@gmail.com adresine mail atabilirsiniz!",
                "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
        }


        private void ClearColor()
        {
            siyahToolStripMenuItem.Checked = false;
            kırmızıToolStripMenuItem.Checked = false;
            maviToolStripMenuItem.Checked = false;
            yeşilToolStripMenuItem.Checked = false;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            ClearColor2();
            ForeColor = Color.Black;
            siyahToolStripMenuItem.Checked = true;
            blackToolStripButton.Checked = true;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            ClearColor2();
            ForeColor = Color.Red;
            kırmızıToolStripMenuItem.Checked = true;
            redToolStripButton.Checked = true;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            ClearColor2();
            ForeColor = Color.Green;
            yeşilToolStripMenuItem.Checked = true;
            greenToolStripButton.Checked = true;

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            ClearColor2();
            ForeColor = Color.Blue;
            maviToolStripMenuItem.Checked = true;
            blueToolStripButton.Checked = true;
        }

        private void ClearFont()
        {
            TimesNewRomanToolStripMenuItem.Checked = false;
            centuryToolStripMenuItem.Checked = false;
            arialToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }
        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            TimesNewRomanToolStripMenuItem.Checked = true;
            this.Font = new Font("Times New Roman", this.Font.Size, this.Font.Style);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            arialToolStripMenuItem.Checked = true;
            this.Font = new Font("Arial", this.Font.Size, this.Font.Style);
        }

        private void centuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            centuryToolStripMenuItem.Checked = true;
            this.Font = new Font("Century", this.Font.Size, this.Font.Style);
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            comicSansToolStripMenuItem.Checked = true;
            this.Font = new Font("Comic Sans MS", this.Font.Size, Font.Style);
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kalınToolStripMenuItem.Checked = !kalınToolStripMenuItem.Checked;
            this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Bold);
        }

        private void ıtalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ıtalicToolStripMenuItem.Checked = !ıtalicToolStripMenuItem.Checked;
            this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Italic);
        }

        private void altıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altıÇiziliToolStripMenuItem.Checked = !altıÇiziliToolStripMenuItem.Checked;
            this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Underline);
        }

        private void üstüÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            üstüÇiziliToolStripMenuItem.Checked = !üstüÇiziliToolStripMenuItem.Checked;
            this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Strikeout);
        }

        private void tdbLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tdb.org.tr/");
        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {
            boldToolStripButton.Checked = !boldToolStripButton.Checked;
            this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripButton_Click(object sender, EventArgs e)
        {
            italicToolStripButton.Checked = !italicToolStripButton.Checked;
            this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Italic);
        }

        private void underlineToolStripButton_Click(object sender, EventArgs e)
        {
            underlineToolStripButton.Checked = !underlineToolStripButton.Checked;
            this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Underline);
        }

        private void strikeoutToolStripButton_Click(object sender, EventArgs e)
        {
            strikeoutToolStripButton.Checked = !strikeoutToolStripButton.Checked;
            this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Strikeout);
        }
        private void ClearColor2()
        {
            blackToolStripButton.Checked = false;
            redToolStripButton.Checked = false;
            blueToolStripButton.Checked = false;
            greenToolStripButton.Checked = false;
        }
        private void redToolStripButton_Click(object sender, EventArgs e)
        {
            ClearColor();
            ClearColor2();
            ForeColor = Color.Red;
            kırmızıToolStripMenuItem.Checked = true;
            redToolStripButton.Checked = true;
        }

        private void blueToolStripButton_Click(object sender, EventArgs e)
        {
            ClearColor();
            ClearColor2();
            ForeColor = Color.Blue;
            maviToolStripMenuItem.Checked = true;
            blueToolStripButton.Checked = true;
        }

        private void blackToolStripButton_Click(object sender, EventArgs e)
        {
            ClearColor();
            ClearColor2();
            ForeColor = Color.Black;
            siyahToolStripMenuItem.Checked = true;
            blackToolStripButton.Checked = true;
        }

        private void greenToolStripButton_Click(object sender, EventArgs e)
        {
            ClearColor();
            ClearColor2();
            ForeColor = Color.Green;
            yeşilToolStripMenuItem.Checked = true;
            greenToolStripButton.Checked = true;
        }

        private void yeniToolStripButton_Click(object sender, EventArgs e)
        {
            SecretaryForm newForm = new SecretaryForm();
            newForm.Show();
        }

        private void yardımToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Laser Ayyıldız tarafından oluşturulmuştur. Her türlü dilek, şikayet ve yardım talebi için laserayyildiz@gmail.com adresine mail atabilirsiniz!",
               "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
        }

        private PrintDocument printDocument1 = new PrintDocument();
        Bitmap memoryImage;
        private void yazdırToolStripButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void fontSizeToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (fontSizeToolStripComboBox.SelectedIndex)
            {
                case 0:
                    this.Font = new Font(this.Font.FontFamily, 10F);
                    break;
                case 1:
                    this.Font = new Font(this.Font.FontFamily, 11F);
                    break;
                case 2:
                    this.Font = new Font(this.Font.FontFamily, 12F);
                    break;
                case 3:
                    this.Font = new Font(this.Font.FontFamily, 14F);
                    break;
                case 4:
                    this.Font = new Font(this.Font.FontFamily, 16F);
                    break;
                case 5:
                    this.Font = new Font(this.Font.FontFamily, 18F);
                    break;
                case 6:
                    this.Font = new Font(this.Font.FontFamily, 20F);
                    break;
            }

        }
        private void resimSecButton_Click(object sender, EventArgs e)
        {
            String path = System.AppContext.BaseDirectory;
            string[] paths = { path, "images" };
            string fullPath = Path.Combine(paths);
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = fullPath;
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.ShowDialog();
            var directoryPath = openFileDialog1.FileName;
            try
            {
                pictureBox1.Image = Image.FromFile(directoryPath);
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Dosya Seçilmedi");
            }

        }

        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "Dosya Adı";
            listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Boyut";
            listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Son Değiştirilme";
            listView1.Columns.Add(colHead);


        }

        private void PaintListView(string root)
        {
            try
            {
                ListViewItem viewItem;
                ListViewItem.ListViewSubItem viewSubItem;

                if (string.IsNullOrEmpty(root))
                    return;
                DirectoryInfo dirInfo = new DirectoryInfo(root);

                DirectoryInfo[] dirInfos = dirInfo.GetDirectories();
                FileInfo[] files = dirInfo.GetFiles();

                listView1.Items.Clear();
                listView1.BeginUpdate();

                foreach (DirectoryInfo di in dirInfos)
                {
                    viewItem = new ListViewItem();
                    viewItem.Text = di.Name;
                    viewItem.ImageIndex = 0;
                    viewItem.Tag = di.FullName;

                    viewSubItem = new ListViewItem.ListViewSubItem();
                    viewSubItem.Text = "";
                    viewItem.SubItems.Add(viewSubItem);

                    viewSubItem = new ListViewItem.ListViewSubItem();
                    viewSubItem.Text = di.LastAccessTime.ToString();
                    viewItem.SubItems.Add(viewSubItem);

                    listView1.Items.Add(viewItem);

                }

                foreach (FileInfo fi in files)
                {
                    viewItem = new ListViewItem();
                    viewItem.Text = fi.Name;
                    viewItem.ImageIndex = 1;
                    viewItem.Tag = fi.FullName;

                    viewSubItem = new ListViewItem.ListViewSubItem();
                    viewSubItem.Text = fi.Length.ToString();
                    viewItem.SubItems.Add(viewSubItem);

                    viewSubItem = new ListViewItem.ListViewSubItem();
                    viewSubItem.Text = fi.LastAccessTime.ToString();
                    viewItem.SubItems.Add(viewSubItem);

                    listView1.Items.Add(viewItem);

                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string fname = lw.SelectedItems[0].Tag.ToString();

            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(fname);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                PaintListView(fname);
                folderCol.Add(fname);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView1.View = View.LargeIcon;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView1.View = View.SmallIcon;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView1.View = View.List;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView1.View = View.Details;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView1.View = View.Tile;
            }
        }

        private void tdbLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tdbLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.tdb.org.tr/");
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fiyatCheckedListBox.Items.Count; i++)
            {
                fiyatCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void deselectButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fiyatCheckedListBox.Items.Count; i++)
            {
                fiyatCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            fiyatListBox.Items.Clear();
            for (int i = 0; i <= fiyatCheckedListBox.CheckedItems.Count - 1; i++)
            {
                fiyatListBox.Items.Add(fiyatCheckedListBox.CheckedItems[i]);
            }
        }

        private void removeFromListButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= fiyatCheckedListBox.CheckedItems.Count - 1; i++)
            {
                string itemState = fiyatCheckedListBox.GetItemCheckState(i).ToString();

                if (itemState == "Unchecked")
                {
                    fiyatListBox.Items.Remove(fiyatCheckedListBox.Items[i]);
                }
            }
        }

        private void toplamFiyatHesaplaButton_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            foreach (var listBoxItem in fiyatListBox.Items)
            {
                if (listBoxItem.Equals("Diş Çekme"))
                {
                    toplam += 100;
                }
                else if (listBoxItem.Equals("Dolgu"))
                {
                    toplam += 150;
                }
                else if (listBoxItem.Equals("Kanal Tedavisi"))
                {
                    toplam += 600;
                }
                else if (listBoxItem.Equals("Köprü"))
                {
                    toplam += 500;
                }
                else if (listBoxItem.Equals("Tel Tedavisi"))
                {
                    toplam += 7500;
                }
                else if (listBoxItem.Equals("Protez"))
                {
                    toplam += 5000;
                }
                else if (listBoxItem.Equals("Diş Taşı Temizliği"))
                {
                    toplam += 200;
                }
                else if (listBoxItem.Equals("Parlatma"))
                {
                    toplam += 1200;
                }
                else if (listBoxItem.Equals("Diş Temizliği"))
                {
                    toplam += 200;
                }
            }
            toplamFiyatLabel.Text = "Toplam: " + toplam.ToString() + "TL";

        }
        
        private void listeyiDoldur()
        {
            try
            {
                SQLiteConnection connect = new SQLiteConnection("Data source = TrackingSystem.db");
                connect.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM patient", connect);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "info");
                hastaKayıtlarıDataGridView.DataSource = dataSet.Tables[0];
                connect.Close();
            }
            catch (SQLiteException )
            {
                MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
            }
        }

        private void doktorlarComboBoxDoldur()
        {
            try
            {
                SQLiteConnection connect = new SQLiteConnection("Data source = TrackingSystem.db");
                connect.Open();
                string strCmd = "SELECT Id," + "Firstname || ' ' ||" + " Lastname FullName" + " FROM dentist";
                SQLiteCommand cmd = new SQLiteCommand(strCmd, connect);
                SQLiteDataAdapter da = new SQLiteDataAdapter(strCmd, connect);
                DataSet ds = new DataSet();
                da.Fill(ds);
                doktorlarComboBox.DataSource = ds.Tables[0];
                doktorlarComboBox.DisplayMember = "FullName";
                doktorlarComboBox.ValueMember = "Id";
                doktorlarComboBox.Enabled = true;

                doktorSecComboBox.DataSource = ds.Tables[0];
                doktorSecComboBox.DisplayMember = "FullName";
                doktorSecComboBox.ValueMember = "Id";
                doktorSecComboBox.Enabled = true;
                
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (SQLiteException )
            {
                MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
            }

        }

        private void sekreterlerComboBoxDoldur()
        {
            try
            {
                SQLiteConnection connect = new SQLiteConnection("Data source = TrackingSystem.db");
                connect.Open();
                string strCmd = "SELECT Id," + "Firstname || ' ' ||" + " Lastname FullName" + " FROM secretary";
                SQLiteCommand cmd = new SQLiteCommand(strCmd, connect);
                SQLiteDataAdapter da = new SQLiteDataAdapter(strCmd, connect);
                DataSet ds = new DataSet();
                da.Fill(ds);
                sekreterlerComboBox.DataSource = ds.Tables[0];
                sekreterlerComboBox.DisplayMember = "FullName";
                sekreterlerComboBox.ValueMember = "Id";
                sekreterlerComboBox.Enabled = true;

                sekreterSecComboBox.DataSource = ds.Tables[0];
                sekreterSecComboBox.DisplayMember = "FullName";
                sekreterSecComboBox.ValueMember = "Id";
                sekreterSecComboBox.Enabled = true;
                
                cmd.ExecuteNonQuery();
                connect.Close();
            }
             catch (SQLiteException )
            {
                MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
            }
        }

        private void secretaryForm_Load(object sender, EventArgs e)
        {
            listeyiDoldur();
            doktorlarComboBoxDoldur();
            sekreterlerComboBoxDoldur();
        }

        private void kayıtButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection connect = new SQLiteConnection("Data source = TrackingSystem.db");
                connect.Open();
                var cmd = new SQLiteCommand(connect);
                cmd.CommandText = "INSERT INTO Patient (Firstname, Lastname, Treatment_date, Phone, Email, Address, Secretary_id, Dentist_id) VALUES (@fname, @lname, @treatment_date, @phone, @email, @address, @secretary_id ,@dentist_id)";
                cmd.Parameters.AddWithValue("@fname", adTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", soyadTextBox.Text);
                cmd.Parameters.AddWithValue("@treatment_date", randevuGünüPicker.Value.ToString("yyyy-MM-dd") + " " + randevuSaatiPicker.Value.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@secretary_id", sekreterlerComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@dentist_id", doktorlarComboBox.SelectedValue);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Yeni Hasta Eklendi. Değişiklikleri Görüntülemek İçin Listeyi Tazeleyin!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch(SQLiteException )
            {
                MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
            }
            
        }

        private void yenileButton_Click(object sender, EventArgs e)
        {
            listeyiDoldur();
        }

        private void selectedIndexDeletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection connect = new SQLiteConnection("Data source = TrackingSystem.db");
                connect.Open();
                var cmd = new SQLiteCommand(connect);
                cmd.CommandText = "DELETE FROM Patient WHERE Id = @id";

                int selectedrowindex = hastaKayıtlarıDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = hastaKayıtlarıDataGridView.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id"].Value);

                cmd.Parameters.AddWithValue("@id", cellValue);

                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Hasta Silindi. Değişiklikleri Görüntülemek İçin Listeyi Tazeleyin!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SQLiteException )
            {
                MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
            }

        }

        private void tariheGöreSıralaPicker_ValueChanged(Object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection connect = new SQLiteConnection("Data source = TrackingSystem.db");
                connect.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM patient WHERE treatment_date LIKE '" + tariheGöreSıralaPicker.Value.ToString("yyyy-MM-dd") + "%'", connect);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "info");
                hastaKayıtlarıDataGridView.DataSource = dataSet.Tables[0];
                connect.Close();

            }
            catch (SQLiteException)
            {
                MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
            }
            
        }

        private void doktorSecComboBox_SelectedIndexChanged(Object sender ,EventArgs e)
        {
            try
            {
                    string doktorSelected = this.doktorSecComboBox.GetItemText(this.doktorSecComboBox.SelectedValue);
                    SQLiteConnection connect = new SQLiteConnection("Data source = TrackingSystem.db");
                    connect.Open();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM patient WHERE Dentist_id='" + doktorSelected + "'", connect);

                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "info");
                    hastaKayıtlarıDataGridView.DataSource = dataSet.Tables[0];
                    connect.Close();
                
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
            }
            
        }

        private void sekreterSecComboBox_SelectedIndexChanged(Object sender, EventArgs e)
        {
            try
            {
                    string sekreterSelected = this.sekreterSecComboBox.GetItemText(this.sekreterSecComboBox.SelectedValue);
                    SQLiteConnection connect = new SQLiteConnection("Data source = TrackingSystem.db");
                    connect.Open();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM patient WHERE secretary_id='" + sekreterSelected + "'", connect);

                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "info");
                    hastaKayıtlarıDataGridView.DataSource = dataSet.Tables[0];
                    connect.Close();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
            }

        }
    }
}

