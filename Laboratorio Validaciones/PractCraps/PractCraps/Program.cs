using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractCraps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Craps juego = new Craps();

            juego.Jugar();
        }
    }
}
