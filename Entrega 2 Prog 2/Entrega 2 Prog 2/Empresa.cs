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
            List<Cargo> listaCargos = new List<Cargo>();
            List<Empleado> listaEmpleados = new List<Empleado>();
        }

        public bool existeCargo(int numeroCargo)
        {
            bool existe = false;
            if(listaCargos[numeroCargo] != null)
            {
                existe = true;
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
            return listaCargos[cargoElegido - 1];
        }

        public void aumentarSueldos(int porcentajeAumento, Cargo unCargo)
        {
            foreach(Cargo cargo in listaCargos)
            {
                if(cargo.Nombre == unCargo.Nombre)
                cargo.Sueldo += (cargo.Sueldo * porcentajeAumento);
            }
        }

    }
}
