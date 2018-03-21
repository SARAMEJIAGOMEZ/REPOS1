using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PlantillaFormas
    {
        private string nombre;

        public string  Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string borde;

        public string Borde
        {
            get { return borde; }
            set { borde = value; }
        }
        public string Cadena { get; set; }
        private string fondo;

        public string Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }
        public override string ToString()
        {
            return "El nombre de la figura es " + this.nombre + " cuyo color de borde es " + this.borde + " y el color de fondo es " + this.fondo;
        }



    }
}
