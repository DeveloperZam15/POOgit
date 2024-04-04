using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit.POO3
{
    internal class inmueble
    {
        //ATRIBUTOS

        string tipoInmueble;

        string ubicacion;

        string area;

        int cuartos;

        int precioInmueble;
        
        //MÉTODOS
        public void registrar() { }

        public void vender() {
            Console.WriteLine(tipoInmueble + " ha dido vendida por el precio de " + precioInmueble);
        }

        public void alquilar() {
            Console.WriteLine(tipoInmueble + "ha dio alquilada por el precio de " + precioInmueble);
        }

        public void proyectoPreventa() { }

        //MÉTODO CONSTRUCTOR CON PARAMETROS

        public inmueble(string tipo, int precio) {
            tipo = tipoInmueble;
            precio = precioInmueble;

        }
    }
}
