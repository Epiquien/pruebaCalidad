using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invierte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese frase o palabra: ");
            string cadena = Console.ReadLine();

            invertir(cadena);
            Console.ReadKey();
        }

        static void invertir(string cadena)
        {
            string inverso= "";
            for (int i = cadena.Length-1; i >=0; i--)
            {
                inverso = inverso + cadena[i];
            }
            Console.WriteLine("La cadena inversa de " + cadena + " es " + inverso);
        }
    }
}
