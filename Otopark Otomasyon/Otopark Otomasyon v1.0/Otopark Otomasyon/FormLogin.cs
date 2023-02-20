using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Otopark_Otomasyon
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            if (!Directory.Exists(path))
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                    path += filePath;
                }
            }
        }

        string admin = null;
        string password = null;
        string path = "Admin\\";
        static string filePath = "admin.txt";

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // yönetici adı ve parola alınır
                admin = textBoxLoginAdmin.Text;
                password = textBoxLoginPassword.Text;

                // dosyadaki yöneticilerle karşılaştırılır
                var admins = File.ReadAllLines(filePath); // dosyadaki bütün yöneticileri "admins" dizisine atar
                foreach (var item in admins)
                {    // girilen yönetici adı ve parola dosyadaki yönetici ve parolalardan biriyle uyuyorsa giriş yapar                
                    if (admin == item.Substring(item.IndexOf("admin:") + 6, item.IndexOf("*") - item.IndexOf(":") -1 ) && password == item.Substring(item.IndexOf("password:" ) + 9)) 
                    {
                        FormMain formMain = new FormMain();
                        this.Hide();
                        formMain.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // yönetici adı ve parola alınır
                admin = textBoxRegisterAdmin.Text;
                password = textBoxRegisterPassword.Text;

                // yönetici adı ve parola dosyaya yazılır 
                using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                using (StreamWriter streamWriter = new StreamWriter((Stream)fileStream))
                {
                    streamWriter.WriteLine("admin:" + admin + "*password:" + password);
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }
        }
    }
}
