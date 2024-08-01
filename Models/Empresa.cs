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

        public void AgregarEmpleados(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
        }

        public void EliminarEmpleado(string numeroDeDocumento)
        {
            Console.WriteLine($"seguiro que quieres eliminar al empleado identificado con: {numeroDeDocumento}");
            Console.WriteLine("si - no"); 
            string pregunta = Console.ReadLine();
            if (pregunta == "si")
            {
                ListaEmpleados.RemoveAll(e => e.GetNombre() == numeroDeDocumento);
                Console.WriteLine("El empleado fue eliminado");
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
                Console.WriteLine($"\nNombre: {empleado.GetNombre()} \n Apellido: {empleado.GetApellido()}\n Salario: {empleado.Salario} \n Numero de identificacion: {empleado.NumeroDeIdentificacion}");
            }
        }


    
        public void BuscarEmpleadoPorDocumento(string numeroDeIdentificacion2)
        {
            Empleado empleadoBusquedaNumero = ListaEmpleados.Find(e => e.NumeroDeIdentificacion == numeroDeIdentificacion2);
            if (empleadoBusquedaNumero != null)
            {
            Console.WriteLine($@"
            El nombre del empleado es = {empleadoBusquedaNumero.GetNombre()}
            El apellido del empleado es = {empleadoBusquedaNumero.GetApellido()}
            La edad del empleado es = {empleadoBusquedaNumero.GetApellido()}
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
                ListaClientes.RemoveAll(e => e.GetNombre() == nombre3 && e.GetApellido() == apellido3);
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
                Console.WriteLine($"\nNombre: {cliente.GetNombre()} \n Apellido: {cliente.GetApellido()}\n Edad: {cliente.GetApellido()} \n Telefono: {cliente.Telefono} \n Email: {cliente.Email}");
            }  
        }
    }
}