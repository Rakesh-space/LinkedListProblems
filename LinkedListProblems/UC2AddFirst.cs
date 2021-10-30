using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class UC1CreateLinkedList
    {

        internal Node head;
        internal void AddFirst(int data) //Adding element in begining
        {
            Node new_node1 = new Node(data); //here create new_node1 allocate memory here and assinged the data
            new_node1.next = this.head;
            this.head = new_node1;
        }
        internal void DisplayAllEle() //display the data of linkedlist
        {
            Console.WriteLine("\nDisplay LinkedList element is:");
            Node temp = this.head;
            if (temp == null)  //cheking the linklinst is empty or not
            {
                Console.WriteLine("\n Linked List empty");
                return;
            }
            else
            {
                while (temp != null) //display the linklist data
                {
                    Console.WriteLine(temp.data + " ");  //actual new_node of data can be display
                    temp = temp.next;  //temp variable shift to the next node
                }
                //  Console.WriteLine(" " + temp.data + " ");
            }
        }
    }
}
