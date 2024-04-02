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
            Coche c = new Coche(1, "Lambo", "95", 100, 12000);
            Console.WriteLine(c.Precio);
            Console.WriteLine(c.Marca);
            c.Precio = 15000;
            Console.WriteLine(c.Precio);
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
