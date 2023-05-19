using System;


namespace Colas
{
     class Nodo
    {
        private int dato;
        private Nodo next;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}
