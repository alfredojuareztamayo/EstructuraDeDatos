using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodoLigado
{
    private int dato;
    private NodoLigado next;
    private NodoLigado prev;

    public int Dato
    {
        get { return dato; }
        set { dato = value; }
    }

    public NodoLigado Next
    {
        get { return next; }
        set { next = value; }
    }

    public NodoLigado Prev
    {
        get { return prev; }
        set { prev = value; }
    }
}


