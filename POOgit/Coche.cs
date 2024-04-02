using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit
{
    internal class Coche
    {
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private double precio;

        public Coche(int id, string marca, string modelo, int km, double precio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return "Marca: " + marca + ", modelo: "+ modelo+" con un precio de "+precio;
        }
    }
}
