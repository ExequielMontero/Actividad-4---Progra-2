using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.CodeDom;
using Ejercicio_2.Models;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        ArrayList milista = new ArrayList();
        Datos cargar = new Datos();
        public Form1()
        {
            InitializeComponent();
            milista.Add(new Persona(3243433, "Javier"));
            milista.Add(new Persona(2343423, "Aldana"));
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbDni.Text);
            cargar.tbDni.Text = Convert.ToString(dni);
            milista.Sort();
            int idx = milista.BinarySearch(new Persona(dni));
            if (idx >= 0)
            {
               tbResult.Clear();
               tbResult.Text = milista[idx].ToString();
            }
            else
            {
                if(cargar.ShowDialog() == DialogResult.OK)
                {
                    string nombre = cargar.tbNombre.Text;
                    milista.Add(new Persona(dni, nombre));
                }
            }
            tbDni.Clear();
            cargar.tbNombre.Clear();
        }
    }
}
