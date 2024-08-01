using System.Runtime.InteropServices;
using Sistema_de_gestion_de_empleados.Models;

var empleado1 = new Empleado("zero", "ingel", "213456787", 32, "Gerente", 120000);

var empresa1 = new Empresa();
empresa1.ListaEmpleados.Add(empleado1);

while (true)
{
    Administracion.MostrarTitulo("Sistema_de_gestion_de_empleados");
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
    Administracion.MostrarSeparador();
    Console.Write("ingrese la opcion: ");

    switch (Console.ReadLine())
    {
        case "0":
            return;
        case "1":

            Administracion.MostrarTitulo("Empleados");
            empresa1.MostrarTodosLosEmpleados();
            Administracion.MostrarSeparador();

            Administracion.VolverMenu();
            break;
        case "2":
            Administracion.MostrarTitulo("Agregador de Empleados");
            empresa1.AgregarEmpleados(Administracion.CrearEmpleado()); // Funcional

            Administracion.MostrarSeparador();
            Administracion.VolverMenu();
            break;
        case "3":
            Administracion.MostrarTitulo("Actualizador de Empleados");
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

            Administracion.MostrarSeparador();
            Administracion.VolverMenu();
            break;
        case "4":
            Administracion.MostrarTitulo("Eliminador de Empleados");
            Console.WriteLine("Ingrese el Numero de Identificacion del empleado que desea Eliminar:");
            string numeroDeDocumento = Console.ReadLine();
            empresa1.EliminarEmpleado(numeroDeDocumento);

            Administracion.MostrarSeparador();
            Administracion.VolverMenu();
            break;
        case "5":
            Administracion.MostrarTitulo("Busqueda de Empleado por numero de documento");
            Console.WriteLine("ingrese el Numero de identificacion del empleado");
            string numeroDeIdentificacion2 = Console.ReadLine();

            empresa1.BuscarEmpleadoPorDocumento(numeroDeIdentificacion2);

            Administracion.MostrarSeparador();
            Administracion.VolverMenu();
            break;
        case "6":
            Administracion.MostrarTitulo("Mostrar empleado por cargo");
            Console.WriteLine("ingrese el cargo a filtrar");
            empresa1.MostrarEmpleadosPorCargo();

            Administracion.MostrarSeparador();
            Administracion.VolverMenu();
            break;
        case "7":
            Administracion.MostrarTitulo("Mostrar todos los Clientes");
            empresa1.MostrarTodosLosClientes();

            Administracion.MostrarSeparador();
            Administracion.VolverMenu();
            break;
        case "8":
            Administracion.MostrarTitulo("Agregar Cliente");
            empresa1.AgregarCliente(Administracion.CrearCliente()); // Funcional

            Administracion.MostrarSeparador();
            Administracion.VolverMenu();
            break;
        case "9":
            Administracion.MostrarTitulo("Eliminar Cliente");
            Console.WriteLine("Ingrese el nombre del Cliente que desea Eliminar:");
            string nombre3 = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del Cliente que desea Eliminar:");
            string apellido3 = Console.ReadLine();
            empresa1.EliminarCliente(nombre3, apellido3);

            Administracion.MostrarSeparador();
            Administracion.VolverMenu();
            break;
        default:
            Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
            break;
    }
}




//  // Funcional

// empleado1.MostrarInformacion(); // Funciona

// agrega un empleado

