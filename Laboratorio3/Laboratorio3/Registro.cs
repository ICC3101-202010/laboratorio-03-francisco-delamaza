using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Registro
    {
        private string cliente;
        private string cajero;
        private List<string> compras;
        private string fecha;

        static List<Registro> registro = new List<Registro>();

        public Registro(Cliente cliente,Cajero cajero,List<string> compras,string fecha)
        {
            this.cliente = cliente.Nombre;
            this.cajero = cajero.Nombre;
            this.compras = compras;
            this.fecha = fecha;
        }
        public void Añadir(Registro regis)

        {
            registro.Add(regis);

        }
        public void Info()
        {
            foreach(Registro r in registro)
            {
                Console.WriteLine();
                Console.WriteLine(r.fecha);
                Console.WriteLine();
                Console.WriteLine("Nombre cliente:");
                Console.WriteLine(r.cliente);
                Console.WriteLine();
                Console.WriteLine("Nombre cajero:");
                Console.WriteLine(r.cajero);
                Console.WriteLine();
                Console.WriteLine("Productos: ");
                foreach (string i in compras)
                {

                    Console.WriteLine(i);
                }
                Console.WriteLine();
                Console.WriteLine();
                
               
                

            }
        }
    }
}
