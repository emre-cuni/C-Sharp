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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= 200; i++) // 200'e kadar bir döngü döndürülür
                {
                    if (i % 3 == 0 && i % 5 == 0 && i <= 100) //sayı hem 3'e hem 5'e bölünüyorsa ve 100'e küçük eşitse ekrana "zigzag" yazdırılır
                        listBox1.Items.Add("zigzag"); 
                    else if (i % 3 == 0 && i % 5 == 0 && i > 100) //sayı hem 3'e hem 5'e bölünüyorsa ve 100'den büyükse ekrana "zagzig" yazdırılır
                        listBox1.Items.Add("zagzig");
                    else if (i % 3 == 0) // sayı sadece 3'e bölünüyorsa ekrana "zig" yazdırılır
                        listBox1.Items.Add("zig");
                    else if (i % 5 == 0) // sayı sadece 5'e bölünüyorsa ekrana "zag" yazdırılır
                        listBox1.Items.Add("zag");
                    else // sayı ne 3'e ne de 5'e bölünmüyorsa sayının kendisi ekrana yazdırılır
                        listBox1.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Ekrana Bastır Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
