using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TeknoKaucuk
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        StringBuilder fileName = new StringBuilder();
        StringBuilder numbers = new StringBuilder();
        string number = null;
        List<double> unsortedNumbers = new List<double>();
        StreamReader streamReader;
        double[] sortedNumbers;

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Metin Dosyası |*.txt";
                openFileDialog1.Title = "Bir Metin Dosyası Seçiniz";

                if (openFileDialog1.ShowDialog() == DialogResult.OK) //dosya seçildiyse;
                {
                    buttonSort.Enabled = true; // "sırala" butonunu aktif eder
                    fileName.Append(openFileDialog1.SafeFileName); // seçilen dosyanın adını alır
                    streamReader = new StreamReader(openFileDialog1.FileName); 
                    numbers.Append(streamReader.ReadToEnd()); // seçilen dosyadaki veriler okunur ve "numbers" değişkenine atanır

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        char numCheck = Convert.ToChar(numbers.ToString().Substring(i, 1)); 
                        if (!char.IsWhiteSpace(numCheck)) // dosyadaki her bir karakterin white-space karakteri olup olmadığını kontrol eder
                            number += numCheck; // white-space karakteri denk gelene kadar olan sayıları bir değişkene atar
                        else if (number != string.Empty) //white-space karakterine denk geldiğinde tutulan sayılar "unsortedNumbers" listine eklenir
                        {
                            unsortedNumbers.Add(double.Parse(number));
                            number = string.Empty;
                        }
                    }
                    sortedNumbers = unsortedNumbers.ToArray(); // listteki sayılar bir diziye atanır
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Dosya Seçme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(sortedNumbers); // sayılar büyükten küçüğe sıralanır
                Array.Reverse(sortedNumbers); // sıralanan dizi ters çevrilir ve büyükten küçüğe sıralanmış olur
                foreach (var item in sortedNumbers) // dizi büyükten küçüğe sıralanmış şekilde ekrana bastırılır
                    listBox1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Sıralama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
