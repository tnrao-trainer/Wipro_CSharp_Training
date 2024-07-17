﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApplication    
{
    public class Node    
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int d)
        {
            Data = d;
            Next = null;
        }
    }

    public class MyLinkedList     
    {
        public Node Head { get; set; } 

        public MyLinkedList() {
            Head = null;
        }

       public void AddNode(int d)
        {
            Node obj = new Node(d);

            if(Head == null)
            {
                Head = obj;
            }
            else
            {
                Node temp = Head;

                while(temp.Next != null) 
                {                     
                   temp = temp.Next;
                }

                temp.Next = obj;

            }

        }

        public void ShowList()
        {
            Node temp = Head;

            while (temp != null)
            {
                Console.Write("{0} --> ", temp.Data);
                temp = temp.Next;
            }
        }


        public void RemoveNode(int d) { 
                // Write the code to Remove the node based on the data
        }
    }

    public class Program     
    {
         
        public static void Main(string[] args)
        {
            MyLinkedList lstObj = new MyLinkedList();

            lstObj.AddNode(10);
            lstObj.AddNode(20);
            lstObj.AddNode(30);
            lstObj.AddNode(40);
            lstObj.AddNode(50);
            
            lstObj.ShowList();

            Console.ReadLine();
        }
    }
}
