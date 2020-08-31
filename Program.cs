using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindroma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese palabra: ");
            string cadena = Console.ReadLine();
            Palin(cadena);
            Console.ReadKey();
        }
        static void Palin(string cadena)
        {
            string invertido = "";
            for (int i = cadena.Length-1; i >= 0; i--)
            {
                invertido = invertido + cadena[i];
            }
            if (invertido==cadena)
            {
                Console.Write("La palabra " + cadena + " es palíndroma" + " .");
            }
            else
                Console.Write("La palabra " + cadena + " no es palíndroma" + "+");

        }
    }
}
