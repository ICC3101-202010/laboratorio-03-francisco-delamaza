using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Producto
    {
        private string nombre;
        private int precio;
        private string marca;
        private int stock;

        List<Producto> productos = new List<Producto>();
        public Producto(string nombre, int precio, string marca, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.stock = stock;
        }
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
            Console.WriteLine("producto agregado");
            Console.WriteLine(productos[0].nombre);
        }
        public string InformacionP()
        {
            return $" nombre: {nombre}, precio: {precio}, marca: {marca}, stock: {stock}";
        }
        public void ComprarProducto(string product)
        {

            int l = 0;
            
            foreach (Producto i in productos)
            {
                Producto p = i;
                
                
                if (p.nombre==product && p.stock > 0)
                {
                    
                    p.stock -= 1;
                    Console.WriteLine("Producto agregado");
                    Console.WriteLine();
                    Console.WriteLine(p.InformacionP());

                    
                    
                }
                else if (p.nombre.Equals(product) && p.stock == 0)
                {
                    Console.WriteLine("Producto sin stock");

                }
                else
                {
                    l++;
                }
                
                
            }
            if( l == productos.Count)
            {
                Console.WriteLine("El producto no existe");
            }
            
        }
    }
}
