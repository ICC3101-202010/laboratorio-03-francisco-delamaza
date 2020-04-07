using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Persona
    {
        private string rut;
        private string nombre;
        private string apellido;
        private string fecha_nacimiento;
        private string nacionalidad;
        private string sexo;

        List<Cajero> Cajeros = new List<Cajero>();
        public Persona(string rut,string nombre,string apellido,string fecha_nacimiento, string nacionalidad,string sexo)

        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.nacionalidad = nacionalidad;
            this.sexo = sexo;
            
        }

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public void Sueldo()
        {

        }

        public void Horario()
        {

        }

        

    }
}
