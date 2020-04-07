using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Cliente : Persona
    {

        List<Cliente> Clientes = new List<Cliente>();
        public List<Producto> compras;
        public Cliente(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string sexo)
            : base(rut, nombre, apellido, fecha_nacimiento, nacionalidad, sexo)
        {

        }

        public void Registroclientes(Cliente cliente)
        {
            Clientes.Add(cliente);

        }
        
        public void Comprar()
        {

        }


    }
}
