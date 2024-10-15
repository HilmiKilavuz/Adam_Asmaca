using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca2
{
    public partial class Form1 : Form

    {
        #region Variables
        List<String> iller = new List<string> {
    "adana", "adıyaman", "afyonkarahisar", "ağrı", "aksaray", "amasya", "ankara", "antalya", "ardahan", "artvin",
    "aydın", "balıkesir", "bartın", "batman", "bayburt", "bilecik", "bingöl", "bitlis", "bolu", "burdur", "bursa",
    "çanakkale", "çankırı", "çorum", "denizli", "diyarbakır", "düzce", "edirne", "elazığ", "erzincan", "erzurum",
    "eskişehir", "gaziantep", "giresun", "gümüşhane", "hakkari", "hatay", "ığdır", "ısparta", "istanbul", "izmir",
    "kahramanmaraş", "karabük", "karaman", "kars", "kastamonu", "kayseri", "kırıkkale", "kırklareli", "kırşehir",
    "kilis", "kocaeli", "konya", "kütahya", "malatya", "manisa", "mardin", "mersin", "muğla", "muş", "nevşehir",
    "niğde", "ordu", "osmaniye", "rize", "sakarya", "samsun", "şanlıurfa", "siirt", "sinop", "sivas", "şırnak",
    "tekirdağ", "tokat", "trabzon", "tunceli", "uşak", "van", "yalova", "yozgat", "zonguldak"

        };
        int yanlısCevap;
        Random random;
        string secilenKelime;
        char[] yazılacakKelime;
        List<string> olmayanHarflerdizisi = new List<string>();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char tahmin = tahminKutusu.Text.ToLower()[0];
            bool dogruTahmin = false;
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i] == tahmin)
                {
                    yazılacakKelime[i] = tahmin;
                    dogruTahmin = true;

                }
            }
            cıkanSehir.Text = string.Join(" ", yazılacakKelime);
            if (!dogruTahmin)
            {
                fotoyuGuncelle();
            }
            if (!cıkanSehir.Text.Contains("_"))
            {
                MessageBox.Show("Tebrikler Kazandınız!");
                Application.Restart();
            }
            
            if (!cıkanSehir.Text.Contains(tahmin))
            {
             string tahminString = tahmin.ToString();
                if (!olmayanHarflerdizisi.Contains(tahminString))
                {
                 olmayanHarflerdizisi.Add(tahminString);
                } 
                
               
                if (!olmayanHarfler.Text.Contains(tahmin))
            {
                olmayanHarfler.Text = string.Join(" ", olmayanHarflerdizisi);
            }
            }
            


        }

        private void olmayanHarfler_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          



            yanlısCevap = 0;
            random = new Random();
            secilenKelime = iller[random.Next(iller.Count)];
            yazılacakKelime = new string('_', secilenKelime.Length).ToCharArray();
            string duzenlenmisYazılacakKelime = string.Join(" ", yazılacakKelime);
            cıkanSehir.Text = duzenlenmisYazılacakKelime;





        }

        private void fotoyuGuncelle()
        {
            yanlısCevap++;
            switch (yanlısCevap)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.BoşAsma;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Kafa;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Govde;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Kol1;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Kol2;

                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Bacak1;

                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Bacak2;
                    MessageBox.Show("Kaybettiniz Asıl Şehir  " + secilenKelime);
                    Application.Restart();

                    break;

            }

        }

        private void tahminKutusu_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                button1.PerformClick();
            }
        }

        private void tahminKutusu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                button1.PerformClick();
            }

        }
    }
}

