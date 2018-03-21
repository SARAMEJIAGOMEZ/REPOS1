using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PlantillaFormas> lista = new List<PlantillaFormas>();
            var corazon = new Corazon();
            var estrella = new Estrella();
            var rayo = new Rayo();

            corazon.Borde = "negro";
            corazon.Fondo = "rojo";
            estrella.Borde = "amarillo";
            estrella.Fondo = "blanco";
            rayo.Borde = "negro";
            rayo.Fondo = "amarillo";

            var cadena = corazon.ToString();
            Console.WriteLine(cadena);

            lista.Add(corazon);
            lista.Add(estrella);
            lista.Add(rayo);

            foreach (PlantillaFormas forma in lista )
            {
                Console.WriteLine(forma);

            }
            Console.ReadKey();

        }
    }
}
