using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList: MonoBehaviour
{
    DoubleNode head = new DoubleNode();

   // DoubleNode tail = new DoubleNode();


    public void Start()
    {
        InsertHead(5);
        InsertHead(6);
        InsertHead(10);
        InsertHead(7);
     


    }
    public void Update()
    {
        movNodes();
    }

    public void InsertHead(int num)
    {
        DoubleNode newNodo = new DoubleNode();
        newNodo.num = num;
        if (IsEmptyList())
        {
            head = newNodo;
            head.next = null;
            Debug.Log("iNSERTE: " + num);

        }
        else
        {
            Debug.Log("Entre en el ese");
            newNodo.next = head;
            head.prev = newNodo;
            head = newNodo;
        }

    }


    bool IsEmptyList()
    {
        return head == null;
    }

    public void movNodes()
    {
        DoubleNode tempNode = new DoubleNode();
        tempNode = head;

        if (Input.GetKeyDown(KeyCode.D))
        {

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

}
