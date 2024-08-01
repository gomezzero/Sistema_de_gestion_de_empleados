using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_empleados.Models
{
    public class Cliente : Persona
    {
        public string Email { get; set; }
        public string Telefono { get; set; }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefono: ${Telefono}");
        }
    }
}