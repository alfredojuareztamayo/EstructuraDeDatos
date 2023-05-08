using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerNodos : MonoBehaviour
{
    ListaNodo listita = new ListaNodo();
   
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
    }
}
