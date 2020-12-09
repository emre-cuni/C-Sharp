using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Oyunu {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int sayi, harf, sure = 120, zamanlayici = 30, soruSayisi = 0, puan = 0, alinanHarf = 0, sbp = 0;
        //sbp = soru başına puan

        string[] dortHarfliSorular = new string[10];
        string[] besHarfliSorular = new string[10];
        string[] altiHarfliSorular = new string[10];
        string[] yediHarfliSorular = new string[10];
        string[] sekizHarfliSorular = new string[10];
        string[] dokuzHarfliSorular = new string[10];

        string[] dortHarfliCevaplar = new string[10];
        string[] besHarfliCevaplar = new string[10];
        string[] altiHarfliCevaplar = new string[10];
        string[] yediHarfliCevaplar = new string[10];
        string[] sekizHarfliCevaplar = new string[10];
        string[] dokuzHarfliCevaplar = new string[10];

        private void Form1_Load(object sender, EventArgs e)
        {
            //4 harfli sorular bittikçe diğer kutular görünür olacak
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;

            labelPuan.Text = "";
            labelSBP.Text = "";

            //sorular
            {
                dortHarfliSorular[0] = "Yanan maddelerin veya gazların türlü biçimlerdeki ışıklı uzantısı, yalım, yalaz, alaz, şule";
                dortHarfliSorular[1] = "Uygun olmayan tepki ve davranışları önlemek ya da böylesi uygunsuz eylemler için, yapana karşı uygulanan üzüntü, sıkıntı, acı verici işlem.";
                dortHarfliSorular[2] = "Varsıl evlerinde çocuk bakımıyla görevli kadın.";
                dortHarfliSorular[3] = "Sorulara karşılık olarak kullanılan, öyledir anlamında doğrulama ya da onama bildiren sözcük.";
                dortHarfliSorular[4] = "Bir kadının evli bulunduğu erkek, eş.";
                dortHarfliSorular[5] = "Devletçe bastırılan ve ülke içinde ödeme aracı olarak kullanılan, üzerinde saymaca değeri yazılı, kâğıt ya da metal nesne.";
                dortHarfliSorular[6] = "Namazda, elleri dizlere dayayarak öne doğru eğilme.";
                dortHarfliSorular[7] = "Geniş bir düş gücü bulunan, duyarlı, duygulu kimse. Ozan.";
                dortHarfliSorular[8] = "Hasta farelerden insanlara geçen bir mikrobun yol açtığı bulaşıcı ve öldürücü bir hastalık.";
                dortHarfliSorular[9] = "İnsanın düşünme, akıl yürütme, nesnel gerçekleri algılama, kavrama, yargılama ve sonuç çıkarma yeteneklerinin tümü.";

                dortHarfliCevaplar[0] = "ALEV";
                dortHarfliCevaplar[1] = "CEZA";
                dortHarfliCevaplar[2] = "DADI";
                dortHarfliCevaplar[3] = "EVET";
                dortHarfliCevaplar[4] = "KOCA";
                dortHarfliCevaplar[5] = "PARA";
                dortHarfliCevaplar[6] = "RÜKU";
                dortHarfliCevaplar[7] = "ŞAİR";
                dortHarfliCevaplar[8] = "VEBA";
                dortHarfliCevaplar[9] = "ZEKA";

                besHarfliSorular[0] = "Kas.";
                besHarfliSorular[1] = "Çiçek ve ağaç yetiştirilen yer. Bostan.";
                besHarfliSorular[2] = "Bir ülkede yönetime el koyan kimselerden oluşan kurul.";
                besHarfliSorular[3] = "Ev, arsa, bahçe vb. taşınamayan mal ve mülklerin ortak adı, taşınmazlar, gayrimenkul.";
                besHarfliSorular[4] = "Akdeniz, Karadeniz ve Batı Avrupa kıyılarında avlanan, 10-12 cm boyunda, ince uzun bir balık.";
                besHarfliSorular[5] = "Bir şeyin üstünü kaplayan ve onu dış etkilere karşı koruyan, kendiliğinden oluşmuş sertçe bölüm, kışır.";
                besHarfliSorular[6] = "Dayanılması güç durum. Huysuzluğu ve titizliği ile can sıkan.";
                besHarfliSorular[7] = "İçine katılmış türlü maddelerle özel bir tat verilmiş, fırında veya başka bir yolla pişirilerek hazırlanmış bir tür hamur tatlısı.";
                besHarfliSorular[8] = "Yetişkin erkeklerde yanak ve alt çenede çıkan kılların tümü.";
                besHarfliSorular[9] = "Testere ile biçilen veya rende, matkap, törpü vb. araçlarla işlenen bir şeyden dökülen kırıntılar.";

                besHarfliCevaplar[0] = "ADALE";
                besHarfliCevaplar[1] = "BAHÇE";
                besHarfliCevaplar[2] = "CUNTA";
                besHarfliCevaplar[3] = "EMLAK";
                besHarfliCevaplar[4] = "HAMSİ";
                besHarfliCevaplar[5] = "KABUK";
                besHarfliCevaplar[6] = "MARAZ";
                besHarfliCevaplar[7] = "PASTA";
                besHarfliCevaplar[8] = "SAKAL";
                besHarfliCevaplar[9] = "TALAŞ";

                altiHarfliSorular[0] = "Kuşatma.";
                altiHarfliSorular[1] = "Bir yapının genellikle dışarıya doğru çıkmış, çevresi duvar veya parmaklıkla çevrili bölümü, ayazlık.";
                altiHarfliSorular[2] = "Beden, köstek ve iğne bölümlerinden meydana gelen, her bir iğneye hindi, horoz, kaz, martı, tavuk, ördek vb. kuşların kanat, kuyruk tüyleri takılan çok iğneli bir tür olta takımı.";
                altiHarfliSorular[3] = "Bir yeri daha önce görmüş olma veya bir olayı daha önce yaşamış olma duygusu.";
                altiHarfliSorular[4] = "Yapay gübre ve bazı ilaçların yapımında kullanılan fosforik asidin tuzu veya esteri.";
                altiHarfliSorular[5] = "Lokanta, pastane, kahvehane vb. yerlerde müşterilere hizmet eden kimse.";
                altiHarfliSorular[6] = "Kedigillerden, enine siyah çizgili, koyu sarı postu olan, Asya'da yaşayan çevik ve yırtıcı hayvan.";
                altiHarfliSorular[7] = "Isınmaya, bir şey pişirmeye yarayan, sac, bakır veya pirinçten, türlü biçimlerde üstü açık ayaklı ocak, korluk.";
                altiHarfliSorular[8] = "Dayanıklı, kolay bozulmaz, yıkılmaz.";
                altiHarfliSorular[9] = "Atmosferdeki su buharının yoğunlaşmasıyla oluşan ve yeryüzüne düşen yağışın sıvı durumda olanı, yağar, yağış, baran, bereket, rahmet.";

                altiHarfliCevaplar[0] = "ABLUKA";
                altiHarfliCevaplar[1] = "BALKON";
                altiHarfliCevaplar[2] = "ÇAPARİ";
                altiHarfliCevaplar[3] = "DEJAVU";
                altiHarfliCevaplar[4] = "FOSFAT";
                altiHarfliCevaplar[5] = "GARSON";
                altiHarfliCevaplar[6] = "KAPLAN";
                altiHarfliCevaplar[7] = "MANGAL";
                altiHarfliCevaplar[8] = "SAĞLAM";
                altiHarfliCevaplar[9] = "YAĞMUR";

                yediHarfliSorular[0] = "Yiyecek ve içeceklere hoş koku ve tat vermek için kullanılan tarçın, karanfil, zencefil, karabiber vb. maddeler, bahar.";
                yediHarfliSorular[1] = "Bilgisizlik.";
                yediHarfliSorular[2] = "Namlusu kısa, kurşun atan bir çeşit küçük tüfek. Güzel, yakışıklı.";
                yediHarfliSorular[3] = "Özellikle futbolda fanatizmi besleyen, aşırı davranışlarda bulunan ve çevreye zarar vermeye eğilimli taraftar, serseri, hayta.";
                yediHarfliSorular[4] = "Yangın söndürme kuruluşu.";
                yediHarfliSorular[5] = "Yüksek sesle gülme.";
                yediHarfliSorular[6] = "Bir çeşit İtalyan makarnası.";
                yediHarfliSorular[7] = "Olumsuz, menfi.";
                yediHarfliSorular[8] = "Tepeleri ortak bir noktada birleşen, tabanları da herhangi bir çokgenin birer kenarı olan birtakım üçgenlerden oluşmuş cisim, ehram.";
                yediHarfliSorular[9] = "Başka bir çizgiye, eğriye ve yüzeye dokunan fakat onu kesmeyen çizgi, eğri veya yüzey.";

                yediHarfliCevaplar[0] = "BAHARAT";
                yediHarfliCevaplar[1] = "CEHALET";
                yediHarfliCevaplar[2] = "FİLİNTA";
                yediHarfliCevaplar[3] = "HOLİGAN";
                yediHarfliCevaplar[4] = "İTFAİYE";
                yediHarfliCevaplar[5] = "KAHKAHA";
                yediHarfliCevaplar[6] = "LAZANYA";
                yediHarfliCevaplar[7] = "NEGATİF";
                yediHarfliCevaplar[8] = "PİRAMİT";
                yediHarfliCevaplar[9] = "TANJANT";

                sekizHarfliSorular[0] = "İçindeki tanelerin hareketiyle ses çıkaran metal nesne.";
                sekizHarfliSorular[1] = "Laf cambazlığı.";
                sekizHarfliSorular[2] = "Yutak iltihabı.";
                sekizHarfliSorular[3] = "El çabukluğu ile birtakım şaşırtıcı olaylar yapmayı meslek edinen kimse.";
                sekizHarfliSorular[4] = "Aklama belgesi.";
                sekizHarfliSorular[5] = "Lokomotif, vapur, fabrika vb.nin makinesini işleten kimse.";
                sekizHarfliSorular[6] = "Bir şeyin olabilmesi durumu, olabilirlik, ihtimal.";
                sekizHarfliSorular[7] = "Yazı yazmak, resim yapmak için özel olarak hazırlanan deri, tirşe.";
                sekizHarfliSorular[8] = "Başı insan, gövdesi yılan biçiminde olduğuna inanılan efsanevi yaratık.";
                sekizHarfliSorular[9] = "İdari işlerin düzeltilmesi için alınan önlemlerin ve uygulamaların tamamı.";

                sekizHarfliCevaplar[0] = "ÇINGIRAK";
                sekizHarfliCevaplar[1] = "DEMAGOJİ";
                sekizHarfliCevaplar[2] = "FARENJİT";
                sekizHarfliCevaplar[3] = "HOKKABAZ";
                sekizHarfliCevaplar[4] = "İBRANAME";
                sekizHarfliCevaplar[5] = "MAKİNİST";
                sekizHarfliCevaplar[6] = "OLASILIK";
                sekizHarfliCevaplar[7] = "PARŞÖMEN";
                sekizHarfliCevaplar[8] = "ŞAHMERAN";
                sekizHarfliCevaplar[9] = "TANZİMAT";

                dokuzHarfliSorular[0] = "Yeşile çalan mavi renk.";
                dokuzHarfliSorular[1] = "Tanzimattan önce, kadıların yanında yetişmek üzere görevlendirilen kimse.";
                dokuzHarfliSorular[2] = "Çalgı.";
                dokuzHarfliSorular[3] = "Eski Roma'da arenada birbirleriyle veya yırtıcı hayvanlarla dövüşen kimse.";
                dokuzHarfliSorular[4] = "Kan bilimci.";
                dokuzHarfliSorular[5] = "Güzel kokular, makyaj malzemesi satan kimse veya yer.";
                dokuzHarfliSorular[6] = "Boş söz.";
                dokuzHarfliSorular[7] = "İnsanlara Allah'ın buyruklarını bildiren, onları Allah yoluna, dine çağıran kimse, yalvaç, yalavaç, elçi.";
                dokuzHarfliSorular[8] = "Gözlemevi.";
                dokuzHarfliSorular[9] = "Peynir, zeytin, salam, sucuk vb. yiyecek maddelerinin satıldığı dükkân veya büyük alışveriş merkezinin bir bölümü.";

                dokuzHarfliCevaplar[0] = "CAMGÖBEĞİ";
                dokuzHarfliCevaplar[1] = "DANİŞMENT";
                dokuzHarfliCevaplar[2] = "ENSTÜRMAN";
                dokuzHarfliCevaplar[3] = "GLADYATÖR";
                dokuzHarfliCevaplar[4] = "HEMATOLOG";
                dokuzHarfliCevaplar[5] = "ITRİYATÇI";
                dokuzHarfliCevaplar[6] = "LAFIGÜZAF";
                dokuzHarfliCevaplar[7] = "PEYGAMBER";
                dokuzHarfliCevaplar[8] = "RASATHANE";
                dokuzHarfliCevaplar[9] = "ŞARKÜTERİ";
            }
        }

        private void yeniOyun()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBoxSoru.Text = "";
        }

        string soruTorba = "";
        private void yeniSoru()
        {
            
            sayi = rastgele.Next(10);//soru dizilerinden verilecek soruyu rastgele seçme
            

            if (soruSayisi == 2 || soruSayisi == 3) // 5 harfli soruları ekrana verme
            {
                sbp = 500;
                switch (sayi)
                {
                    case 0:
                        textBoxSoru.Text = besHarfliSorular[0];
                        break;
                    case 1:
                        textBoxSoru.Text = besHarfliSorular[1];
                        break;
                    case 2:
                        textBoxSoru.Text = besHarfliSorular[2];
                        break;
                    case 3:
                        textBoxSoru.Text = besHarfliSorular[3];
                        break;
                    case 4:
                        textBoxSoru.Text = besHarfliSorular[4];
                        break;
                    case 5:
                        textBoxSoru.Text = besHarfliSorular[5];
                        break;
                    case 6:
                        textBoxSoru.Text = besHarfliSorular[6];
                        break;
                    case 7:
                        textBoxSoru.Text = besHarfliSorular[7];
                        break;
                    case 8:
                        textBoxSoru.Text = besHarfliSorular[8];
                        break;
                    case 9:
                        textBoxSoru.Text = besHarfliSorular[9];
                        break;
                }
            }
            else if(soruSayisi == 4 || soruSayisi == 5) // 6 harfli soruları ekrana verme
            {
                sbp = 600;
                switch (sayi)
                {
                    case 0:
                        textBoxSoru.Text = altiHarfliSorular[0];
                        break;
                    case 1:
                        textBoxSoru.Text = altiHarfliSorular[1];
                        break;
                    case 2:
                        textBoxSoru.Text = altiHarfliSorular[2];
                        break;
                    case 3:
                        textBoxSoru.Text = altiHarfliSorular[3];
                        break;
                    case 4:
                        textBoxSoru.Text = altiHarfliSorular[4];
                        break;
                    case 5:
                        textBoxSoru.Text = altiHarfliSorular[5];
                        break;
                    case 6:
                        textBoxSoru.Text = altiHarfliSorular[6];
                        break;
                    case 7:
                        textBoxSoru.Text = altiHarfliSorular[7];
                        break;
                    case 8:
                        textBoxSoru.Text = altiHarfliSorular[8];
                        break;
                    case 9:
                        textBoxSoru.Text = altiHarfliSorular[9];
                        break;
                }
            }
            else if(soruSayisi == 6 || soruSayisi == 7) // 7 harfli soruları ekrana verme
            {
                sbp = 700;
                switch (sayi)
                {
                    case 0:
                        textBoxSoru.Text = yediHarfliSorular[0];
                        break;
                    case 1:
                        textBoxSoru.Text = yediHarfliSorular[1];
                        break;
                    case 2:
                        textBoxSoru.Text = yediHarfliSorular[2];
                        break;
                    case 3:
                        textBoxSoru.Text = yediHarfliSorular[3];
                        break;
                    case 4:
                        textBoxSoru.Text = yediHarfliSorular[4];
                        break;
                    case 5:
                        textBoxSoru.Text = yediHarfliSorular[5];
                        break;
                    case 6:
                        textBoxSoru.Text = yediHarfliSorular[6];
                        break;
                    case 7:
                        textBoxSoru.Text = yediHarfliSorular[7];
                        break;
                    case 8:
                        textBoxSoru.Text = yediHarfliSorular[8];
                        break;
                    case 9:
                        textBoxSoru.Text = yediHarfliSorular[9];
                        break;
                }
            }
            else if(soruSayisi == 8 || soruSayisi == 9) // 8 harfli soruları ekrana verme
            {
                sbp = 800;
                switch (sayi)
                {
                    case 0:
                        textBoxSoru.Text = sekizHarfliSorular[0];
                        break;
                    case 1:
                        textBoxSoru.Text = sekizHarfliSorular[1];
                        break;
                    case 2:
                        textBoxSoru.Text = sekizHarfliSorular[2];
                        break;
                    case 3:
                        textBoxSoru.Text = sekizHarfliSorular[3];
                        break;
                    case 4:
                        textBoxSoru.Text = sekizHarfliSorular[4];
                        break;
                    case 5:
                        textBoxSoru.Text = sekizHarfliSorular[5];
                        break;
                    case 6:
                        textBoxSoru.Text = sekizHarfliSorular[6];
                        break;
                    case 7:
                        textBoxSoru.Text = sekizHarfliSorular[7];
                        break;
                    case 8:
                        textBoxSoru.Text = sekizHarfliSorular[8];
                        break;
                    case 9:
                        textBoxSoru.Text = sekizHarfliSorular[9];
                        break;
                }
            }
            else if(soruSayisi == 10 || soruSayisi == 11) // 9 harfli soruları ekrana verme
            {
                sbp = 900;
                switch (sayi)
                {
                    case 0:
                        textBoxSoru.Text = dokuzHarfliSorular[0];
                        break;
                    case 1:
                        textBoxSoru.Text = dokuzHarfliSorular[1];
                        break;
                    case 2:
                        textBoxSoru.Text = dokuzHarfliSorular[2];
                        break;
                    case 3:
                        textBoxSoru.Text = dokuzHarfliSorular[3];
                        break;
                    case 4:
                        textBoxSoru.Text = dokuzHarfliSorular[4];
                        break;
                    case 5:
                        textBoxSoru.Text = dokuzHarfliSorular[5];
                        break;
                    case 6:
                        textBoxSoru.Text = dokuzHarfliSorular[6];
                        break;
                    case 7:
                        textBoxSoru.Text = dokuzHarfliSorular[7];
                        break;
                    case 8:
                        textBoxSoru.Text = dokuzHarfliSorular[8];
                        break;
                    case 9:
                        textBoxSoru.Text = dokuzHarfliSorular[9];
                        break;
                }
            }
            else // 4 harfli soruları ekrana verme
            {
                sbp = 400;
                switch (sayi)
                {
                    case 0:
                        textBoxSoru.Text = dortHarfliSorular[0];
                        break;
                    case 1:
                        textBoxSoru.Text = dortHarfliSorular[1];
                        break;
                    case 2:
                        textBoxSoru.Text = dortHarfliSorular[2];
                        break;
                    case 3:
                        textBoxSoru.Text = dortHarfliSorular[3];
                        break;
                    case 4:
                        textBoxSoru.Text = dortHarfliSorular[4];
                        break;
                    case 5:
                        textBoxSoru.Text = dortHarfliSorular[5];
                        break;
                    case 6:
                        textBoxSoru.Text = dortHarfliSorular[6];
                        break;
                    case 7:
                        textBoxSoru.Text = dortHarfliSorular[7];
                        break;
                    case 8:
                        textBoxSoru.Text = dortHarfliSorular[8];
                        break;
                    case 9:
                        textBoxSoru.Text = dortHarfliSorular[9];
                        break;
                }
            }

            int kontrolSoru = soruTorba.IndexOf(sayi.ToString());
            if(kontrolSoru != -1)
            {

                sayi = rastgele.Next(10);
                if (soruSayisi == 2 || soruSayisi == 3) // 5 harfli soruları ekrana verme
                {
                    switch (sayi)
                    {
                        case 0:
                            textBoxSoru.Text = besHarfliSorular[0];
                            break;
                        case 1:
                            textBoxSoru.Text = besHarfliSorular[1];
                            break;
                        case 2:
                            textBoxSoru.Text = besHarfliSorular[2];
                            break;
                        case 3:
                            textBoxSoru.Text = besHarfliSorular[3];
                            break;
                        case 4:
                            textBoxSoru.Text = besHarfliSorular[4];
                            break;
                        case 5:
                            textBoxSoru.Text = besHarfliSorular[5];
                            break;
                        case 6:
                            textBoxSoru.Text = besHarfliSorular[6];
                            break;
                        case 7:
                            textBoxSoru.Text = besHarfliSorular[7];
                            break;
                        case 8:
                            textBoxSoru.Text = besHarfliSorular[8];
                            break;
                        case 9:
                            textBoxSoru.Text = besHarfliSorular[9];
                            break;
                    }
                }
                else if (soruSayisi == 4 || soruSayisi == 5) // 6 harfli soruları ekrana verme
                {
                    switch (sayi)
                    {
                        case 0:
                            textBoxSoru.Text = altiHarfliSorular[0];
                            break;
                        case 1:
                            textBoxSoru.Text = altiHarfliSorular[1];
                            break;
                        case 2:
                            textBoxSoru.Text = altiHarfliSorular[2];
                            break;
                        case 3:
                            textBoxSoru.Text = altiHarfliSorular[3];
                            break;
                        case 4:
                            textBoxSoru.Text = altiHarfliSorular[4];
                            break;
                        case 5:
                            textBoxSoru.Text = altiHarfliSorular[5];
                            break;
                        case 6:
                            textBoxSoru.Text = altiHarfliSorular[6];
                            break;
                        case 7:
                            textBoxSoru.Text = altiHarfliSorular[7];
                            break;
                        case 8:
                            textBoxSoru.Text = altiHarfliSorular[8];
                            break;
                        case 9:
                            textBoxSoru.Text = altiHarfliSorular[9];
                            break;
                    }
                }
                else if (soruSayisi == 6 || soruSayisi == 7) // 7 harfli soruları ekrana verme
                {
                    switch (sayi)
                    {
                        case 0:
                            textBoxSoru.Text = yediHarfliSorular[0];
                            break;
                        case 1:
                            textBoxSoru.Text = yediHarfliSorular[1];
                            break;
                        case 2:
                            textBoxSoru.Text = yediHarfliSorular[2];
                            break;
                        case 3:
                            textBoxSoru.Text = yediHarfliSorular[3];
                            break;
                        case 4:
                            textBoxSoru.Text = yediHarfliSorular[4];
                            break;
                        case 5:
                            textBoxSoru.Text = yediHarfliSorular[5];
                            break;
                        case 6:
                            textBoxSoru.Text = yediHarfliSorular[6];
                            break;
                        case 7:
                            textBoxSoru.Text = yediHarfliSorular[7];
                            break;
                        case 8:
                            textBoxSoru.Text = yediHarfliSorular[8];
                            break;
                        case 9:
                            textBoxSoru.Text = yediHarfliSorular[9];
                            break;
                    }
                }
                else if (soruSayisi == 8 || soruSayisi == 9) // 8 harfli soruları ekrana verme
                {
                    switch (sayi)
                    {
                        case 0:
                            textBoxSoru.Text = sekizHarfliSorular[0];
                            break;
                        case 1:
                            textBoxSoru.Text = sekizHarfliSorular[1];
                            break;
                        case 2:
                            textBoxSoru.Text = sekizHarfliSorular[2];
                            break;
                        case 3:
                            textBoxSoru.Text = sekizHarfliSorular[3];
                            break;
                        case 4:
                            textBoxSoru.Text = sekizHarfliSorular[4];
                            break;
                        case 5:
                            textBoxSoru.Text = sekizHarfliSorular[5];
                            break;
                        case 6:
                            textBoxSoru.Text = sekizHarfliSorular[6];
                            break;
                        case 7:
                            textBoxSoru.Text = sekizHarfliSorular[7];
                            break;
                        case 8:
                            textBoxSoru.Text = sekizHarfliSorular[8];
                            break;
                        case 9:
                            textBoxSoru.Text = sekizHarfliSorular[9];
                            break;
                    }
                }
                else if (soruSayisi == 10 || soruSayisi == 11) // 9 harfli soruları ekrana verme
                {
                    switch (sayi)
                    {
                        case 0:
                            textBoxSoru.Text = dokuzHarfliSorular[0];
                            break;
                        case 1:
                            textBoxSoru.Text = dokuzHarfliSorular[1];
                            break;
                        case 2:
                            textBoxSoru.Text = dokuzHarfliSorular[2];
                            break;
                        case 3:
                            textBoxSoru.Text = dokuzHarfliSorular[3];
                            break;
                        case 4:
                            textBoxSoru.Text = dokuzHarfliSorular[4];
                            break;
                        case 5:
                            textBoxSoru.Text = dokuzHarfliSorular[5];
                            break;
                        case 6:
                            textBoxSoru.Text = dokuzHarfliSorular[6];
                            break;
                        case 7:
                            textBoxSoru.Text = dokuzHarfliSorular[7];
                            break;
                        case 8:
                            textBoxSoru.Text = dokuzHarfliSorular[8];
                            break;
                        case 9:
                            textBoxSoru.Text = dokuzHarfliSorular[9];
                            break;
                    }
                }
                else // 4 harfli soruları ekrana verme
                {
                    switch (sayi)
                    {
                        case 0:
                            textBoxSoru.Text = dortHarfliSorular[0];
                            break;
                        case 1:
                            textBoxSoru.Text = dortHarfliSorular[1];
                            break;
                        case 2:
                            textBoxSoru.Text = dortHarfliSorular[2];
                            break;
                        case 3:
                            textBoxSoru.Text = dortHarfliSorular[3];
                            break;
                        case 4:
                            textBoxSoru.Text = dortHarfliSorular[4];
                            break;
                        case 5:
                            textBoxSoru.Text = dortHarfliSorular[5];
                            break;
                        case 6:
                            textBoxSoru.Text = dortHarfliSorular[6];
                            break;
                        case 7:
                            textBoxSoru.Text = dortHarfliSorular[7];
                            break;
                        case 8:
                            textBoxSoru.Text = dortHarfliSorular[8];
                            break;
                        case 9:
                            textBoxSoru.Text = dortHarfliSorular[9];
                            break;
                    }
                }
            }
            soruTorba += sayi.ToString();
            labelSBP.Text = sbp.ToString();
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniOyun();

            MessageBox.Show("Cevapların Hepsini Büyük Harfle Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            buttonDurdur.Enabled = true;
            buttonHarf.Enabled = true;
            buttonKontrol.Enabled = true;
            buttonSonraki.Enabled = true;

            //sorunun rastgele seçilmesi
            yeniSoru();
            
            timer1.Enabled = true;
            timer1.Start();

        }

        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            buttonKontrol.Enabled = true;
            buttonHarf.Enabled = true;
            buttonDurdur.Enabled = true;

            soruSayisi++;
            switch (soruSayisi)//soruları geçtikçe 5-6-7-8-9 harfli soruların cevap kutularının açılması
            {
                case 2:
                    textBox5.Visible = true;
                    break;
                case 4:
                    textBox6.Visible = true;
                    break;
                case 6:
                    textBox7.Visible = true;
                    break;
                case 8:
                    textBox8.Visible = true;
                    break;
                case 10:
                    textBox9.Visible = true;
                    break;
            }
            soruTorba = "";
            yeniOyun(); // ekranı temizleme

            if (soruSayisi >= 12)
            {
                MessageBox.Show("Oyun Bitti.");
                buttonDurdur.Enabled = false;
                buttonHarf.Enabled = false;
                buttonKontrol.Enabled = false;
                timer1.Stop();
            }
            else
            {
                yeniSoru(); // ekrana yeni soruyu bastırma
            }

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geliştirici: Emre CÜNİ", "Kelime Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string cevap, torba = "";
        
        private void harfAlma(int sual)
        {
            harf = rastgele.Next(sual);
            if(soruSayisi == 2 || soruSayisi == 3) 
            {
                cevap = besHarfliCevaplar[sayi];
            }
            else if(soruSayisi == 4 || soruSayisi == 5)
            {
                cevap = altiHarfliCevaplar[sayi];
            }
            else if (soruSayisi == 6 || soruSayisi == 7)
            {
                cevap = yediHarfliCevaplar[sayi];
            }
            else if (soruSayisi == 8 || soruSayisi == 9)
            {
                cevap = sekizHarfliCevaplar[sayi];
            }
            else if (soruSayisi == 10 || soruSayisi == 11)
            {
                cevap = dokuzHarfliCevaplar[sayi];
            }
            else
            {
                cevap = dortHarfliCevaplar[sayi];
            }

            cevap = cevap.Substring(harf, 1); // cevabın rastgele verilen indisteki harfini ayırır.
            
        tekrar:
            switch (harf)
            {
                case 0:
                    textBox1.Text = cevap;
                    break;
                case 1:
                    textBox2.Text = cevap;
                    break;
                case 2:
                    textBox3.Text = cevap;
                    break;
                case 3:
                    textBox4.Text = cevap;
                    break;
                case 4:
                    textBox5.Text = cevap;
                    break;
                case 5:
                    textBox6.Text = cevap;
                    break;
                case 6:
                    textBox7.Text = cevap;
                    break;
                case 7:
                    textBox8.Text = cevap;
                    break;
                case 8:
                    textBox9.Text = cevap;
                    break;
            }

            if (soruSayisi == 0 || soruSayisi == 1)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                    textBox4.Text != "")
                {
                    buttonHarf.Enabled = false; 
                }
            }
            if (soruSayisi == 2 || soruSayisi == 3)
            {
                if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && 
                   textBox4.Text != "" && textBox5.Text != "")
                {
                    buttonHarf.Enabled = false;
                }
            }
            if (soruSayisi == 4 || soruSayisi == 5)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                    textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    buttonHarf.Enabled = false;
                }
            }
            if (soruSayisi == 6 || soruSayisi == 7)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                    textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && 
                    textBox7.Text != "")
                {
                    buttonHarf.Enabled = false;
                }
            }
            if (soruSayisi == 8 || soruSayisi == 9)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                    textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" &&
                    textBox7.Text != "" && textBox8.Text != "")
                {
                    buttonHarf.Enabled = false;
                }
            }
            if (soruSayisi == 10 || soruSayisi == 11)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                    textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" &&
                    textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                {
                    buttonHarf.Enabled = false;
                }
            }
            


            // rastgele verilen harfin indeksinin daha önce verilip verilmediğini kontrol eder
            int kontrol = torba.IndexOf(harf.ToString()); 
            if (kontrol != -1)
            {
                if (soruSayisi == 2 || soruSayisi == 3)
                {
                    cevap = besHarfliCevaplar[sayi];
                }
                else if(soruSayisi == 4 || soruSayisi == 5)
                {
                    cevap = altiHarfliCevaplar[sayi];
                }
                else if(soruSayisi == 6 || soruSayisi == 7)
                {
                    cevap = yediHarfliCevaplar[sayi];
                }
                else if(soruSayisi == 8 || soruSayisi == 9)
                {
                    cevap = sekizHarfliCevaplar[sayi];
                }
                else if(soruSayisi == 10 || soruSayisi == 11)
                {
                    cevap = dokuzHarfliCevaplar[sayi];
                }
                else
                {
                    cevap = dortHarfliCevaplar[sayi];
                }
                harf = rastgele.Next(sual);
                cevap = cevap.Substring(harf, 1);
                goto tekrar;//rastgelen verilen harfin indeksi daha önce verildiğinde tekrar sayı üretme
            }
            torba += harf.ToString();//rastgele sayıların toplandığı string
        }

        private void buttonHarf_Click(object sender, EventArgs e)
        {
            alinanHarf++;
            if (soruSayisi == 2 || soruSayisi == 3)
            {
                harfAlma(5);
            }
            else if(soruSayisi == 4 || soruSayisi == 5)
            {
                harfAlma(6);
            }
            else if(soruSayisi == 6 || soruSayisi == 7)
            {
                harfAlma(7);
            }
            else if(soruSayisi == 8 || soruSayisi == 9)
            {
                harfAlma(8);
            }
            else if(soruSayisi == 10 || soruSayisi == 11)
            {
                harfAlma(9);
            }
            else
            {
                harfAlma(4);
            }
            sbp -= 100;
            labelSBP.Text = sbp.ToString();
        }
        private void buttonDurdur_Click(object sender, EventArgs e)
        {
            buttonHarf.Enabled = false;
            timer1.Stop();
            timer2.Enabled = true;
            timer2.Start();
        }
        private void buttonKontrol_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            //kullanıcıdan cevabı alma
            sonuc += textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text +
                     textBox6.Text + textBox7.Text + textBox8.Text + textBox9.Text;

            if(dortHarfliCevaplar[sayi] == sonuc)
            {
                MessageBox.Show("Tebrikler.");
                puan += 400;
            }
            else if (besHarfliCevaplar[sayi] == sonuc)
            {
                MessageBox.Show("Tebrikler.");
                puan += 500;
            }
            else if(altiHarfliCevaplar[sayi] == sonuc)
            {
                MessageBox.Show("Tebrikler.");
                puan += 600;
            }
            else if(yediHarfliCevaplar[sayi] == sonuc)
            {
                MessageBox.Show("Tebrikler.");
                puan += 700;
            }
            else if(sekizHarfliCevaplar[sayi] == sonuc)
            {
                MessageBox.Show("Tebrikler.");
                puan += 800;
            }
            else if(dokuzHarfliCevaplar[sayi] == sonuc)
            {
                MessageBox.Show("Tebrikler.");
                puan += 900;
            }
            else
            {
                MessageBox.Show("Yanlış Cevap.");
                puan += (alinanHarf * 100);
            }

            puan -= (alinanHarf * 100);

            alinanHarf = 0;
            labelPuan.Text = puan.ToString();

            buttonHarf.Enabled = true;
            torba = "";
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            zamanlayici--;
            if (zamanlayici == 10)
            {
                this.Text += "\t" + zamanlayici.ToString();
            }
            if (zamanlayici == 0)
            {
                timer1.Start();
                this.Text = "Kelime Oyunu";
                buttonDurdur.Enabled = false;
                buttonHarf.Enabled = false;
                buttonKontrol.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSure.Text = sure.ToString();
            sure--;

            if (sure == 0)
            {
                timer2.Stop();
                buttonDurdur.Enabled = false;
                buttonHarf.Enabled = false;
                buttonKontrol.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
            }
        }
    }
}