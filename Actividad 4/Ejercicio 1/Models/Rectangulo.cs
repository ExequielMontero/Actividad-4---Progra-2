using Ejercicio_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1.Models
{
    internal class Rectangulo:Ifigura, IComparable
    {
        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double Largo { get; private set; }
        public double Ancho {  get; private set; }

        public double CalcularArea()
        {
            
            return Ancho * Largo;
            
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        public int CompareTo(object obj)
        {
            Rectangulo b = obj as Rectangulo;
            if (b != null)
            {
                return CalcularPerimetro().CompareTo(b.CalcularPerimetro());
            }
            return 1;
        }

        public override string ToString()
        {
            return "Largo del rectangulo: " + Largo + ", Ancho: " + Ancho + ", Area: " + CalcularArea() + ", Perimetro: " + CalcularPerimetro();
        }



    }
}
