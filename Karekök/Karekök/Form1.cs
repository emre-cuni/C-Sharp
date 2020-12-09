using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karekök
{
    public partial class Ekran : Form
    {
        public Ekran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt16(textBox1.Text);

            for(int kok = 1; kok <= sayi; kok++)
            {
                if(sayi / kok == kok && sayi % kok == 0)
                {
                    listBox1.Items.Add(kok+"\n");
                    break;
                }
                else if(sayi / kok == kok-1 )
                {
                    int kkok, aralik, fark;
                    double ek;

                    kkok = kok - 1;
                    aralik = (kok * kok) - (kkok * kkok);
                    fark = sayi - (kkok * kkok);

                    ek = (double)fark / aralik;

                    listBox1.Items.Add(kkok + ek + "\n");
                    break;
                }
                else if(sayi/kok==kok-2 && sayi % kok != 0)
                {
                    int kkok, aralik, fark;
                    double ek;

                    kkok = kok - 1;
                    aralik = (kok * kok) - (kkok * kkok);
                    fark = sayi - (kkok * kkok);

                    ek = (double)fark / aralik;

                    listBox1.Items.Add(kkok + ek + "\n");
                    break;
                }    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
        }
    }
}
