using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit
{
    internal class Coche
    {
        //DECLARACIÓN DE VARIABLES

        private int id;
        private string marca;
        private string modelo;
        private int km; 
        private double precio;

        //MÉTODO CONSTRUCTOR
        public Coche(int id, string marca, string modelo, int km, double precio)
        {
            this.Id = id;                                                                                                                                                                                                                                       
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
        }

        //ENCAMPSULAMIENTO DE CAMPOS
        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public double Precio { get => precio; set => precio = value; }


        //MÉTODO PARA MOSTRAR LAS VARIABLES EN CIERTO FORMATO
        public override string ToString()
        {
            return "Marca: " + marca + ", modelo: "+ modelo+" con un precio de "+precio;
        }
    }
}
