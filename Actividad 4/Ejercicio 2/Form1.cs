using Ejercicio_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        ArrayList misfiguras = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            misfiguras.Add(new Cuadrado(5, 5));
            misfiguras.Add(new Cuadrado(7, 7));
            misfiguras.Add(new Rectangulo(8, 4));
            misfiguras.Add(new Cuadrado(10, 5));
            misfiguras.Add(new Circulo(8));
            misfiguras.Add(new Circulo(5));
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            lbResult.Items.Add("Lista desordenada:");
            foreach(FIgura n in misfiguras)
            {
                lbResult.Items.Add(n.ToString()) ;
            }

            misfiguras.Sort();
            lbResult.Items.Add("\n");
            lbResult.Items.Add("Lista ordenada:");
            foreach(FIgura n in misfiguras)
            {
                lbResult.Items.Add(n.ToString());
            }

            lbResult.Items.Add("\n");
        }
    }
}
