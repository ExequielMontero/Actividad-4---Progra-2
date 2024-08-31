using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Rectangulo cuadrado = new Cuadrado(5, 5);
        Rectangulo rectangulo = new Rectangulo(8, 4);
        Circulo circulo = new Circulo(2);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            lbResult.Items.Add(cuadrado);
            lbResult.Items.Add("------------------------------------------------------------------");
            lbResult.Items.Add(rectangulo);
            lbResult.Items.Add("------------------------------------------------------------------");
            lbResult.Items.Add(circulo);
            lbResult.Items.Add("------------------------------------------------------------------");

        }
    }
}
