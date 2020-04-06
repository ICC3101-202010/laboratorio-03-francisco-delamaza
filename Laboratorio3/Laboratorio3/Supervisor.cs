using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Supervisor : Persona
    {
        List<Supervisor> Supervisores = new List<Supervisor>();
        public Supervisor(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string sexo)
            : base(rut, nombre, apellido, fecha_nacimiento, nacionalidad, sexo)
        {

        }
    }
}
