using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Nombre y Apellidos: ");
            string nombre = Console.ReadLine();
            may(nombre);
            Console.ReadKey();
        }
        static void may(string nombre)
        {
            string mayuscula = nombre.ToUpper();
            Console.WriteLine("Mayuscula-> " + mayuscula);
        }
    }
}
