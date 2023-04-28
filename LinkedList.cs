using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList: MonoBehaviour
{
    DoubleNode head = new DoubleNode();
    //DoubleNode tail = new DoubleNode();


    public void Start()
    {
        insertHead(5);
        insertHead(6);
        showNodes();
       
    }
    public void Update()
    {
        movNodes();
    }

    public void insertHead(int num)
    {
        if (isEmptyList())
        {
            head = new DoubleNode(num);
          
        }
        else
        {
            head.next = new DoubleNode(num);
        }

    }
    
    public void showNodes()
    {
        Debug.Log(head.num);
    }
    bool isEmptyList()
    {
        return head.next == null;
    }

    public void movNodes()
    {
        if(Input.GetKeyDown(KeyCode.D)) 
        {
            DoubleNode temp = head;
            head = head.next;
              showNodes();
        }
        if(Input.GetKeyDown(KeyCode.A)) 
        
        {
            head = head.prev;
            showNodes();
        }
    }

}
//public void insertTail(int num)
//{
//    if (isEmptyList())
//    {
//        tail = new DoubleNode(num);
//        head = tail;
//    }
//    else
//    {
//        tail.next = new DoubleNode(num);

//    }
//}