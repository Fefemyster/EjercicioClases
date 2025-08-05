using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using EjercicioClases;

namespace EjercicioClases
{
    public class Libro
    {
        //Atributos
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }

        //Metodos
        public void MostrarInformacion()
        {
            Console.WriteLine("****Libros****");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"AñoPublicacion: {AñoPublicacion}");
            Console.WriteLine();
        }

    }
}
