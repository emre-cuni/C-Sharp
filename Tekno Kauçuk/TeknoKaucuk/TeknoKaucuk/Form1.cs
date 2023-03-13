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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1 = 0, num2 = 0, num3 = 0, result = 0;
        char numCheck;
        string text = null;

        private void textBox_TextChanged(object sender, EventArgs e) // ilk 3 textbox'a sadece sayı girilmesini sağlar harf veya özel karakter girilirse girilen karakteri siler
        {
            try
            {
                TextBox textBox = (TextBox)sender;

                text = (textBox.Text);
                for(int i = 0; i < text.Length; i++) 
                {
                    numCheck = Convert.ToChar(text.ToString().Substring(i, 1)); // textbox'taki metni tek tek karaktere çevirir
                    if (!char.IsNumber(numCheck)) // çevrilen karakterin sayı olup olmadığını kontrol eder
                        text = text.Remove(i, 1); // girilen karakter sayı değilse silinir
                    textBox.Text = text.ToString(); // karakter silindikten sonra kalan değer textbox'ın text özelliğine verilir
                }
                textBox.Select(textBox.Text.Length, 0); // imleç textbox'ın en sonuna konur
                text = string.Empty; // text değişkenin değeri temizlenir
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "TextBox Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty) // ilk 3 textbox'ın değerleri boş değilse;
                {
                    // textbox'a girilen değerler int değişkenlere atanır
                    num1 = Convert.ToInt32(textBox1.Text); 
                    num2 = Convert.ToInt32(textBox2.Text);
                    num3 = Convert.ToInt32(textBox3.Text);

                    result = (num1 + num2) * num3; // ilk iki sayının toplamı üçüncü sayıyla çarpılır ve "result" değişkenine atanır

                    textBoxResult.Text = result.ToString(); // "result" değişkeninin değeri 4. textbox'a yazdırılır
                }   
                else // herhangi bir textbox boş ise ekrana uyarı mesajı bastırılır
                    MessageBox.Show("Boş Yerleri Doldurunuz!","UYARI",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Sonucu Göster Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
