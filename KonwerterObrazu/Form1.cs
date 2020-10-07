using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KonwerterObrazu
{
    public partial class Form1 : Form
    {
        string obrazOrgPath = "";
        Bitmap obrazOrg, obrazNowy;
        Byte[,] tablicaKolorow, tablicaTestowa, tablicaPikow;
        int szerObrazu = 10, wysObrazu = 10;
        Byte limit, limitDolny, limitGorny;
        bool wczytanoLimity = false;
        public Form1()
        {
            InitializeComponent();
            progTextBox.Text = "15";
            progIITextBox.Text = "40";
            limitGornyTextBox.Text = "120";
        }

        private void obrazWczytanyPicBox_Click(object sender, EventArgs e)
        {
        }

        private void obrazPoKonwersjiPicBox_Click(object sender, EventArgs e)
        {
        }

        private void otworzObrazButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            if (dlg.FileName != null && dlg.FileName != "")
            {
                obrazOrgPath = dlg.FileName;
                obrazOrg = new Bitmap(obrazOrgPath);
                obrazWczytanyPicBox.Image = new Bitmap(obrazOrg);
                
                WczytajParametryObrazu();
                PobierzInformacjeOKolorach(obrazOrg);
                
                konwertujButton.Enabled = true;
            }
        }
        private void WczytajParametryObrazu()
        {
            szerObrazu = obrazOrg.Width;
            wysObrazu = obrazOrg.Height;
            tablicaKolorow = new Byte[szerObrazu, wysObrazu];
            obrazNowy = new Bitmap(szerObrazu, wysObrazu);
        }
        private void PobierzInformacjeOKolorach(Bitmap obraz)
        {
            for (int i = 0; i < szerObrazu; i++)
            {
                for (int j = 0; j < wysObrazu; j++)
                {
                    Byte kolor = obraz.GetPixel(i, j).R;
                    tablicaKolorow[i, j] = kolor;
                }
            }
        }

        private void konwertujButton_Click(object sender, EventArgs e)
        {
            tablicaTestowa = new Byte[szerObrazu, wysObrazu];
            tablicaPikow = new Byte[szerObrazu, wysObrazu];
            konwertujButton.Enabled = false;
            WczytajLimity();
            if (wczytanoLimity)
            {
                ObliczNowyObraz();
                KonwertujObrazNaNowy();
            }
            konwertujButton.Enabled = true;
            zapiszNowyButton.Enabled = true;
        }
        private void WczytajLimity()
        {
            try
            {
                limit = Byte.Parse(progTextBox.Text);
                limitDolny = Byte.Parse(progIITextBox.Text);
                limitGorny = Byte.Parse(limitGornyTextBox.Text);
                wczytanoLimity = true;
            }
            catch
            {
                MessageBox.Show("Podaj wartość progu z przedziału 1 do 255 jako liczbę całkowitą");
                wczytanoLimity = false;
            }
        }
        private void ObliczNowyObraz()
        {
            wyszukajPiki();
            for (int i = 0; i < szerObrazu; i++)
            {
                for (int j = 0; j < wysObrazu; j++)
                {
                    ObliczNowyPiksel(i, j);
                }
            }
            obrazPoKonwersjiPicBox.Image = obrazNowy;
        }
        //wyszukuje piki w obrazie
        private void wyszukajPiki()
        {
            for (int i = 0; i < szerObrazu; i++)
            {
                for (int j = 0; j < wysObrazu; j++)
                {
                    sprawdzCzyPikselJestPikiem(i, j);
                    UsunPikPowyzejLimitu(i, j);
                }
            }
        }
        private void sprawdzCzyPikselJestPikiem(int x, int y)
        {
            //szuka pików i zapisuje w tablicy pików
            if (x > 0 && x < szerObrazu - 1)
            {
                if (tablicaKolorow[x, y] - tablicaKolorow[x - 1, y] < 0 && tablicaKolorow[x + 1, y] - tablicaKolorow[x, y] > 0)
                {
                    tablicaPikow[x, y] = 1;
                }
                else
                {
                    tablicaPikow[x, y] = 0;
                }
            }
            else
            {
                tablicaPikow[x, y] = 0;
            }
        }
        private void UsunPikPowyzejLimitu(int x, int y)
        {
            if (tablicaKolorow[x, y] > limitGorny)
            {
                tablicaPikow[x, y] = 0;
            }
        }

        //główna metoda przechowująca zasady konwersji
        private void ObliczNowyPiksel(int x, int y)
        {
            //wczytaj najciemniejsze kolory na sztywno
            if (tablicaKolorow[x, y] <= limitDolny)
            {
                tablicaTestowa[x, y] += 1;
            }

            //rozbudowuje piki
            if (tablicaPikow[x, y] == 1)
            {
                RozbudujPikwObrebiePiksela(x, y);
            }

            //usunięcie koloru powyżej limitu górnego
            if (tablicaKolorow[x, y] > limitGorny)
            {
                tablicaTestowa[x, y] = 0;
            }

            //if (tablicaKolorow[x, y] - tablicaKolorow[x - 1, y] < -limit)
            //{
            //    tablicaTestowa[x, y] += 1;
            //}

            //if (tablicaKolorow[x + 1, y] - tablicaKolorow[x, y] > limit)
            //{
            //    tablicaTestowa[x, y] += 1;
            //}

            //szukamy pika sięgającego ponad próg, 
            //następnie na lewo i prawo szukamy podstawy pika
            //odsuwamy kolor od granicy o 1-3 px

            //if (tablicaKolorow[x, y] - tablicaKolorow[x - 1, y] > 0 && tablicaKolorow[x + 1, y] - tablicaKolorow[x, y] < 0)
            //{
            //    if (tablicaKolorow[x, y] < limitDolny)
            //    {
            //        tablicaTestowa[x, y] += 1;
            //    }
            //    else
            //    {
            //    }
            //}
            //if (x > 3 && x < szerObrazu - 3)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        tablicaTestowa[x - 2 + i, y] += 1;
            //    }
            //}

            //usuń powyżej limitu
            if (tablicaKolorow[x, y] >= limit)
            {
                tablicaTestowa[x, y] = 0;
            }
        }
        private void RozbudujPikwObrebiePiksela(int x, int y)
        {
            double kolor = (255-tablicaKolorow[x,y])/100;
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    if (x > 5 && x < szerObrazu - 1 - a && y > 5 && y < wysObrazu - 1 - b && tablicaKolorow[x - 5 + a, y - 5 + b] - tablicaKolorow[x, y] < kolor)
                    {
                        tablicaTestowa[x - 5 + a, y - 5 + b] = 1;
                    }
                }
            }
        }

        private void KonwertujObrazNaNowy()
        {
            for (int i = 0; i < szerObrazu; i++)
            {
                for (int j = 0; j < wysObrazu; j++)
                {
                   KonwertujPiksel(i, j);
                }
            }
        }
        private void KonwertujPiksel(int x, int y)
        {
            if (tablicaTestowa[x, y] >= 1)
            {
                obrazNowy.SetPixel(x, y, Color.Black);
            }
            else
            {
                obrazNowy.SetPixel(x, y, Color.White);
            }
        }
       

        private void zapiszNowyButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".bmp";
            dlg.ShowDialog();
            if (dlg.FileName != "")
            {
                obrazNowy.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
            else
            {
                MessageBox.Show("Nie podano nazwy obrazu wyjściowego");
            }
        }

        private void progTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void progIITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void limitGornyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
