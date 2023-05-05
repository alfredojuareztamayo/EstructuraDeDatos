using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

//public struct Nodos
//{
   
//} 

public class DoubleNode
{
    public DoubleNode next;
    public DoubleNode prev;
    public int num;


    public DoubleNode()
    {
        next = null;
        prev = null;
    }
    public DoubleNode(int t_num)
    {
        num = t_num;
        next = null;
        prev = null;

    }
    public DoubleNode(int t_num, DoubleNode t_next)
    {
       num  = t_num;
       next = t_next;
       prev = null;
        
    }
    


}


