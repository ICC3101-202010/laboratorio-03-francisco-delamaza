using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Auxiliar:Persona
    {
        private string sueldo;
        List<Auxiliar> Auxiliares = new List<Auxiliar>();
        public Auxiliar(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string sexo, string sueldo)
            : base(rut, nombre, apellido, fecha_nacimiento, nacionalidad, sexo)
        {
            this.sueldo = sueldo;
        }
    }
}
