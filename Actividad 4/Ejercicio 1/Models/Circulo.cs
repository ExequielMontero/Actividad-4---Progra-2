using Ejercicio_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Circulo:Ifigura, IComparable
    {
        public double Radio { get; private set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public int CompareTo(object obj)
        {
            Circulo b = obj as Circulo;
            if (b != null)
            {
                return CalcularPerimetro().CompareTo(b.CalcularPerimetro());
            }
            return 1;
        }

        public override string ToString()
        {
            return "Radio del circulo: " + Radio + ", Area: " + CalcularArea() + ", Perimetro: " + CalcularPerimetro();
        }

    }
}
