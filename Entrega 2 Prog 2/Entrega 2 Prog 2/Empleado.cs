using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Prog_2
{
    class Empleado
    {
        private static int ultimoNumero;
        private string nombre;
        private string telefono;
        private int numeroEmpleado;
        private Cargo cargoEnEmpresa;

        public static int UltimoNumero { set; get; }
        public string Nombre { set; get; }
        public string Telefono { set; get; }
        public int NumeroEmpleado { set; get; }
        public Cargo CargoEnEmpresa { set; get; }

        public Empleado()
        {
            this.Nombre = "Sin nombre";
            this.Telefono = "Sin telefono";
            this.NumeroEmpleado = 0;
            Cargo unCargo = new Cargo();
            this.CargoEnEmpresa = unCargo;
        }

        public Empleado(string unNombre, string unTelefono, Cargo unCargo)
        {
            this.Nombre = unNombre;
            this.Telefono = unTelefono;
            this.CargoEnEmpresa = unCargo;
            this.NumeroEmpleado = crearNumeroEmpleado();
        }

        public override string ToString()
        {
            string infoEmpleado = "Nombre: " + this.Nombre + "\nTelefono: " + this.Telefono + "\nNumero de empleado: " + this.NumeroEmpleado + "\n" + this.CargoEnEmpresa;
            return infoEmpleado;
        }

        private int crearNumeroEmpleado()
        {
            return UltimoNumero++;
        }
    }
}
