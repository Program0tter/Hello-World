using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Prog_2
{
    class Cargo
    {
        private int sueldo;
        private string nombre;

        public int Sueldo { set; get; }
        public string Nombre { set; get; }

        public Cargo()
        {
            this.Sueldo = 0;
            this.Nombre = "Cargo sin identificar";
        }

        public Cargo(int unSueldo, string unNombre)
        {
            this.Sueldo = unSueldo;
            this.Nombre = unNombre;
        }

        public override string ToString()
        {
            string infoCargo = "Cargo: " + this.Nombre + "\nSueldo: " + this.Sueldo;
            return infoCargo;
        }


    }
}
