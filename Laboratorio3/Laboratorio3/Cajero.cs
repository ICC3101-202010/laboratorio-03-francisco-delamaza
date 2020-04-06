using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Cajero : Persona
    {
        List<Cajero> Cajeros = new List<Cajero>();
        public Cajero(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string sexo)
            : base(rut,nombre,apellido,fecha_nacimiento,nacionalidad,sexo)
        {

        }

        public String Hola()
        {
            return $"{Nombre},{Apellido},{Rut}";
        }
    }
}
