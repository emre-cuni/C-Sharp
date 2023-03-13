using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TeknoKaucuk
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int digit = 0;
        char numCheck;
        string text = null;
        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxFibo.Text != string.Empty) // textbox'ın değeri boş değilse;
                {
                    digit = Convert.ToInt32(textBoxFibo.Text); // kullanıcının girdiği basamak değeri alınır 
                    // kullanıcıdan alınan basamak değeri metoda gönderilir ve sonucu ekrana bastırılır
                    MessageBox.Show("Fibonacci Serisinin " + digit + ". Basamağı: " + Fibonacci(digit), "Fibonacci", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // textbox'ın değeri boşsa ekrana uyarı mesajı bastırılır
                    MessageBox.Show("Boş Yerleri Doldurunuz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Fibonacci Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private int Fibonacci(int digit)
        {
            try
            {
                if (digit == 0 || digit == 1) // 0. ve 1. basamaklara 0 değeri döndürür
                    return 0;
                else if (digit == 2) // 2. basamağa 1 değeri döndürür
                    return 1;
                else // rekürsif şekilde 2. basamağa kadar döner ve istenen basamağın değerini döndürür
                    return Fibonacci(digit - 1) + Fibonacci(digit - 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Fibonacci Metod Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void textBoxFibo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                text = textBoxFibo.Text;
                for (int i = 0; i < text.Length; i++)
                {
                    numCheck = Convert.ToChar(text.ToString().Substring(i, 1)); // textbox'taki metni tek tek karaktere çevirir
                    if (!char.IsNumber(numCheck)) // çevrilen karakterin sayı olup olmadığını kontrol eder
                        text = text.Remove(i, 1); // girilen karakter sayı değilse silinir
                    textBoxFibo.Text = text.ToString(); // karakter silindikten sonra kalan değer textbox'ın text özelliğine verilir
                }
                textBoxFibo.Select(textBoxFibo.Text.Length, 0); // imleç textbox'ın en sonuna konur
                text = string.Empty; // text değişkenin değeri temizlenir
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "TextBox Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}