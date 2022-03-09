using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    static class Hanoi
    {

        private static int num_discos; //es privado porque solo lo consulta la solución
        private static Pila INI, FIN, AUX;
        private static int num_movimientos;
        
        /*TODO: Implementar métodos*/
        private static void mover_disco(Pila a, Pila b)
        {
          if (solucion()==false) { //mientras no haya solución
            //1º caso: a --> b
            if(a.isEmpty() == false) //si a no está vacia
            {
                if(b.isEmpty() == true) //si b  está vacia
                {
                    b.push(a.pop()); // metemos en b el ultimo disco de a
                    num_movimientos++;
                    Console.WriteLine(a.Nombre + " - " + b.Top.Valor + " -> " + b.Nombre);

                }
                else if(a.Top.Valor < b.Top.Valor) //se comparan los valores de los discos superiores
                {
                    b.push(a.pop()); // metemos en b el ultimo disco de a
                    num_movimientos++;
                    Console.WriteLine(a.Nombre + " - " + b.Top.Valor + " -> " + b.Nombre);

                }
                else //si a.top > b.top
                {   
                    a.push(b.pop());
                    num_movimientos++;
                    Console.WriteLine(b.Nombre + " - " + a.Top.Valor + " -> " + a.Nombre);

                }
            }
            //2º caso: b-->a
            else //si a está vacia
            {
                if (b.isEmpty() == false) //si b no está vacia 
                {
                    a.push(b.pop());
                    num_movimientos++;
                    Console.WriteLine(b.Nombre + " - " + a.Top.Valor + " -> " + a.Nombre);

                } 
            }
          }
        }

       
    }
}
