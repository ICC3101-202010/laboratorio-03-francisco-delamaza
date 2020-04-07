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
        private List<Producto> compras;

        static List<Registro> registro = new List<Registro>();

        public Registro(Cliente cliente,Cajero cajero,List<Producto> compras)
        {
            this.cliente = cliente.Nombre;
            this.cajero = cajero.Nombre;
            this.compras = compras;
        }
        public void Añadir(Registro regis)

        {
            registro.Add(regis);

        }
        public void Info()
        {
            foreach(Registro r in registro)
            {
                Console.WriteLine("Nombre cliente:");
                Console.WriteLine(r.cliente);
                Console.WriteLine("Nombre cajero:");
                Console.WriteLine(r.cajero);
                foreach (Producto i in compras)
                {
                    Producto p = i;
                    p.InformacionP();
                }
               
                

            }
        }
    }
}
