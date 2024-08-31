using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class Controladora
    {
        //Voy a probar si el metodo burbuja funciona como el .Sort

        public void MetodoBurbuja(ArrayList milista)
        {
            Persona uno;
            Persona dos;
            for(int i = 0; i < milista.Count-1; i++)
            {
                uno = milista[i] as Persona;
                for(int n = i+1; n < milista.Count; n++)
                {
                    dos = milista[n] as Persona;
                    if (uno.Dni > dos.Dni)
                    {
                        Persona aux = milista[n] as Persona;
                        milista[n] = milista[i];
                        milista[i] = aux;
                    }
                }
            }
        }
       
        //Voy a probar si el Metodo Binrio funciona como el BinarySeach

        public int MetodoBinario(ArrayList milista, int buscado)
        {
            int izq = 0, der, medio, ret = -1;
            der = milista.Count - 1;
            do
            {
                medio = (izq + der) / 2;
                Persona b = (Persona)milista[medio];
                if ( b.Dni == buscado)
                {
                    ret = medio;
                }
                else if(b.Dni < buscado)
                {
                    izq = medio + 1;
                }
                else
                {
                    der = medio - 1;
                }

            } while (izq <= der && ret == -1);
            return ret;
        }



    }
}
