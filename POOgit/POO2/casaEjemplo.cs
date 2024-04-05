using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit.POO2
{
    internal class casaEjemplo
    {
        //Estado / atributos
        public string color;

        //Comportamientos/Métodos
        public void Venta() {
            Console.WriteLine("Casa de color " + color + " vendida");
        }

        //Constructor por defecto
        public casaEjemplo() { }

        //Constructor con parametros
        public casaEjemplo(string atColor) {
            color = atColor;
        }
    }
}
