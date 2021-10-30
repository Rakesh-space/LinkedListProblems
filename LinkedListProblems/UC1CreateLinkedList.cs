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
        internal void insert(int data) //inserting new integer data into linklist
        {
            Node new_node = new Node(data); //here create new_node allocate memory here and assinged the data
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = head;  //here Node type of temp variable create and to assgined the head as a temp
                while (temp.next != null)
                {
                    temp = temp.next;  //temp.next node to assgined the temp variable
                }
                temp.next = new_node;  //temp.next is link to new_node
            }
            Console.WriteLine("\n {0} Data is inserted into linked list.", new_node.data);
        }

        internal void DisplayAllEle() //display the data of linkedlist
        {
            Console.WriteLine("\nDisplay LinkedList element is:");
            Node t = this.head;
            if (t == null)  //cheking the linklinst is empty or not
            {
                Console.WriteLine("\n Linked List empty");
                return;
            }
            else
            {
                while (t != null) //display the linklist data
                {
                    Console.WriteLine(t.data + " ");  //actual new_node of data can be display
                    t = t.next;  //temp variable shift to the next node
                }
                //  Console.WriteLine(" " + temp.data + " ");
            }
        }
    }
}
