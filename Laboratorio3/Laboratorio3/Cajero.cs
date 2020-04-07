using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Cajero : Persona
    {
        private List<Cajero> Cajeros = new List<Cajero>();
        private String sueldo;
        public Cajero(string rut, string nombre, string apellido, string fecha_nacimiento, string nacionalidad, string sexo,string sueldo)
            : base(rut,nombre,apellido,fecha_nacimiento,nacionalidad,sexo)
        {
            this.sueldo = sueldo;
        }
       

        public String Hola()
        {
            return $"{Nombre},{Apellido},{Rut}";
        }
    }
}
