using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
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
