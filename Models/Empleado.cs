using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_empleados.Models
{
    public class Empleado : Persona
    {
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
        public void mostraNombre(){
            Console.WriteLine(Nombre);
        }

        public void ActualizarEmpleado(string numeroDeIdentificacion, string nombre, string apellido, double nuevoSalario, string posicion, List<Empleado> ListaEmpleados)
        {
            Empleado empleadoActualizado = ListaEmpleados.Find(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);

            if (empleadoActualizado != null)
            {
                empleadoActualizado.Nombre = nombre;
                empleadoActualizado.Apellido = apellido;
                empleadoActualizado.Salario = nuevoSalario;
                empleadoActualizado.Posicion = posicion;
                Console.WriteLine("Empleado actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("El empleado no fue encontrado.");
            }
        }
    }
}