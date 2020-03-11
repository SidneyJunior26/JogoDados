using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_Dados1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random NumeroRandomico = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayDado(pictureBox1);
        }

        public void DisplayDado(PictureBox Lado)
        {
            int face = NumeroRandomico.Next(1, 7);
            Lado.Image = Image.FromFile("C:\\Users\\sidne\\Downloads\\imagens\\die" + face + ".gif");
        }
    }
}
