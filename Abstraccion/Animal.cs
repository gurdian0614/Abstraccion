using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    internal abstract class Animal
    {
        public string? nombre;
        public string? color;
        public string? tamano;
        public string? familia;

        /**
         * Metodo para imprimir datos 
        */
        public abstract void imprimir();

        /**
         * Metodo para validar datos 
         */
        public abstract bool validar();
    }
}
