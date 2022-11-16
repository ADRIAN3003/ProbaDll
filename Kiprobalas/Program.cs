using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProbaDll;

namespace Kiprobalas
{
    class Program
    {
        static void Main(string[] args)
        {
            Szamol sz = new Szamol();

            Console.WriteLine(sz.Osszead(3, 2));
            Console.WriteLine(sz.Szorzat(4, 12));

            Console.ReadKey();
        }
    }
}
