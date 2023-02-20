using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyon
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        string admin = null;
        string password = null; 
        string query;
        MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd='';Database=otopark_otomasyon;");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader sqlDataReader = null;
        
        Dictionary<string,string> admins = new Dictionary<string,string>();

        private void FormLogin_Load(object sender, EventArgs e)
        {
            OpenConnection();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            try
            {
                // yönetici adı ve parola alınır
                admin = textBoxLoginAdmin.Text;
                password = textBoxLoginPassword.Text;

                // veritabanındaki yöneticilerle karşılaştırılır
                query = "SELECT * FROM admintable"; // veri tabanındaki bütün kayıtları çekecek sorgu
               
                command.CommandText = query;
                command.Connection = connection;
                
                //adapter.SelectCommand = command;
                sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    admins.Add(sqlDataReader["name"].ToString(), sqlDataReader["password"].ToString());   //veri tabanından çekilen kayıtlar dictionary'e atanır
                }
                connection.Close(); // bağlantı kapatılır
                foreach (var recordRow in admins)
                {
                    if(admin == recordRow.Key && password == recordRow.Value)
                    {
                        FormMain formMain = new FormMain();
                        this.Hide();
                        formMain.ShowDialog();
                        this.Show();
                        OpenConnection();
                    }
                }
                //size 324; 271
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
                query = "INSERT INTO admintable(name,password) VALUES('" + admin + "', '" + password + "')";
                command.CommandText = query;
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }
        }

        private void OpenConnection()
        {
            try
            {
                connection.Open(); // yazılım çalıştırılınca sql bağlantısı yapılır
                if (connection.State == ConnectionState.Closed)
                    MessageBox.Show("SQL Bağlantısı Yapılamadı!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("SQL Bağlantısı Yapılamadı!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
