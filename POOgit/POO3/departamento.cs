using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit.POO3
{
    internal class departamento : inmueble
    {
        //Atributos propios

        //Métodos propios
        public departamento(string tipoDepartamento, int precio)
        {
            tipoInmueble = tipoDepartamento;
            precioInmueble = precio;
        }
    }
}
