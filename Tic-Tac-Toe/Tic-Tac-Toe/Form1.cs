using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe {
    public partial class Form1 : Form {

        string[] oyuncu = new string[2];
        string baslangic = "X", sira = "X";

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Sıradaki Oyuncu: " + baslangic;
            
        }
       

        private void btnEnabled()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEnabled();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geliştirici: Emre Cüni");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            //tıklanan butonun değerini değiştirme
            if (sira == "X")
            {
                button1.Text = "X";
                sira = "O";
            }
            else if (sira == "O")
            {
                button1.Text = "O";
                sira = "X";
            }
            button1.Enabled = false;
            label1.Text = "Sıradaki Oyuncu: " + sira;

           

            //oyunun bitme durumu
            if ((button1.Text == button2.Text && button1.Text == button3.Text)||
                (button1.Text == button4.Text && button1.Text == button7.Text)||
                (button1.Text == button5.Text && button1.Text == button9.Text))
            {
                if (sira == "X")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: O");
                    sira = "X";
                }
                else if (sira == "O")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: X");
                    sira = "O";
                }
            }

            //oyunun berabere bitme durumu
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if ((button1.Text != button2.Text || button1.Text != button3.Text) ||
                    (button1.Text != button4.Text || button1.Text != button7.Text) ||
                    (button1.Text != button5.Text || button1.Text != button9.Text))
                {
                    MessageBox.Show("Oyun Berabere Bitti.");
                    btnEnabled();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //tıklanan butonun değerini değiştirme
            if (sira == "X")
            {
                button2.Text = "X";
                sira = "O";
            }
            else if (sira == "O")
            {
                button2.Text = "O";
                sira = "X";
            }
            label1.Text = "Sıradaki Oyuncu: " + sira;
            button2.Enabled = false;

            //oyunun bitme durumu
            if ((button2.Text == button1.Text && button2.Text == button3.Text) ||
                (button2.Text == button5.Text && button5.Text == button8.Text))
            {
                if (sira == "X")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: O");
                    sira = "X";
                }
                else if (sira == "O")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: X");
                    sira = "O";
                }
            }

            //oyunun berabere bitme durumu
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if ((button2.Text != button1.Text || button2.Text != button3.Text) ||
                    (button2.Text != button5.Text || button2.Text != button8.Text))
                {
                    MessageBox.Show("Oyun Berabere Bitti.");
                    btnEnabled();
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //tıklanan butonun değerini değiştirme
            if (sira == "X")
            {
                button3.Text = "X";
                sira = "O";
            }
            else if (sira == "O")
            {
                button3.Text = "O";
                sira = "X";
            }
            label1.Text = "Sıradaki Oyuncu: " + sira;
            button3.Enabled = false;

            //oyunun bitme durumu
            if ((button3.Text == button2.Text && button3.Text == button1.Text) ||
                (button3.Text == button5.Text && button3.Text == button7.Text) ||
                (button3.Text == button6.Text && button3.Text == button9.Text))
            {
                if (sira == "X")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: O");
                    sira = "X";
                }
                else if (sira == "O")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: X");
                    sira = "O";
                }
            }

            //oyunun berabere bitme durumu
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if ((button3.Text != button2.Text || button3.Text != button1.Text) ||
                    (button3.Text != button5.Text || button3.Text != button7.Text) ||
                    (button3.Text != button6.Text || button3.Text != button9.Text))
                {
                    MessageBox.Show("Oyun Berabere Bitti.");
                    btnEnabled();
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            //tıklanan butonun değerini değiştirme
            if (sira == "X")
            {
                button4.Text = "X";
                sira = "O";
            }
            else if (sira == "O")
            {
                button4.Text = "O";
                sira = "X";
            }
            label1.Text = "Sıradaki Oyuncu: " + sira;
            button4.Enabled = false;

            //oyunun bitme durumu
            if ((button4.Text == button1.Text && button4.Text == button7.Text) ||
               (button4.Text == button5.Text && button4.Text == button6.Text))
            {
                if (sira == "X")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: O");
                    sira = "X";
                }
                else if (sira == "O")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: X");
                    sira = "O";
                }
            }

            //oyunun berabere bitme durumu
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if ((button4.Text != button1.Text || button4.Text != button7.Text) ||
                    (button4.Text != button5.Text || button4.Text != button6.Text))
                {
                    MessageBox.Show("Oyun Berabere Bitti.");
                    btnEnabled();
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            //tıklanan butonun değerini değiştirme
            if (sira == "X")
            {
                button5.Text = "X";
                sira = "O";
            }
            else if (sira == "O")
            {
                button5.Text = "O";
                sira = "X";
            }
            label1.Text = "Sıradaki Oyuncu: " + sira;
            button5.Enabled = false;

            //oyunun bitme durumu
            if ((button5.Text == button1.Text && button5.Text == button9.Text) ||
                (button5.Text == button2.Text && button5.Text == button8.Text) ||
                (button5.Text == button3.Text && button5.Text == button7.Text) ||
                (button5.Text == button4.Text && button5.Text == button6.Text))
            {
                if (sira == "X")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: O");
                    sira = "X";
                }
                else if (sira == "O")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: X");
                    sira = "O";
                }
            }

            //oyunun berabere bitme durumu
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if ((button5.Text != button1.Text || button5.Text != button9.Text) ||
                    (button5.Text != button2.Text || button5.Text != button8.Text) ||
                    (button5.Text != button3.Text || button5.Text != button7.Text) ||
                    (button5.Text != button4.Text || button5.Text != button6.Text))
                {
                    MessageBox.Show("Oyun Berabere Bitti.");
                    btnEnabled();
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            //tıklanan butonun değerini değiştirme
            if (sira == "X")
            {
                button6.Text = "X";
                sira = "O";
            }
            else if (sira == "O")
            {
                button6.Text = "O";
                sira = "X";
            }
            label1.Text = "Sıradaki Oyuncu: " + sira;
            button6.Enabled = false;

            //oyunun bitme durumu
            if ((button6.Text == button3.Text && button6.Text == button9.Text) ||
                (button6.Text == button5.Text && button6.Text == button4.Text))
            {
                if (sira == "X")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: O");
                    sira = "X";
                }
                else if (sira == "O")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: X");
                    sira = "O";
                }
            }

            //oyunun berabere bitme durumu
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if ((button6.Text != button3.Text || button6.Text != button9.Text) ||
                    (button6.Text != button5.Text || button6.Text != button4.Text))
                {
                    MessageBox.Show("Oyun Berabere Bitti.");
                    btnEnabled();
                }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //tıklanan butonun değerini değiştirme
            if (sira == "X")
            {
                button7.Text = "X";
                sira = "O";
            }
            else if (sira == "O")
            {
                button7.Text = "O";
                sira = "X";
            }
            label1.Text = "Sıradaki Oyuncu: " + sira;
            button7.Enabled = false;

            //oyunun bitme durumu
            if ((button7.Text == button4.Text && button7.Text == button1.Text) ||
                (button7.Text == button5.Text && button7.Text == button3.Text) ||
                (button7.Text == button8.Text && button7.Text == button9.Text))
            {
                if (sira == "X")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: O");
                }
                else if (sira == "O")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: X");
                }
            }

            //oyunun berabere bitme durumu
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                    button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                    button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if ((button7.Text != button4.Text || button7.Text != button1.Text) ||
                    (button7.Text != button5.Text || button7.Text != button3.Text) ||
                    (button7.Text != button8.Text || button7.Text != button9.Text))
                {
                    MessageBox.Show("Oyun Berabere Bitti.");
                    btnEnabled();
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            //tıklanan butonun değerini değiştirme
            if (sira == "X")
            {
                button8.Text = "X";
                sira = "O";
            }
            else if (sira == "O")
            {
                button8.Text = "O";
                sira = "X";
            }
            label1.Text = "Sıradaki Oyuncu: " + sira;
            button8.Enabled = false;

            //oyunun bitme durumu 
            if ((button8.Text == button5.Text && button8.Text == button2.Text) ||
                (button8.Text == button7.Text && button8.Text == button9.Text))
            {
                if (sira == "X")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: O");
                }
                else if (sira == "O")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: X");
                }
            }
            
            //oyunun berabere bitme durumu
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if ((button8.Text != button5.Text || button8.Text != button2.Text) ||
                    (button8.Text != button7.Text || button8.Text != button9.Text))
                {
                    MessageBox.Show("Oyun Berabere Bitti.");
                    btnEnabled();
                }
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            //tıklanan butonun değerini değiştirme
            if (sira == "X")
            {
                button9.Text = "X";
                sira = "O";
            }
            else if (sira == "O")
            {
                button9.Text = "O";
                sira = "X";
            }
            label1.Text = "Sıradaki Oyuncu: " + sira;
            button9.Enabled = false;

            //oyunun bitme durumu
            if ((button9.Text == button5.Text && button9.Text == button1.Text) ||
                (button9.Text == button6.Text && button9.Text == button3.Text) ||
                (button9.Text == button8.Text && button9.Text == button7.Text))
            {
                if (sira == "X")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: O");
                }
                else if (sira == "O")
                {
                    MessageBox.Show("Oyun Bitti.\nKazanan: X");
                }
            }

            //oyunun berabere bitme durumu
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if ((button9.Text != button5.Text || button9.Text != button1.Text) ||
                   (button9.Text != button6.Text || button9.Text != button3.Text) ||
                   (button9.Text != button8.Text || button9.Text != button7.Text))
                {
                    MessageBox.Show("Oyun Berabere Bitti.");
                    btnEnabled();
                }
            }
        }

    }
}
