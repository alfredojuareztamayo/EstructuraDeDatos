using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newNodos : MonoBehaviour
{
   DoubleNode head = new DoubleNode();
    void Start()
    {
        InsertNods(3);
        InsertNods(6);
        InsertNods(10);
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            ShowNod();
        }
    }
    bool IsEmptyList()
    {
        return head == null;
    }

    public void InsertNods(int newNum)
    {
        DoubleNode newNodo = new DoubleNode(newNum);
        if (IsEmptyList())
        {
            head = newNodo;
            head.prev = null;
            head.next = null;
        }
        else
        {
            newNodo.next = head;
            head.prev= newNodo;
            head = newNodo;


        }
    }
    public void ShowNod()
    {
        DoubleNode tempNode = new DoubleNode();
        tempNode = head;

        

            if (head != null)
            {
                while (tempNode != null)
                {
                    Debug.Log(tempNode.num);
                    tempNode = tempNode.next;
                }
            }
            else
            {
                Debug.Log("La lista esta vacia gg");
            }

        }

    
}
