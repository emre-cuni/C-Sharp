using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonSend.NormalColor = Color.FromArgb(150, 150, 150);
            buttonSend.NormalBorderColor = Color.FromArgb(180, 180, 180);
            buttonSend.HoverColor = Color.FromArgb(102, 102, 102);
            buttonSave.NormalColor = Color.FromArgb(150, 150, 150);
            buttonSave.NormalBorderColor = Color.FromArgb(180, 180, 180);
            buttonSave.HoverColor = Color.FromArgb(102, 102, 102);
            textBoxIP.BackColor = Color.FromArgb(90, 90, 90);
            textBoxIP.ForeColor = Color.White;
            textBoxPort.BackColor = Color.FromArgb(90, 90, 90);
            textBoxPort.ForeColor = Color.White;
            textBoxMessage.BackColor = Color.FromArgb(90, 90, 90);
            textBoxMessage.ForeColor = Color.White;
            textBoxName.BackColor = Color.FromArgb(90, 90, 90);
            textBoxName.ForeColor = Color.White;
            labelIP.ForeColor = Color.White;
            labelMessage.ForeColor = Color.White;
            labelName.ForeColor = Color.White;
            labelPort.ForeColor = Color.White;
            metroGridSend.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }

        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint serverEndpoint;
        IPEndPoint clientEndpoint;
        IPAddress ipAddress;
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipAddress = ip;
                        break;
                    }
                }
                serverEndpoint = new IPEndPoint(ipAddress, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }
        }

        private void metroGridSend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (metroGridSend.CurrentCell.ColumnIndex == 0 && metroGridSend.CurrentRow.Cells["ColumnMessage"].Value != null) //satırların en başındaki hücreye tıklanıp tıklanmadığını kontrol eder
                {
                    clientEndpoint = new IPEndPoint(IPAddress.Parse(metroGridSend.CurrentRow.Cells["ColumnToAddress"].Value.ToString()), int.Parse(metroGridSend.CurrentRow.Cells["ColumnToPort"].Value.ToString())); //mesajın gönderileceği adres için endpoint oluşturur
                    string message = metroGridSend.CurrentRow.Cells["ColumnMessage"].Value.ToString();
                    BindEndPoint(clientEndpoint, message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                //gönderilecek mesaj için bütün textbox'ların boş olup olmadığını kontrol eder
                if ((textBoxIP.Text != null || textBoxIP.Text != "") && (textBoxMessage.Text != null || textBoxMessage.Text != "") && (textBoxPort.Text != null || textBoxPort.Text != ""))
                {
                    string message = textBoxMessage.Text;
                    clientEndpoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), int.Parse(textBoxPort.Text));//mesajın gönderileceği adres için endpoint oluşturur
                    BindEndPoint(clientEndpoint, message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }
        }

        private void BindEndPoint(IPEndPoint clientEndPoint, string message)
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(serverEndpoint); //soketi yerel endpoint ile bağlar
                serverSocket.Connect(clientEndpoint); //soketi mesajın gönderileceği endpoint ile bağlar

                if (serverSocket.Connected) //soket bağlıysa mesajı gönderir
                    SendMessage(serverSocket, message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }
        }

        private async void SendMessage(Socket handler, string message)
        {
            await Task.Run(() =>
            {
                try
                {
                    byte[] sendMessage = Encoding.ASCII.GetBytes(message); //mesajı byte array'e çevirir
                    handler.BeginSend(sendMessage, 0, sendMessage.Length, 0, new AsyncCallback(SendMessageCallback), handler);
                }
                catch (SocketException se)
                {
                    MessageBox.Show("ex.message: " + se.Message + " stacktrace: " + se.StackTrace + " Olay Zamanı: " + DateTime.Now);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
                }
            });
        }

        private async void SendMessageCallback(IAsyncResult ar)
        {
            await Task.Run(() =>
            {
                try
                {
                    Socket handler = (Socket)ar.AsyncState;
                    int bytesSent = handler.EndSend(ar); //gönderilen byte sayısını 
                    serverSocket.Close();
                }
                catch (SocketException se)
                {
                    MessageBox.Show("ex.message: " + se.Message + " stacktrace: " + se.StackTrace + " Olay Zamanı: " + DateTime.Now);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
                }
            });
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //kaydedilecek mesaj için bütün textbox'ların boş olup olmadığını kontrol eder
                if (textBoxName.Text != "" && textBoxName.Text != null && textBoxIP.Text != null && textBoxIP.Text != "" && textBoxMessage.Text != null && textBoxMessage.Text != "" && textBoxPort.Text != null && textBoxPort.Text != "")
                    metroGridSend.Rows.Add("Send", textBoxName.Text, textBoxIP.Text, textBoxPort.Text, textBoxMessage.Text);
                else
                    MessageBox.Show("Boş Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e) // Port numarası olarak maksimum 5 karakter ve sadece sayısal değer girilmesini sağlar
        {
            try
            {
                string portText = textBoxPort.Text;
                if (textBoxPort.Text.Length <= 5)
                {
                    for (int i = 0; i < portText.Length; i++)
                    {
                        char x = Convert.ToChar(portText.Substring(i, 1));
                        if (!char.IsNumber(x))
                            portText = portText.Remove(i, 1);
                    }
                    textBoxPort.Text = portText;
                }
                else
                    textBoxPort.Text = textBoxPort.Text.Remove(5, 1);
                textBoxPort.Select(textBoxPort.Text.Length, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "textBoxPortChanged hatası");
            }
        }
    }
}
