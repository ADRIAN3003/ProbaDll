using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaDll
{
    public class Szamol
    {
        /// <summary>
        /// A <paramref name="x"/> és a <paramref name="y"/> egész számok összegét adja.
        /// </summary>
        /// <param name="x">Első egész operandus</param>
        /// <param name="y">Második egész operandus</param>
        /// <returns><paramref name="x"/>+<paramref name="y"/></returns>
        public int Osszead(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// A <paramref name="x"/> és a <paramref name="y"/> egész számok szorzatát adja.
        /// </summary>
        /// <param name="x">Első egész operandus</param>
        /// <param name="y">Második egész operandus</param>
        /// <returns><paramref name="x"/>*<paramref name="y"/></returns>
        public int Szorzat(int x, int y)
        {
            return x * y;
        }
    }
}
