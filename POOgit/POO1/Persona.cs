using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit
{
    internal class Persona
    {
        private string nombre;
        private string apellidos;
        private int sueldo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }

    }
}
