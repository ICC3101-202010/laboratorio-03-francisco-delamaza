using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajero p = new Cajero("hugo", "f", "d", "y", "d","e");
            p.Hola();
            Console.ReadKey();

        }
    }
}
