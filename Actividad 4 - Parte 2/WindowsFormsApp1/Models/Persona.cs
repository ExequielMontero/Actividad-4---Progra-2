using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class Persona:IComparable
    {
        public Persona(int dni, string name)
        {
            Dni = dni;
            Name = name;
        }

        public Persona(int dni)
        {
            Dni = dni;
        }

        public int Dni { get; private set; }
        public string Name { get; private set; }

        public int CompareTo(object obj)
        {
            Persona b = obj as Persona;
            if (b != null)
            {
                return Dni.CompareTo(b.Dni);
            }
            return 1;
        }

        public override string ToString()
        {
            return Name + "," + Dni;
        }

    }
}
