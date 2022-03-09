using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el numero de discos");
            int numerodiscos = Convert.ToInt32(Console.ReadLine()); //Leer la tecla introducida por el usuario y pasarla de String a Int

            Pila INI = new Pila("INI",numerodiscos); //pila llena con el número de discos que asignamos
            Pila AUX = new Pila("AUX"); //pila vacia
            Pila FIN = new Pila("FIN"); //pila vacia

            

            Console.WriteLine("El número de movimientos es: " + numeromovimientos);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(); //Espera a que se pulse una tecla (para que no se cierre la consola)

        }

    }
}
