
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    internal class Rectangulo:FIgura, IComparable
    {
        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public override double CalcularArea()
        {

            return Ancho * Largo;

        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        public int CompareTo(object obj)
        {
            Rectangulo b = obj as Rectangulo;
            if (b != null)
            {
                return CalcularArea().CompareTo(b.CalcularArea());
            }
            return 1;
        }

        public override string ToString()
        {
            return "Largo del rectangulo: " + Largo + ", Ancho: " + Ancho + ", Area: " + CalcularArea() + ", Perimetro: " + CalcularPerimetro();
        }

    }
}
