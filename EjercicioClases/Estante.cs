using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClases;

namespace EjercicioClases
{
    public class Estante
    {
        public int NumeroEstante { get; set; }  
        public int CapacidadMaxima { get; set; }
        public List<Libro> LibrosEnEstante { get; set; }

        public void MostrarContenido ()
        {
            Console.WriteLine($"El numero del estante es: {NumeroEstante}");
            Console.WriteLine($"Su capacidad maxima es: {CapacidadMaxima}");
            Console.WriteLine("Los libros en el estante son: ");
            Console.WriteLine();
            if (LibrosEnEstante.Count > 0)
            {
                foreach (var libro in LibrosEnEstante)
                {
                    libro.MostrarInformacion(); // Este es el metodo de la clase libro
                }
            }
            else
            {
                Console.WriteLine("No hay libros en el estante.");
            }

        } 

    }
}
