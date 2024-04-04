using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit.POO2
{
    internal class casa
    {
        //Estado / atributos
        public string color;

        //Comportamientos/Métodos
        public void Venta() {
            Console.WriteLine("Casa de color " + color + " vendida");
        }

        //Constructor por defecto
        public casa() { }

        //Constructor con parametros
        public casa(string atColor) {
            color = atColor;
        }
    }
}
