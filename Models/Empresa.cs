using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_empleados.Models
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Empleado> ListaEmpleados = new List<Empleado>();
        public List<Cliente> ListaClientes = new List<Cliente>();

        public Empresa()
        { }


        public Empleado PedirdatosEmpleado()
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

        public Cliente PedirdatosCliente()
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

        public void AgregarEmpleados(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
        }

        public void EliminarEmpleado(string nombre2, string apellido2)
        {
            Console.WriteLine($"seguiro que quieres eliminar al empleado: {nombre2} {apellido2}");
            string pregunta = Console.ReadLine();
            if (pregunta == "si")
            {
                ListaEmpleados.RemoveAll(e => e.Nombre == nombre2 && e.Apellido == apellido2);
            } 
            else
            {
                Console.WriteLine("En tendido");
            }
        }

        public void MostrarTodosLosEmpleados()
        {
            foreach (var empleado in ListaEmpleados)
            {
                Console.WriteLine($"\nNombre: {empleado.Nombre} \n Apellido: {empleado.Apellido}\n Salario: {empleado.Salario} \n Numero de identificacion: {empleado.NumeroDeIdentificacion}");
            }
        }

        public void ActualizarEmpleado(string numeroDeIdentificacion, string nombre, string apellido, double nuevoSalario, string posicion)
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
    
        public void BuscarEmpleadoPorDocumento(string numeroDeIdentificacion2)
        {
            Empleado empleadoBusquedaNumero = ListaEmpleados.Find(e => e.NumeroDeIdentificacion == numeroDeIdentificacion2);
            if (empleadoBusquedaNumero != null)
            {
            Console.WriteLine($@"
            El nombre del empleado es = {empleadoBusquedaNumero.Nombre}
            El apellido del empleado es = {empleadoBusquedaNumero.Apellido}
            La edad del empleado es = {empleadoBusquedaNumero.Edad}
            La pocision del empleado es = {empleadoBusquedaNumero.Posicion}");                
            }
        }

        public void MostrarEmpleadosPorCargo()
        {
            string cargo = Console.ReadLine();
            foreach (var item in ListaEmpleados)
            {
                if (item.Posicion == cargo)
                {
                    item.MostrarInformacion();
                } else
                {
                    Console.WriteLine("Cargo sin empleados");
                }
            }
        }
    
        public void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }
    
        public void EliminarCliente(string nombre3, string apellido3)
        {
            Console.WriteLine($"seguiro que quieres eliminar al empleado: {nombre3} {apellido3}");
            string pregunta = Console.ReadLine();
            if (pregunta == "si")
            {
                ListaClientes.RemoveAll(e => e.Nombre == nombre3 && e.Apellido == apellido3);
            } 
            else
            {
                Console.WriteLine("En tendido");
            }
        }
    
        public void MostrarTodosLosClientes()
        {
            foreach (var cliente in ListaClientes)
            {
                Console.WriteLine($"\nNombre: {cliente.Nombre} \n Apellido: {cliente.Apellido}\n Edad: {cliente.Edad} \n Telefono: {cliente.Telefono} \n Email: {cliente.Email}");
            }  
        }
    }
}