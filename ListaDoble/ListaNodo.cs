using System;
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
    } // null <-- 12 --> <--10 --> <--8 --><--6 --><--4 -->null  
    //head  = 12        ultimo = 4     temp = 12 
    public void DesplegarNodoRight() //Muestra los nodos del primero al ultimo
    {
        NodoLigado temp = new NodoLigado();
        temp = head;
        while(temp != null )
        {
            Debug.Log(temp.Dato);
            temp = temp.Next;
        }
    }  // null <-- 12 --> <--10 --> <--8 --><--6 --><--4 -->null  //head  = 12        tail = 4     temp = 6 
    public void DesplegarNodoLeft() //Muestra los nodos del ultimo al primero 
    {
        NodoLigado temp = new NodoLigado();
        temp = tail;
        while (temp != null)
        {
            Debug.Log(temp.Dato);
            temp = temp.Prev;
        }
    }
    public NodoLigado FindNodo(int num)
    {
        NodoLigado temp = new NodoLigado();
        temp = head;
        bool find = false;
        while (temp != null && find == false)
        {
            if (temp.Dato == num)
            {
                Debug.Log("Nodo encontrado con valor: " + temp.Dato);
                find = true;
                return temp;
            }
            temp = temp.Next;
        }
        if (!find)
        {
            Debug.Log("Nodo no encontrado");
            return null;
        }
        return null;
    } //NodoLigado que devuelve un nodo por valor del nodo
    public void FindNodoVoid(int num)
    {
        NodoLigado temp = new NodoLigado();
        temp = head;
        bool find = false;
        while (temp != null && find == false)
        {
            if(temp.Dato == num)
            {
                Debug.Log("Nodo encontrado con valor: " + temp.Dato);
                find = true;
            }
            temp = temp.Next;
        }
        if (!find)
        {
            Debug.Log("Nodo no encontrado");
        }
    } //Funcion para encontrar un nodo por valor del nodo
    public NodoLigado FindNodoIndex(int num)
    {
        NodoLigado temp = new NodoLigado();
        temp = head;
        bool find = false;
        int contador = 0;
        while (temp != null && find == false)
        {
            if (contador == num)
            {
                Debug.Log("Nodo encontrado con valor: " + temp.Dato);
                find = true;
                return temp;
            }
            contador++;
            temp = temp.Next;
        }
        if (!find)
        {
            Debug.Log("Nodo no encontrado");
            return null;
        }
        return null;
    }  //NodoLigado que devuelve un nodo por el index del nodo
    public void ModificarDataNodo(int num, int newValue)
    {
        NodoLigado temp = new NodoLigado();
        temp = head;
        bool find = false;
        while (temp != null && find == false)
        {
            if (temp.Dato == num)
            {
                temp.Dato = newValue;
                find = true;
                Debug.Log("Nodo modificado con exito");
            }
            temp = temp.Next;
        }
        if (!find)
        {
            Debug.Log("Nodo no encontrado");
        }
    } //Funcion que modifica los valores de un nodo por valor buscado
    public void DestroyNodo(int num)
    {
        NodoLigado temp = new NodoLigado();
        NodoLigado anterior = new NodoLigado();
        anterior = null;
        temp = head;
        bool find = false;
        int contador = 0;
        while (temp != null && find == false)
        {
            if (contador == num)
            {
               if(temp == head)
                {
                    head = head.Next;
                    head.Prev = null;
                }
               else if(temp ==  tail)
                {
                    anterior.Next = null;
                    tail = anterior;
                }
               else
                {
                    anterior.Next = temp.Next;
                    temp.Next.Prev = anterior;

                }
                Debug.Log("Nodo eliminado gg");
                find = true;
            }

            contador++;
            anterior = temp;
            temp = temp.Next;
        }
        if (!find)
        {
            Debug.Log("Nodo no encontrado");
            
        }
       
    } //funcion que destruye elimina un nodo por el index
}
