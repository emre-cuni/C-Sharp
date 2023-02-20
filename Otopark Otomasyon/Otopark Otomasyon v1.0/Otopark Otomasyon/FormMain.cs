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
        int deleteIndex = 0;
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
                            MessageBox.Show("Kayıtlı Plaka Tekrar Kaydedilemez!!!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            goto finish;
                        }
                    }
                    carPark.Add(name + "#" + phone + "#" + entryPlate + "#" + carType + "#" + carEntryTime);
                finish:;
                }
                else
                    MessageBox.Show("Boş Yer Kalamaz!!!" ,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stackTrace: " + ex.StackTrace);
            }
        }

        private void textBoxCarExitPlate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Text = carPark.Capacity.ToString();
                exitPlate = textBoxCarExitPlate.Text;
                //0-name -> 1-phone -> 2-plate -> 3-carType -> 4-time
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
                        break;
                    }
                    else
                    {
                        textBoxTotal.Text = null;
                        deleteIndex++;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stackTrace: " + ex.StackTrace);
            }
        }

        private void buttonCarExit_Click(object sender, EventArgs e)
        {
            try
            {
                carPark.RemoveAt(deleteIndex);
                MessageBox.Show("${exitPlate} Plakalı Aracın Çıkışı Yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stackTrace: " + ex.StackTrace);
            }
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
