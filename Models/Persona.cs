using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_empleados.Models
{
    public abstract class Persona
    {
        protected Guid Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected int Edad { get; set; }

        public abstract void MostrarInformacion();

        public string GetNombre()
        {

            return Nombre;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public int GetEdad()
        {
            return Edad;
        }
    }
}