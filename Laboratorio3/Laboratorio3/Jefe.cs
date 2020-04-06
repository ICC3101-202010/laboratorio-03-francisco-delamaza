using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Jefe: Persona
    {
        List<Jefe> Jefes = new List<Jefe>();
        public Jefe(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string sexo)
            : base(rut, nombre, apellido, fecha_nacimiento, nacionalidad, sexo)
        {

        }
    }
}
