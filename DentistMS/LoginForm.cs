using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace DentistMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();

            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();

            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
           
            String nick_name = kullanıcıAdıTextBox.Text.ToString();
            String password = sifreTextBox.Text;
            try
            {
                SQLiteConnection connect = new SQLiteConnection("Data source = TrackingSystem.db");
                connect.Open();
                var cmd = new SQLiteCommand(connect);
                string passwords = encryption(password);
                cmd.CommandText = "SELECT * FROM user WHERE (nick_name = '" + nick_name + "') AND (password = '" + passwords + "');";
                string auth;

                SQLiteDataReader sqldr = cmd.ExecuteReader();
                
                if (sqldr.Read())
                {
                    auth = sqldr["auth"].ToString();
                    // auth = 0 -> Secretary
                    // auth = 1 -> Dentist
                    // auth = 2 -> Admin
                    if (auth.Equals("0"))
                    {
                        SecretaryForm secretaryForm = new SecretaryForm();
                        secretaryForm.Show();
                        this.Hide();
                    }

                    else if(auth.Equals("1")){
                        DentistForm dentistForm= new DentistForm();
                        dentistForm.Show();
                        this.Hide();
                    }

                    else if (auth.Equals("2"))
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
                    }
                    //MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
                connect.Close();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Veritabanı Hatası. Uygulama Yapımcınız ile İletişime Geçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "mailto:laserayyildiz@gmail.com?subject=Diş Hekimlliği Yönetim Programı");
            }
            
        }
    }
}
