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
            Producto prop = new Producto(" ", 0, " ", 6);
            Cliente ccc = new Cliente(" ", " ", " ", " ", " ", " ");
            Cajero jer = new Cajero(" ", " ", " ", " ", " ", " "," ");
            List<Producto> hola = new List<Producto> { prop };
            var list = new List<Cajero>();
            Registro los = new Registro(ccc, jer,hola );
            bool showMenu = true;
            while (showMenu)
            {
                Console.WriteLine("Cree trabajadores y productos, al estar listo presione elija comprar.");
                Console.WriteLine();
                Console.WriteLine("1) Crear persona:");
                Console.WriteLine("2) Crear productos:");
                Console.WriteLine("3) Comprar: ");
                Console.WriteLine();
                string x = Console.ReadLine();

                if (x == "1")
                {
                    Console.WriteLine("Rut:");
                    string a = Console.ReadLine();
                    Console.WriteLine("Nombre:");
                    string b = Console.ReadLine();
                    Console.WriteLine("Apellido:");
                    string c = Console.ReadLine();
                    Console.WriteLine("Fecha de nacimiento::");
                    string d = Console.ReadLine();
                    Console.WriteLine("Nacionalidad:");
                    string e = Console.ReadLine();
                    Console.WriteLine("Sexo:");
                    string f = Console.ReadLine();
                    Console.WriteLine("Trabajo(Ej: Auxiliar, Cajero, Jefe, Supervisor.):");
                    string g = Console.ReadLine();
                   if (g == "Auxiliar")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sueldo:");
                        string h = Console.ReadLine();
                        Auxiliar aux = new Auxiliar(a, b, c, d, e, g, h);

                    }
                    if (g == "Cajero")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sueldo:");
                        string h = Console.ReadLine();
                        Cajero caj = new Cajero(a, b, c, d, e, g, h);
                        
                        list.Add(caj);
                        

                    }
                    if (g == "Supervisor")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sueldo:");
                        string h = Console.ReadLine();
                        Supervisor sup = new Supervisor(a, b, c, d, e, g ,h);

                    }
                    if (g == "Jefe")
                    {
                        Jefe jef = new Jefe(a, b, c, d, e, g);

                    }
                   
        
                }
                if (x == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Nombre del producto:");
                    string a = Console.ReadLine();
                    Console.WriteLine("Precio:");
                    int u;
                    u = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Marca:");
                    string c = Console.ReadLine();
                    Console.WriteLine("Stock:");
                    int y;
                    y = Convert.ToInt32(Console.ReadLine());

                    Producto pro = new Producto(a, u, c, y);
                    prop.AgregarProducto(pro);
                   

                }
                if (x == "3")
                {
                    
                       
                    
                
                        bool sMenu = true;
                    while (sMenu)
                    {


                        var productoscomprados = new List<Producto>();
                        Console.WriteLine("Datos del Cliente");
                        Console.WriteLine();
                        Console.WriteLine("Rut:");
                        string a = Console.ReadLine();
                        Console.WriteLine("Nombre:");
                        string b = Console.ReadLine();
                        Console.WriteLine("Apellido:");
                        string c = Console.ReadLine();
                        Console.WriteLine("Fecha de nacimiento::");
                        string d = Console.ReadLine();
                        Console.WriteLine("Nacionalidad:");
                        string e = Console.ReadLine();
                        Console.WriteLine("Sexo:");
                        string f = Console.ReadLine();
                        Cliente cli = new Cliente(a, b, c, d, e, f);
                        ccc.Registroclientes(cli);
                        Console.WriteLine();
                        Console.WriteLine("Agregar productos al carrito, al finalizar ingrese comprar ");
                        bool cMenu = true;
                        while (cMenu)
                        {
                            string t = Console.ReadLine();
                            if (t == "comprar")
                            {
                                var random = new Random();
                                int index = random.Next(list.Count);

                                Registro r = new Registro(cli, list[index], productoscomprados);
                                los.Añadir(r);
                                Console.WriteLine("1) Nuevo cliente");
                                Console.WriteLine("2) Mostrar registro");
                                Console.WriteLine("3) Salir");
                                Console.WriteLine();
                                string z = Console.ReadLine();
                                if(z=="1")
                                {
                                    cMenu = false;

                                }
                                if(z=="2")
                                {
                                    r.Info();
                                    Console.WriteLine("1)Para salir:");
                                    Console.WriteLine("2)Para agregar un nuevo cliente");
                                    string ñ = Console.ReadLine();
                                    if(ñ=="1")
                                    {
                                        break;
                                    }
                                    if(ñ=="2")
                                    {
                                        cMenu = false;
                                    }
                                    
                                }
                                if(z=="3")
                                {
                                    break;
                                }
                                
                            }
                            else
                            {

                                prop.ComprarProducto(t);

                            }
                        }
                    }
                       

                    
                

                }



            }

        }
    }
}
