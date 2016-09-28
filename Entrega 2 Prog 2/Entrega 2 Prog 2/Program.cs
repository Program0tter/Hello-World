using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Prog_2
{
    class Program
    {
        static Empresa miEmpresa = new Empresa();
        static Empleado unEmpleado = new Empleado();
            static void Main(string[] args)
        {
            Empleado.UltimoNumero = 100;
            crearMenu();
        }
         

        private static void crearListaCargos()
        {
            List<Cargo> listaCargos = miEmpresa.devolverListaCargos();
            int index = 0;
            foreach (Cargo cargo in listaCargos)
            {
                Console.WriteLine(index + 1 + " - " + listaCargos[index].Nombre);
                index++;
            }
        }

        private static void listarCargosConSueldoMayorDeMonto(int montoIngresado)
        {
            List<Cargo> listaCargos = miEmpresa.devolverListaCargos();
            int index = 0;
            foreach (Cargo cargo in listaCargos)
            {
                if(listaCargos[index].Sueldo > montoIngresado)
                {
                    Console.WriteLine(listaCargos[index]);
                }
            }
        }   

        private static void crearListaEmpleados()
        {
            List<Empleado> listaEmpleados = miEmpresa.devolverListaEmpleados();
            foreach(Empleado emp in listaEmpleados)
            {
                Console.WriteLine(emp);
            }
        }

        private static void indicarAumentoSueldoParaCargo()
        {
            List<Cargo> listaCargos = new List<Cargo>(); 
            Console.WriteLine("Elija el cargo al que desea aumentar el sueldo:");
            crearListaCargos();
            int cargoElegido = (Convert.ToInt32(Console.ReadLine()) -1);
            if (cargoElegido < 0 || cargoElegido > listaCargos.Count())
            {
                Console.WriteLine("El cargo elegido no existe.");
            }
            else
            {
                Cargo unCargo = miEmpresa.elegirCargo(cargoElegido);
                Console.WriteLine("Ingrese el aumento porcentual por el cual desea aumentar el sueldo del cargo.");
                int porcentajeAumento = Convert.ToInt32(Console.ReadLine());
                if(porcentajeAumento <= 0)
                {
                    Console.WriteLine("Debe ingresar un numero mayor a si desea aumentar un sueldo.");
                }
                else
                {
                    int nuevoSueldo = miEmpresa.aumentarSueldos(porcentajeAumento, unCargo);
                    Console.WriteLine("Aumento exitoso. El nuevo sueldo del cargo '" + unCargo.Nombre + "' es " + nuevoSueldo);
                }

            }
        }

        private static void crearCargoEnEmpresa()
        {
            Console.WriteLine("Ingrese nombre del cargo:");
            string nombre = Console.ReadLine().Trim();
            if(nombre == "")
            {
                Console.WriteLine("ERROR: Debe ingresar un nombre.");
            }else if(miEmpresa.existeCargo(nombre))
            {
                Console.WriteLine("ERROR: El nombre de cargo ingresado ya existe en el sistema.");
            }
            else
            {
                Console.WriteLine("Ingrese el sueldo que tendrá el nuevo cargo:");
                int sueldo = Convert.ToInt32(Console.ReadLine());
                if(sueldo <= 0)
                {
                    Console.WriteLine("El sueldo de un empleado no puede ser menor o igual a 0. No sea rata, señor administrador.");
                }
                else
                {
                    miEmpresa.crearCargo(sueldo, nombre);
                    Console.WriteLine("Cargo agregado al sistema exitosamente.");
                }
            }
             
        }

        private static void registrarEmpleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombreEmpleado = Console.ReadLine().Trim();
            if(nombreEmpleado == "")
            {
                Console.WriteLine("ERROR: Debe ingresar un nombre.");
            }
            else
            {
                Console.WriteLine("Ingrese un telefono de contacto:");
                string telefonoEmpleado = Console.ReadLine();
                if(telefonoEmpleado == "")
                {
                    Console.WriteLine("ERROR: Debe ingresar un numero de telefono.");
                }
                else
                {
                    Console.WriteLine("Elija un cargo de la lista para asignarle al empleado:");
                     crearListaCargos();
                    int cargoElegido = Convert.ToInt32(Console.ReadLine());
                    Cargo unCargo = miEmpresa.elegirCargo(cargoElegido);
                    miEmpresa.registrarEmpleado(nombreEmpleado, telefonoEmpleado, unCargo);
                    Console.WriteLine("Empleado agregado al sistema exitosamente.");
                }
            }
        }

        private static void listarCargosDependiendoDeSueldo()
        {
            Console.WriteLine("Ingrese un sueldo:");
            int sueldo = Convert.ToInt32(Console.ReadLine());
            if(sueldo <= 0)
            {
                Console.WriteLine("ERROR: Debe ingresar un valor mayor a 0.");
            }
            else
            {
                listarCargosConSueldoMayorDeMonto(sueldo);
            }
        }
        

        private static void crearMenu()
        {
            bool salir = false;
            int opcionElegida;
            do
            {
                Console.WriteLine("Elija la opcion deseada:\n1 - Crear un nuevo cargo\n2 - Registrar un empleado en el sistema\n3 - Listar cargos que superen cierto monto de sueldo\n4 - Listar empleados\n5 - Aumentar sueldos por un valor porcentual\n6 - Salir");
                opcionElegida = Convert.ToInt32(Console.ReadLine());

                switch (opcionElegida)
                {
                    case 1:
                        crearCargoEnEmpresa();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        registrarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        listarCargosDependiendoDeSueldo();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        crearListaEmpleados();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        indicarAumentoSueldoParaCargo();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("\nIngrese una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (salir == false);
        }

    }
}
