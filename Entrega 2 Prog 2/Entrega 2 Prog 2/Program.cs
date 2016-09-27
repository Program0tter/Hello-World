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
        static void Main(string[] args)
        {
        }


        private void crearListaCargos()
        {
            List<Cargo> listaCargos = miEmpresa.devolverListaCargos();
            int index = 0;
            foreach (Cargo cargo in listaCargos)
            {
                Console.WriteLine(index + 1 + " - " + listaCargos[index].Nombre);
                index++;
            }
        }

        public void listarCargosConSueldoMayorDeMonto(int montoIngresado)
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

        private void crearListaEmpleados()
        {
            List<Empleado> listaEmpleados = miEmpresa.devolverListaEmpleados();
            foreach(Empleado emp in listaEmpleados)
            {
                Console.WriteLine(emp);
            }
        }

        private void indicarAumentoSueldoParaCargo()
        {
            Console.WriteLine("Elija el cargo al que desea aumentar el sueldo:");
            crearListaCargos();
            int cargoElegido = Convert.ToInt32(Console.ReadLine());
            Cargo unCargo = miEmpresa.elegirCargo(cargoElegido);

        }

        public void crearMenu()
        {

        }
    }
}
