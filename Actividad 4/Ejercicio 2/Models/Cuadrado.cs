using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    internal class Cuadrado:Rectangulo
    {
        public Cuadrado(double largo, double ancho) : base(largo, ancho)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
