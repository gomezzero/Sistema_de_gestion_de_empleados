using System.Runtime.InteropServices;
using Sistema_de_gestion_de_empleados.Models;

var empleado1 = new Empleado("zero", "ingel", "213456787", 32, "Gerente", 120000);
var empresa1 = new Empresa();

empresa1.ListaEmpleados.Add(empleado1);


empresa1.MostrarTodosLosEmpleados();

Console.WriteLine(" ");
Console.WriteLine(" ");

while (true)
{
    Console.Clear();
    Console.WriteLine("Sistema_de_gestion_de_empleados");
    Console.WriteLine("");
    Console.WriteLine("1. Mostrar Todos Los Empleados");
    Console.WriteLine("2. Agregar Empleado");
    Console.WriteLine("3. Actualizar Empleado");
    Console.WriteLine("4. Eliminar Empleado");
    Console.WriteLine("5. Buscar Empleado por numero de documento");
    Console.WriteLine("6. Mostrar empleado por cargo");
    Console.WriteLine("7. Mostrar todos los Clientes");
    Console.WriteLine("8. Agregar Cliente");
    Console.WriteLine("9. Eliminar Cliente");
    Console.WriteLine("0. Salir");
    Console.Write("ingrese la opcion: ");

    switch (Console.ReadLine())
    {
        case "0":
            return;
        case "1":
            Console.Clear();
            empresa1.MostrarTodosLosEmpleados();

            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
            break;
        case "2":
            Console.Clear();
            empresa1.AgregarEmpleados(empresa1.PedirdatosEmpleado()); // Funcional

            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Ingrese el numero de identificacion del empleado que desea actualizar:");
            string numeroDeIdentificacion = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del empleado que desea actualizar:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del empleado que desea actualizar:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo salario:");
            double nuevoSalario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el Position del empleado");
            string position = Console.ReadLine();



            empleado1.ActualizarEmpleado(numeroDeIdentificacion, nombre, apellido, nuevoSalario, position, empresa1.ListaEmpleados);

            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Ingrese el Numero de Identificacion del empleado que desea Eliminar:");
            string numeroDeDocumento = Console.ReadLine();
            empresa1.EliminarEmpleado(numeroDeDocumento);

            Console.WriteLine("");
            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("ingrese el Numero de identificacion del empleado");
            string numeroDeIdentificacion2 = Console.ReadLine();

            empresa1.BuscarEmpleadoPorDocumento(numeroDeIdentificacion2);

            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
            break;
        case "6":
            Console.Clear();
            Console.WriteLine("ingrese el cargo a filtrar");
            empresa1.MostrarEmpleadosPorCargo();

            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
            break;
        case "7":
            Console.Clear();
            empresa1.MostrarTodosLosClientes();

            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
            break;
        case "8":
            Console.Clear();
            empresa1.AgregarCliente(empresa1.PedirdatosCliente()); // Funcional

            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
            break;
        case "9":
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del Cliente que desea Eliminar:");
            string nombre3 = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del Cliente que desea Eliminar:");
            string apellido3 = Console.ReadLine();
            empresa1.EliminarCliente(nombre3, apellido3);

            Console.WriteLine("Pulse cualquier boton para volver al menu");
            Console.ReadKey();
            break;
        case "10":
            Console.Clear();
            empleado1.MostrarInformacion();
            break;

        default:
            Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
            break;
    }
}




//  // Funcional

// empleado1.MostrarInformacion(); // Funciona

// agrega un empleado

