using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MessageSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IPEndPoint localEndpoint;
        IPEndPoint remoteEndpoint;
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (IPAddress address in Dns.GetHostAddresses(Dns.GetHostName()))
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                        localEndpoint = new IPEndPoint(address, 0); //bilgisayarın ip adresi alınır
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stackTrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "IP Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                //mesajın, ip adresinin ve port numarasının boş olup olmamasını kontrol eder
                if ((textBoxIp.Text != null || textBoxIp.Text != "") && (textBoxMessage.Text != null || textBoxMessage.Text != "") && (textBoxPort.Text != null || textBoxPort.Text != ""))
                {
                    remoteEndpoint = new IPEndPoint(IPAddress.Parse(textBoxIp.Text), int.Parse(textBoxPort.Text)); 
                    Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
                    serverSocket.Bind(localEndpoint); 
                    serverSocket.Connect(remoteEndpoint); 
                    string message = textBoxMessage.Text;

                    if (serverSocket.Connected) //socket göndereceğimiz adrese bağlıysa mesaj gönderilir
                    {
                        SendMessage(serverSocket, message);
                    }
                }
                else
                    MessageBox.Show("Boş Alanları Doldurun !!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SocketException se)
            {
                MessageBox.Show("se.message: " + se.Message + " stackTrace: " + se.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stackTrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now);
            }

        }
        private async void SendMessage(Socket handler, string message)
        {
            await Task.Run(() =>
            {
                try
                {
                    byte[] sendMessage = Encoding.ASCII.GetBytes(message);
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
                    int bytesSent = handler.EndSend(ar);
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