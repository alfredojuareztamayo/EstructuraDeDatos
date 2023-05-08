using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ListaNodo
{

    //45,45,67,89,12 --- primero lista doble ultimo

    private NodoLigado head = new NodoLigado(); //primer nodo
    private NodoLigado tail = new NodoLigado(); //ultimo nodo

    public ListaNodo() 
    {
        head = null;
        tail = null;
    }

    //funcion para insertar una lista doble
    // 12,10,8,6,4
    // nuevo 12
    // para el primer nodo sera 12
    //head = null asi que su apuntador esta vacio
    //NewNodo = 12 
    // null <-12-> null
    //head = 12 
    //ultimo = 12
    //creacion de un nuevo nodo 10
    // null <-- 12 --> <--10 --> <--8 --><--6 --><--4 -->null

    public void InsertNodo(int num)
    {
        NodoLigado newNodo = new NodoLigado();
        newNodo.Dato = num;

        if(head == null)
        {
            head = newNodo;
            head.Next = null;
            head.Prev = null;
            tail = newNodo;
        }
        else
        {
            tail.Next = newNodo;
            newNodo.Next = null;
            newNodo.Prev = tail;
            tail = newNodo;
        }
        Debug.Log("Nodo ingresado correctamente");
    }
    // null <-- 12 --> <--10 --> <--8 --><--6 --><--4 -->null
    //head  = 12        ultimo = 4     temp = 12 
    public void DesplegarNodoRight()
    {
        NodoLigado temp = new NodoLigado();
        temp = head;
        while(temp != null )
        {
            Debug.Log(temp.Dato);
            temp = temp.Next;
        }
    }
    // null <-- 12 --> <--10 --> <--8 --><--6 --><--4 -->null
    //head  = 12        tail = 4     temp = 6 
    public void DesplegarNodoLeft()
    {
        NodoLigado temp = new NodoLigado();
        temp = tail;
        while (temp != null)
        {
            Debug.Log(temp.Dato);
            temp = temp.Prev;
        }
    }
}
