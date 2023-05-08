using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerNodos : MonoBehaviour
{
    ListaNodo listita = new ListaNodo();
    [Header("Index para buscar por valor en los nodos")]
    public int numIndex;
    [Header("Index para buscar por index de nodo")]
    public int searchIndex;
    [Header("Index para buscar por index de nodo y destruirlo")]
    public int searchIndexToDestroy;
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
            listita.FindNodo(numIndex);    
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            listita.FindNodo2(numIndex);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            listita.FindNodoIndex(searchIndex);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            listita.FindNodoIndex(searchIndexToDestroy);
        }
    }
}
