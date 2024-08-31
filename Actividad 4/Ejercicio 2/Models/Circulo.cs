using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    internal class Circulo:FIgura, IComparable
    {
        public double Radio { get; private set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public int CompareTo(object obj)
        {
            Circulo b = obj as Circulo;
            if (b != null)
            {
                return CalcularArea().CompareTo(b.CalcularArea());
            }
            return 1;
        }

        public override string ToString()
        {
            return "Radio del circulo: " + Radio + ", Area: " + CalcularArea() + ", Perimetro: " + CalcularPerimetro();
        }
    }
}
