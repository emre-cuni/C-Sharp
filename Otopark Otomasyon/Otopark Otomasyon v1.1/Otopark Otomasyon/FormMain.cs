using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyon
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string name = null;
        string phone = null;
        string entryPlate = null;
        string exitPlate = null;
        string carType = null;
        List<string> carPark = new List<string>();
        string[] cars;
        double sum = 0;
        double totalDays = 0;
        int deleteIndex = 0, id = 0;
        DateTime carEntryTime;

        private void buttonCarEntry_Click(object sender, EventArgs e)
        {
            try
            {
                //hiçbir yerin boş olup olmamasını kontrol eder
                if (textBoxName.Text != "" && maskedTextBoxTel.Text != "" && textBoxEntryPlate.Text != "" && comboBoxCarType.SelectedIndex != -1 && maskedTextBoxDate.Text != "")
                {
                    //kullanıcıdan kaydedilecek aracın bilgileri alınır
                    name = textBoxName.Text;
                    phone = maskedTextBoxTel.Text;
                    entryPlate = textBoxEntryPlate.Text;
                    carType = comboBoxCarType.SelectedItem.ToString();
                    carEntryTime = DateTime.Parse(maskedTextBoxDate.Text);

                    foreach (var item in carPark)
                    {
                        if (item.IndexOf(entryPlate) != -1) // var olan plakanın tekrar kaydedilmesini engeller
                        {
                            MessageBox.Show("Kayıtlı Plaka Tekrar Kaydedilemez!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            goto finish;
                        }
                    }
                    carPark.Add(name + "#" + phone + "#" + entryPlate + "#" + carType + "#" + carEntryTime + "#" + id++);
                    MessageBox.Show(entryPlate + " Plakalı Aracın Girişi Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxCarExitPlate.Text = null;
                    textBoxEntryPlate.Text = null;
                    textBoxName.Text = null;
                    maskedTextBoxDate.Text = null;
                    maskedTextBoxTel.Text = null;
                    comboBoxCarType.SelectedIndex = -1;
                finish:;
                }
                else
                    MessageBox.Show("Boş Yer Kalamaz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace);
            }
        }

        private void textBoxCarExitPlate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxCarExitPlate.Text = textBoxCarExitPlate.Text.ToUpper();
                textBoxCarExitPlate.Select(textBoxCarExitPlate.Text.Length, 0);
                exitPlate = textBoxCarExitPlate.Text;
                //0-name -> 1-phone -> 2-plate -> 3-carType -> 4-time -> 5-id
                foreach (var car in carPark)
                {
                    cars = car.Split('#');
                    if (cars[2] == exitPlate)
                    {
                        totalDays = (DateTime.Now - DateTime.Parse(cars[4])).TotalDays;
                        switch (cars[3])
                        {
                            case "Otomobil": // günlük 50
                                sum = Math.Round(totalDays * 50, 1);
                                break;
                            case "Motosiklet": // günlük 35
                                sum = Math.Round(totalDays * 35, 1);
                                break;
                            case "Kamyon": // günlük 100 
                                sum = Math.Round(totalDays * 100, 1);
                                break;
                        }
                        textBoxTotal.Text = sum + " ₺";
                        deleteIndex = int.Parse(cars[5]);
                        break;
                    }
                    else
                    {
                        textBoxTotal.Text = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace);
            }
        }

        private void buttonCarExit_Click(object sender, EventArgs e)
        {
            try
            {
                carPark.RemoveAt(deleteIndex);
                MessageBox.Show(exitPlate + " Plakalı Aracın Çıkışı Yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxCarExitPlate.Text = null;
                textBoxTotal.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(deleteIndex + "   ex.message: " + ex.Message + " stackTrace: " + ex.StackTrace);
            }
        }

        private void textBoxEntryPlate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxEntryPlate.Text = textBoxEntryPlate.Text.ToUpper();
                textBoxEntryPlate.Select(textBoxEntryPlate.Text.Length, 0);
                if(textBoxEntryPlate.Text.Length > 8)
                    textBoxEntryPlate.Text = textBoxEntryPlate.Text.Remove(8);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxName.Text = textBoxName.Text.ToUpper();
                textBoxName.Select(textBoxName.Text.Length, 0);               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace);
            }
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
