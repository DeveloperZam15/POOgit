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
            Desarrollador d1 = new Desarrollador();
            d1.Nombre = "Francisco";

            Console.WriteLine(d1.Nombre);

            Console.ReadKey();
        }
    }
}
