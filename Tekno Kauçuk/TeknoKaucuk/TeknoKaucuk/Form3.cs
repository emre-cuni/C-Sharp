using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeknoKaucuk
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int n = 0, row = 0;
        int[,] multiplicationTable;
        char numCheck;
        string text = null;

        private void textBoxN_TextChanged(object sender, EventArgs e) // textbox'a sadece sayı girilmesini sağlar
        {
            try
            {                
                text = textBoxN.Text;
                if (text.ToString() != string.Empty && text.Length <= 2)  // textbox'ın değeri maksimum 2 karakter uzunluğundaysa
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        numCheck = Convert.ToChar(text.ToString().Substring(i, 1)); // textbox'ın değeri tek tek karaktere çevirilir
                        if (!char.IsNumber(numCheck)) // çevrilen karakter sayı değilse silinir
                            text = text.Remove(i, 1);
                        else if (int.Parse(text.ToString()) > 15 || int.Parse(text.ToString()) == 0) // textbox'ın değeri 15'ten büyük veya 0'sa
                        {
                            text = text.Remove(text.Length - 1, 1); // son karakter silinir
                            MessageBox.Show("Lütfen 1-15 Arasında Bir Sayı Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning); // ve uyarı mesajı ekrana bastırılır
                        }
                    }
                }
                else if (text.ToString() != string.Empty) // textbox'ın değeri boşsa ekrana uyarı mesajı bastırır
                {
                    text = text.Remove(text.Length - 1, 1);
                    MessageBox.Show("Lütfen 1-15 Arasında Bir Sayı Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxN.Text = text.ToString(); // karakter silindikten sonra kalan değer textbox'ın text özelliğine verilir
                textBoxN.Select(textBoxN.Text.Length, 0); // imleç textbox'ın en sonuna konur
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
                if (textBoxN.Text != string.Empty) // textbox'ın değeri boş değilse;
                {
                    dataGridView1.Rows.Clear(); // tablonun bütün satırlarını siler
                    dataGridView1.Columns.Clear(); // tablonun bütün sütunlarını siler
                    dataGridView1.Visible = true; // tabloyu görünür yapar

                    n = Convert.ToInt32(textBoxN.Text); // girilen değer "n" değişkenine atanır
                    multiplicationTable = new int[n + 1, n + 1]; //girilen sayının bir fazlası uzunlukta matris tanımlanır

                    for (int i = 0; i <= n; i++)
                    {
                        dataGridView1.Columns.Add("col" + i, i.ToString()); // tabloya sütun ekler
                        for (int j = 0; j <= n; j++)
                        {
                            if (i == 0) // tablonun en üst satırını doldurur
                                multiplicationTable[i, j] = j;
                            else if (j == 0) // tablonun en sol sütununu doldurur
                                multiplicationTable[i, j] = i;
                            else // çarpım tablosunun kalan yerlerini karşılık gelen satır ve sütundaki değerlerle çarpar ve doldurur
                                multiplicationTable[i, j] = multiplicationTable[i, 0] * multiplicationTable[0, j];
                        }
                    }

                    for (int i = 0; i <= n; i++) 
                    {
                        row = dataGridView1.Rows.Add();//tabloya n kadar satır ekler
                        for (int j = 0; j <= n; j++)
                            dataGridView1.Rows[row].Cells[j].Value = multiplicationTable[i, j]; //satırları doldurur
                    }
                    // tabloyu tablonun büyüklüğüne göre boyutlandırır
                    dataGridView1.AutoSize = true; 
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.ColumnHeadersVisible = false; // sütun başlıklarını görünmez yapar 
                }
                else // textbox'ın değeri boşsa ekrana uyarı mesajı bastırır
                    MessageBox.Show("Boş Yerleri Doldurunuz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Çarpım Tablosu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
