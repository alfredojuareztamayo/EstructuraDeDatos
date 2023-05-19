using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
     class Pila
    {
        private Nodo Head = new Nodo();

        public Pila() 
        {
            Head = null;
        }

        //Head = 78                        nuevo = 78                          pila datos 23,56,78,89

        //Pila =                      78->  56->   23 -> null

        public void InsertNodo(int num)
        {
            Nodo newNodo = new Nodo();
            newNodo.Dato = num;

            newNodo.Next = Head;
            Head = newNodo;

           
        }
        //Head = 78                        nuevo = 78                          pila datos 23,56,78,89

        //Pila =                      78->  56->   23 -> null

        public void ShowNodo()
        {
            Nodo temp = new Nodo();
            temp = Head;
            string textNodo = "";
           
            if(Head != null)
            {
                while(temp != null)
                {
 
                    textNodo += (temp.Dato.ToString() + "," );
                    temp = temp.Next;
                }
            }
            else
            {
                //debuguear la pila esta vacia gg
            }

            //Debuguear textNodo
        }
    }
}
