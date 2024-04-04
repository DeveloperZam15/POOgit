using POOgit.POO2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOgit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia/crea el objeto, llama al constructor
            casa casaObjeto = new casa();

            //NOTA: el constructor se crea automaticamente o por defecto si no se declara

            //Se accede a un atributo y se le da un valor
            casaObjeto.color = "Rojo";

            //Se manda a llamar un método
            casaObjeto.Venta();

            //Se crea un nuevo objeto, se llama al constructor con atributos
            casa casaObjetoDos = new casa("Marrón");
            casaObjetoDos.Venta();

            Console.ReadKey();
        }
    }
}
