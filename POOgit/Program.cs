using POOgit.POO2;
using POOgit.POO3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            ////POO CASA ///////////////////////////////////////////////////////////////////
            ////Instancia/crea el objeto, llama al constructor
            //casa casaObjeto = new casa();

            ////NOTA: el constructor se crea automaticamente o por defecto si no se declara

            ////Se accede a un atributo y se le da un valor
            //casaObjeto.color = "Rojo";

            ////Se manda a llamar un método
            //casaObjeto.Venta();

            ////Se crea un nuevo objeto, se llama al constructor con atributos
            //casa casaObjetoDos = new casa("Marrón");
            //casaObjetoDos.Venta();
            ////POO CASA ///////////////////////////////////////////////////////////////////


            ////POO INMUEBLES //////////////////////////////////////////////////////////////
            //inmueble inm1 = new inmueble("Casa de playa", 150000);
            //inm1.vender();

            //inmueble inm2 = new inmueble("Casa de campo", 200000);
            //inm2.alquilar();
            ////POO INMUEBLES //////////////////////////////////////////////////////////////

            //inmueble inm3 = new inmueble();
            //inm3._precioInmueble = 100000;
            //inm3._tipoInmueble = "Casa de granja";

            //inm3.verDatos();
            ////POO INMUEBLES //////////////////////////////////////////////////////////////

            ////POO HERENCIA ///////////////////////////////////////////////////////////////
            //casa casa1 = new casa("Casa veraniega", 500000);
            //casa1.verDatos();

            //departamento depa1 = new departamento("Depa campestre", 42000);
            //depa1.alquilar();
            ////POO HERENCIA ///////////////////////////////////////////////////////////////

            casa casa1 = new casa("Casa Veraniega", 150000);
            casa1.registrar();

            inmueble inm1 = new inmueble("Casa de campo", 150000);
            inm1.registrar();


            Console.ReadKey();
        }
    }
}
