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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ArrayList lista = new ArrayList();
        Controladora controladora = new Controladora();
        
        public Form1()
        {
            InitializeComponent();
            lista.Add(new Persona(4343433, "Julia"));
            lista.Add(new Persona(2343422, "Estefanía"));
            lista.Add(new Persona(32443433, "Rebeca"));
            lista.Add(new Persona(31343433, "Eduardo"));
            lista.Add(new Persona(10643433, "Lucia"));
            lista.Add(new Persona(40643433, "Reinaldo"));


        }

        private void btnPrueba_Click(object sender, EventArgs e)
       {
            lbResult.Items.Clear();
            lbResult.Items.Add("-Lista Desordenada:");
            foreach(Persona n in lista)
            {
                lbResult.Items.Add(n.ToString());
            }

            lbResult.Items.Add("\n");

            /*lista.Sort();*/  // Ordenando con el metodo Sort que usa Interface Icomparable
            controladora.MetodoBurbuja(lista);
            lbResult.Items.Add("-Lista Ordenada:");
            foreach(Persona n in lista)
            {
                lbResult.Items.Add(n.ToString());
            }

        }

        private void btnDni_Click(object sender, EventArgs e)
        {
            lbResult.Items.Clear();
            /* lista.Sort();*/  // Ordenando con el metodo Sort que usa Interface Icomparable
            controladora.MetodoBurbuja(lista);
            int dni = Convert.ToInt32(tbDni.Text);
            //int idx = lista.BinarySearch(new Persona(dni));  /*Quiero Probar el metodo por biseccion
            //if(idx >= 0)                                       Y ver si funciona igual*/  
            //{                                                        
            //    Persona b = (Persona)lista[idx];                      
            //    lbResult.Items.Add(b);
            //}
            //else
            //{
            //    lbResult.Items.Add("No encontrado");              
            //}

            int idx = controladora.MetodoBinario(lista, dni); //Usando el metodo por Biseccion
            if (idx >= 0)                                     /*y funciona igual que el BinarySeach*/
            {                                                                         
                Persona b = (Persona)lista[idx];
                lbResult.Items.Add(b);
            }
            else if(idx==-1)
            {
                lbResult.Items.Add("No encontrado");
            }

        }
    }
}
