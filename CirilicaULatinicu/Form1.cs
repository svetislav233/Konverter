using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirilicaULatinicu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cirilica = textBox1.Text;
            string latinica = "";
            for (int i = 0; i < cirilica.Length; i++)
            {
                if (cirilica[i] == 'љ')
                {
                    latinica += "lj";
                }
                else if (cirilica[i] == 'њ')
                {
                    latinica += "nj";
                }
                else if (cirilica[i] == 'е')
                {
                    latinica += "e";
                }
                else if (cirilica[i] == 'р')
                {
                    latinica += "r";
                }
                else if (cirilica[i] == 'т')
                {
                    latinica += "t";
                }
                else if (cirilica[i] == 'з')
                {
                    latinica += "z";
                }
                else if (cirilica[i] == 'у')
                {
                    latinica += "u";
                }
                else if (cirilica[i] == 'и')
                {
                    latinica += "i";
                }
                else if (cirilica[i] == 'о')
                {
                    latinica += "o";
                }
                else if (cirilica[i] == 'п')
                {
                    latinica += "p";
                }
                else if (cirilica[i] == 'ш')
                {
                    latinica += "š";
                }
                else if (cirilica[i] == 'а')
                {
                    latinica += "a";
                }
                else if (cirilica[i] == 'с')
                {
                    latinica += "s";
                }
                else if (cirilica[i] == 'д')
                {
                    latinica += "d";
                }
                else if (cirilica[i] == 'ф')
                {
                    latinica += "f";
                }
                else if (cirilica[i] == 'ђ')
                {
                    latinica += "đ";
                }
                else if (cirilica[i] == 'г')
                {
                    latinica += "g";
                }
                else if (cirilica[i] == 'х')
                {
                    latinica += "h";
                }
                else if (cirilica[i] == 'ј')
                {
                    latinica += "j";
                }
                else if (cirilica[i] == 'к')
                {
                    latinica += "k";
                }
                else if (cirilica[i] == 'л')
                {
                    latinica += "l";
                }
                else if (cirilica[i] == 'ч')
                {
                    latinica += "č";
                }
                else if (cirilica[i] == 'ћ')
                {
                    latinica += "ć";
                }
                else if (cirilica[i] == 'ж')
                {
                    latinica += "ž";
                }
                else if (cirilica[i] == 'џ')
                {
                    latinica += "dž";
                }
                else if (cirilica[i] == 'ц')
                {
                    latinica += "c";
                }
                else if (cirilica[i] == 'в')
                {
                    latinica += "v";
                }
                else if (cirilica[i] == 'б')
                {
                    latinica += "b";
                }
                else if (cirilica[i] == 'н')
                {
                    latinica += "n";
                }
                else if (cirilica[i] == 'м')
                {
                    latinica += "m";
                }
                else if (cirilica[i] == 'Љ')
                {
                    latinica += "Lj";
                }
                else if (cirilica[i] == 'Њ')
                {
                    latinica += "Nj";
                }
                else if (cirilica[i] == 'Е')
                {
                    latinica += "E";
                }
                else if (cirilica[i] == 'Р')
                {
                    latinica += "R";
                }
                else if (cirilica[i] == 'Т')
                {
                    latinica += "T";
                }
                else if (cirilica[i] == 'З')
                {
                    latinica += "Z";
                }
                else if (cirilica[i] == 'У')
                {
                    latinica += "U";
                }
                else if (cirilica[i] == 'И')
                {
                    latinica += "I";
                }
                else if (cirilica[i] == 'П')
                {
                    latinica += "P";
                }
                else if (cirilica[i] == 'Ш')
                {
                    latinica += "Š";
                }
                else if (cirilica[i] == 'Ђ')
                {
                    latinica += "Đ";
                }
                else if (cirilica[i] == 'Ж')
                {
                    latinica += "Ž";
                }
                else if (cirilica[i] == 'Џ')
                {
                    latinica += "Dž";
                }
                else if (cirilica[i] == 'А')
                {
                    latinica += "A";
                }
                else if (cirilica[i] == 'С')
                {
                    latinica += "S";
                }
                else if (cirilica[i] == 'Д')
                {
                    latinica += "D";
                }
                else if (cirilica[i] == 'Ф')
                {
                    latinica += "F";
                }
                else if (cirilica[i] == 'Х')
                {
                    latinica += "H";
                }
                else if (cirilica[i] == 'Ј')
                {
                    latinica += "J";
                }
                else if (cirilica[i] == 'К')
                {
                    latinica += "K";
                }
                else if (cirilica[i] == 'Л')
                {
                    latinica += "L";
                }
                else if (cirilica[i] == 'Ч')
                {
                    latinica += "Č";
                }
                else if (cirilica[i] == 'Ц')
                {
                    latinica += "C";
                }
                else if (cirilica[i] == 'В')
                {
                    latinica += "V";
                }
                else if (cirilica[i] == 'Б')
                {
                    latinica += "B";
                }
                else if (cirilica[i] == 'Н')
                {
                    latinica += "N";
                }
                else if(cirilica[i] == 'М')
                {
                    latinica += "M";
                }
                else
                {
                    latinica += cirilica[i];
                }

            }
            textBox2.Text = latinica;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void konvertujFajlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autor a = new Autor();
            a.Show();
        }
    }
}
