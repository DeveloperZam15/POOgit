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

       protected string tipoInmueble;

        protected string ubicacion;

        protected string area;

        protected int cuartos;

        protected int precioInmueble;

        //PROPIEDADES SET Y GET O MODIFICADORES DE ACCESO

        public string _tipoInmueble 
        { get => tipoInmueble; set => tipoInmueble = value; }

        public string _ubicacion 
        { get => ubicacion; set => ubicacion = value; }

        public string _area 
        { get => area; set => area = value; }

        public int _cuartos 
        { get => cuartos; set => cuartos = value; }

        public int _precioInmueble 
        { get => precioInmueble; set => precioInmueble = value; }


        //MÉTODOS
        public void registrar() { }

        public void verDatos() {
            Console.WriteLine("El espacio " +tipoInmueble+ " tiene un costo de " +precioInmueble);
        }

        public void vender() {
            Console.WriteLine(tipoInmueble + " ha sido vendida por el precio de " + precioInmueble);
        }

        public void alquilar() {
            Console.WriteLine(tipoInmueble + " ha sido alquilada por el precio de " + precioInmueble);
        }

        public void proyectoPreventa() { }

        //MÉTODO CONSTRUCTOR CON PARAMETROS

        public inmueble(string tipo, int precio) {
            tipoInmueble = tipo;
            precioInmueble = precio;

        }

        //MÉTODO CONSTRUCTOR VACIO
        public inmueble() { }
    }
}
