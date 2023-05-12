using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class CircleNodo
{
    private int dato;
    private CircleNodo next;
    private CircleNodo prev;

    public int Dato
    {
        get { return dato; }
        set { dato = value; }
    }

    public CircleNodo Next
    {
        get { return next; }
        set { next = value; }
    }

    public CircleNodo Prev
    {
        get { return prev; }
        set { prev = value; }
    }
}
