using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoKaucuk
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e) //bütün butonların click event'i burda tetiklenir
        {
            try
            {
                Button button = (Button)sender; 
                
                this.Hide(); //main formunu gizler
                switch(button.Name)//hangi butondan tıklandıysa o işlev'in formu açılır
                {
                    case "button1":
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                        break;
                    case "button2":
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                        break;
                    case "button3":
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                        break;
                    case "button4":
                        Form4 form4 = new Form4();
                        form4.ShowDialog();
                        break;
                    case "button5":
                        Form5 form5 = new Form5();
                        form5.ShowDialog();
                        break;
                }
                this.Show(); //açılan işlevin formu kapandıktan sonra main formu tekrar açılır
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Main Form Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Tekno Kauçuk Teknik Mülakat Testi\n\nGeliştirici: Emre Cüni", "Tekno Kauçuk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Hakkında Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
