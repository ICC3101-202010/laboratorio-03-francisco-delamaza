using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Empleado : Persona
    {
        List<Empleado> Empleados = new List<Empleado>();

        public Empleado(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string sexo)
            : base(rut, nombre, apellido, fecha_nacimiento, nacionalidad, sexo)
        {

        }


    }
}
