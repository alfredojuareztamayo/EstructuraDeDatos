using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Cola
    {
        public Nodo Head = new();
        public Nodo tail = new();

        public Cola()
        {

            Head = null;
        }

        // head = 10             tail = 15                      a insertar 10,20,15,30
        //  nuevo = 15          10->20->15->null

        //
        public void InsertNodoQueue(int num)
        {
            Nodo newNodo = new();
            newNodo.Dato = num;
            if (Head == null)
            {
                Head = newNodo;
                Head.Next = null;
                tail = newNodo;

            }
            else
            {
                tail.Next = newNodo;
                newNodo.Next = null;
                tail = newNodo;
            }
        }

        // head = 10             tail = 30                      a insertar 10,20,15,30
        //  Actual = 20          10->20->15->30->null
        public void ShowQueue()
        {
            Nodo Actual = new();
            Actual = Head;
            string QueueText = "";
            if(Head != null)
            {
                while (Actual != null)
                {
                    QueueText += (Actual.Dato.ToString() + ",");
                    Actual = Actual.Next;
                }
            }
            else
            {
                //Debugea que la lista esta vacia 
            }
            //Debugea QueuText
        }
    }
}
