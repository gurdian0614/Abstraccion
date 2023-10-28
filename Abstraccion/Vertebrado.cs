using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    internal class Vertebrado : Animal
    {
        public string? tipo;
        public bool tienePatas;
        public bool esDomestico;
        public bool esHerviboro;
        public bool esCarnivoro;

        public override void imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Color: " + color);
            if (validar())
            {
                Console.WriteLine("Tipo: " + tipo);
            }
            Console.WriteLine("Tiene Patas: " + tienePatas);
            Console.WriteLine("Es doméstico: " + esDomestico);
            Console.WriteLine("Es hervíboro: " + esHerviboro);
            Console.WriteLine("Es carnívoro: " + esCarnivoro);
            
        }

        public override bool validar()
        {
            if (tipo != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
