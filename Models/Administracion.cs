using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_empleados.Models
{
    public static class Administracion
    {
        public static Empleado CrearEmpleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del empleado");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el Numero De Identificacion");
            string numeroDeIdentificacion = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del empleado");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la Posicion");
            string posicion = Console.ReadLine();

            Console.WriteLine("Ingrese el Salario del empleado");
            double salario = Convert.ToDouble(Console.ReadLine());

            return new Empleado(nombre, apellido, numeroDeIdentificacion, edad, posicion, salario);
        }

        public static Cliente CrearCliente()
        {
            Console.WriteLine("Ingrese el nombre del Cliente");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apepllido del Cliente");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del Cliente");
            int Edad = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese el email De Identificacion");
            string Email = Console.ReadLine();

            Console.WriteLine("Ingrese el Telefono del Cliente");
            string Telefono = Console.ReadLine();

            return new Cliente(nombre, apellido, Edad, Email, Telefono);
        }

        public static Empleado ActualizacionEmpleados()
        {
            return CrearEmpleado();
  
        }
        public static void MostrarTitulo(string titulo)
        {
            Console.Clear();
            Console.WriteLine(new string('-', 45));
            Console.WriteLine(titulo.ToUpper());
            Console.WriteLine(new string('-', 45));
        }

        public static void MostrarPie()
        {
            Console.WriteLine(new string('-', 45));
            Console.WriteLine("");
        }

        public static void MostrarSeparador()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 45));
            Console.WriteLine();
        }

        public static void VolverMenu()
        {
            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
        }
    }
}