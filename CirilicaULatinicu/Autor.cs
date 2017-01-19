using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CirilicaULatinicu
{
    public partial class Autor : Form
    {
        public Autor()
        {
            InitializeComponent();
            Bitmap s = Properties.Resources.ja;
            pictureBox1.Image = s;
            textBox1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
