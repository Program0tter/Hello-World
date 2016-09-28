using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Prog_2
{
    class Empresa
    {
        private List<Cargo> listaCargos;
        private List<Empleado> listaEmpleados;

        public Empresa()
        {
            listaCargos = new List<Cargo>();
            listaEmpleados = new List<Empleado>();
        }

        public bool existeCargo(string nombreCargo)
        {
            bool existe = false;
            int index = 0;
            while(index < listaCargos.Count && existe == false)
            {
                if(listaCargos[index].Nombre == nombreCargo)
                {
                    existe = true;
                }                
            }
            return existe;
        }

        public void crearCargo(int unSueldo, string unNombre)
        {
            Cargo unCargo = new Cargo(unSueldo, unNombre);
            listaCargos.Add(unCargo);
        }

        public void registrarEmpleado(string unNombre, string unTelefono, Cargo unCargo)
        {
            Empleado unEmpleado = new Empleado(unNombre, unTelefono, unCargo);
            listaEmpleados.Add(unEmpleado);
        }

        public List<Cargo> devolverListaCargos()
        {
            return listaCargos;
        }

        public List<Empleado> devolverListaEmpleados()
        {
            return listaEmpleados;
        }
            
        public Cargo elegirCargo(int cargoElegido)
        {
            return listaCargos[cargoElegido];
        }

        public int aumentarSueldos(int porcentajeAumento, Cargo unCargo)
        {
            int nuevoSueldo = unCargo.Sueldo += (unCargo.Sueldo * porcentajeAumento);
            unCargo.Sueldo = nuevoSueldo;
            return nuevoSueldo;
        }

    }
}
