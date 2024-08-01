using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_empleados.Models
{
    public class Empleado : Persona
    {
        public Guid Id { get; set; }
        public string NumeroDeIdentificacion { get; set; }
        public string Posicion { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, string apellido, string numeroDeIdentificacion, int edad, string posicion, double salario)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            NumeroDeIdentificacion = numeroDeIdentificacion;
            Edad = edad;
            Posicion = posicion;
            Salario = salario;
        }
        
        private void BonificacionSalario()
        {
            Salario += Salario * 0.1; 
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Número de identificación: {NumeroDeIdentificacion}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Posición: {Posicion}");
            Console.WriteLine($"Salario: ${Salario}");
            BonificacionSalario();
            Console.WriteLine($"Salario con bonificación: ${Salario}");
            Console.WriteLine();
        }
    }
}