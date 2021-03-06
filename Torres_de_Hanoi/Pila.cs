using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { //Atributo que devuelve el tamaño de la lista de elementos de la pila (es decir devuelve el número de elementos de la pila)
            get
            {
                return Elementos.Count;
            }
                
        } //no podemos establecer el tamaño, sino que se establece a partir del tamaño de la lista

        public Disco Top //Devuelve el elemento supeior de la fila en un tipo disco (ya que los elementos son Discos)
        {
            get
            {
                if (isEmpty() == false)
                {
                    return Elementos[Elementos.Count - 1]; //devuelve el elemento tope de la fila
                }
                else
                {
                    return null;
                }
                
            }
        } //no podemos establecer el top ya que se establece a partir del último elemento de la lista

        public List<Disco> Elementos; //Son dinámicos (pueden cambiar su tamaño en cualquier momento)

        public String Nombre { get; set; } // Método añadido para asignarle y saber el nombre de la PILA

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */

        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /* TODO: Implementar métodos */


        //Constructor Vacio (excepto por el nombre)
        public Pila(string n)
        {
            Elementos = new List<Disco>(); //se crea una lista vacia
            Nombre = n;
        }

        //Constructor con cantidad
        public Pila(string n,int cantidad) //la cantidad de discos que tiene la pila
        {
            Nombre = n;
            Elementos = new List<Disco>();

            for (int i=cantidad; i>0;i--) //recorre la lista al reves para poner los discos más grandes abajo
            {
                Disco d = new Disco(); //creamos un disco
                d.Valor = i; //le asignamos el valor de la "i" al Valor del disco
                push(d); //usando el método "push" metemos el disco en la pila
            }
        }

        public void push(Disco d) //permite añadir un disco en la pila de discos
        {
            
            Elementos.Add(d);


        }

        public Disco pop() //permite extraer el disco de la parte superior de la pila
        {
            Disco dsacado = Top; //coge el disco que hay arriba de la pila
            Elementos.RemoveAt(Size - 1); //Borra el de la última posición
            return dsacado;
        }                

        public bool isEmpty() //informa si la pila está vacía o no.
        {
            if(Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
