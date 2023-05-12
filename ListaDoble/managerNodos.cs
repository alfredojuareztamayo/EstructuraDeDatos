using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerNodos : MonoBehaviour
{
    ListaNodo listita = new ListaNodo();
    [Header("Lista comandos:" + "\n" +
        "D: despliega los nodos del primero al ultimo" + "\n" +
        "A: despliega los nodos del ultimo al primero" + "\n" +
        "F: Funcion para encontrar un nodo por valor del nodo" + "\n" +
        "G: Regresa el nodo con el valor indicado" + "\n" +
        "H: Regresa el nodo por el index del nodo" + "\n" +
        "I: modifica el nodo indicado" + "\n" +
        "W: Destruye/elimina un nodo dando un index" + "\n" +
        "....")]
    
    [Header("Index para buscar por valor en los nodos")]
    public int numIndex;
    [Header("Index para buscar por index de nodo")]
    public int searchIndex;
    [Header("Index para buscar por index de nodo y destruirlo")]
    public int searchIndexToDestroy;
    [Header("x es el nodo buscado que desea modificar por valor" + "\n" +
        " & Y es el nuevo valor")]

    public int X;
    public int Y;

    void Start()
    {
        
        listita.InsertNodo(12);
        listita.InsertNodo(10);
        listita.InsertNodo(8);
        listita.InsertNodo(6);    
        listita.InsertNodo(4);
        listita.InsertNodo(2);
        listita.InsertNodo(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Lista del primero al ultimo");
            listita.DesplegarNodoRight();           
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Lista del ultimo al primero");
            listita.DesplegarNodoLeft();
        }
        if(Input.GetKeyUp(KeyCode.F)) 
        {
            listita.FindNodoVoid(numIndex);    
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            listita.FindNodo(numIndex);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            listita.FindNodoIndex(searchIndex);
        }
        if(Input.GetKeyUp(KeyCode.I))
        {
            listita.ModificarDataNodo(X,Y);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            listita.DestroyNodo(searchIndexToDestroy);
        }
    }
}
