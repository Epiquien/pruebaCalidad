using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongitudPalabra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Nombre y Apellidos: ");
            string nombre = Console.ReadLine();

            longitud(nombre);
            Console.ReadKey();

        }
        static void longitud(string nombre)
        {
            Console.WriteLine("Longitud->  " + nombre.Length);
        }
    }
}
