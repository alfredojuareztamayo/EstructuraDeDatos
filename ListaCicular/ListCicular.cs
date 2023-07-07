using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCicular
{
    //Lista Circular doble, necesito saber head y tail
    CircleNodo head = new CircleNodo();
    CircleNodo tail = new CircleNodo();

    public ListCicular()
    {
        head = null;
        tail = null;
    }                                    //          2
                                       //         12   4
    //ListaCircularDoble --- 2,4,6,8,10,12         10  6
    //head = 2      tail = 4        nuevo = 4         8  
    public void InsertNodo(int num)
    {
        CircleNodo newNodo = new CircleNodo();
        newNodo.Dato = num;
        if(head == null)
        {
            head = newNodo;
            tail = newNodo;
            head.Next = head;
            head.Prev = tail;
        }
        else
        {
            tail.Next = newNodo;
            newNodo.Prev = tail;
            newNodo.Next = head;
            tail = newNodo;
            head.Prev = tail;
        }
        Debug.Log("Nodos ingresados correctamente");
    }

    public void ShowNodosHT()
    {
        CircleNodo temp = new CircleNodo();
        temp = head;
        if (temp != null)
        {
            do
            {
                Debug.Log(temp.Dato);
                temp = temp.Next;
            } while (temp != head);
        }
        else
        {
            Debug.Log("Ta vacio chavo");
        }
    } //Funcion que me muestra la lista del primero al ultimo

    public void SearchNodo(int num)
    {
        CircleNodo temp = new CircleNodo();
        temp = head;
        bool findYou = false;
        if (temp != null)
        {
            do
            {
                if(temp.Dato == num)
                {
                    Debug.Log("Nodo encontrado con valor: " +  temp.Dato);
                    findYou = true;
                }
                temp = temp.Next;
            } while (temp != head && !findYou);
            if(!findYou )
            {
                Debug.Log("No existe ese nodo");
            }
        }
        else
        {
            Debug.Log("Ta vacio chavo");
        }
    } //Funcion para encontrar un nodo por un valor

    public CircleNodo SearchNodoByValue(int num)
    {
        CircleNodo temp = new CircleNodo();
        temp = head;
        bool findYou = false;
        if (temp != null)
        {
            do
            {
                if (temp.Dato == num)
                {
                    Debug.Log("Nodo encontrado con valor: " + temp.Dato);
                    findYou = true;
                    return temp;
                }
                temp = temp.Next;
            } while (temp != head && !findYou);
            if (!findYou)
            {
                Debug.Log("No existe ese nodo");
                return null;
            }
        }
        else
        {
            Debug.Log("Ta vacio chavo");
            return null;
        }
        return null;
    } //Public Nodo circular encontrar un nodo por valor de nodo

    public CircleNodo SearchNodoByIndex(int num)
    {
        CircleNodo temp = new CircleNodo();
        temp = head;
        bool findYou = false;
        int contador = 0;
        if (temp != null)
        {
            do
            {
                if (contador == num)
                {
                    Debug.Log("Nodo encontrado con valor: " + temp.Dato);
                    findYou = true;
                    return temp;
                }
                contador++;
                temp = temp.Next;
            } while (temp != head && !findYou);
            if (!findYou)
            {
                Debug.Log("No existe ese nodo");
                return null;
            }
        }
        else
        {
            Debug.Log("Ta vacio chavo");
            return null;
        }
        return null;
    } //public nodo circular encuentra un nodo por index 

    public void ModifyNodo(int num, int newValue)
    {
        CircleNodo temp = new CircleNodo();
        temp = head;
        bool findYou = false;
        int contador = 0;
        if (temp != null)
        {
            do
            {
                if (contador == num)
                {
                  
                   temp.Dato = newValue;
                    findYou = true;
                    Debug.Log("Nodo modificado con exito prro");
                    
                }
                contador++;
                temp = temp.Next;
            } while (temp != head && !findYou);
            if (!findYou)
            {
                Debug.Log("No existe ese nodo");
              
            }
        }
        else
        {
            Debug.Log("Ta vacio chavo");
            
        }
        
    } //Funcion que me permite modifcar un nodo con el index del nodo 

    //                                                2
    //                                             12   4
    //ListaCircularDoble --- 2,4,6,8,10,12         10  6
    //head = 4      tail = 10       anterior = 6          8           10<-4-><-6-><-8-><-10->4   <-12->4     
    //temp = 8
    //      10<-4-><-6-> 10          <-8->  <-10->4  
    public void DestroyNodoCircular(int num)
    {
        CircleNodo temp = new CircleNodo();
        temp = head;
        CircleNodo anterior = new CircleNodo();
        anterior = null;
        bool findYou = false;
        int contador = 0;
        if (temp != null)
        {
            do
            {
                if (contador == num)
                {
                    if (temp == head)
                    {
                        head = head.Next;
                        head.Prev = tail;
                        tail.Next = head;

                    }
                    else if(temp == tail)
                    {
                        tail = anterior; //  tail = tail.Prev;
                        tail.Next = head;
                        head.Prev= tail;
                    }
                    else
                    {
                        anterior.Next = temp.Next;
                        temp.Next.Prev = anterior;
                    }
                    findYou = true;
                    
                }
                contador++;
                anterior = temp;
                temp = temp.Next;
            } while (temp != head && !findYou);
            if (!findYou)
            {
                Debug.Log("No existe ese nodo");
                
            }
        }
        else
        {
            Debug.Log("Ta vacio chavo");
            
        }
        

    }
}
