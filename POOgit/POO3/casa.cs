using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit.POO3
{
    internal class casa : inmueble
    {
        //Atributos propios

        //Métodos propios
        public casa(string tipoCasa, int precio) {
            tipoInmueble = tipoCasa;
            precioInmueble = precio;
        
        }
    }
}
