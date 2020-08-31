using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arragloCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Nombre y Apellidos: ");
            string nombre = Console.ReadLine();
            min(nombre);
            
          
            Console.ReadKey();
        }
        static void min(string nombre)
        {
            string minuscula=  nombre.ToLower();
            Console.WriteLine("Minuscula-> " + minuscula);
        }
        

    }
}
