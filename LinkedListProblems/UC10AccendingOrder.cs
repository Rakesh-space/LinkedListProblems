using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class UC10AccendingOrder
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

        internal void sortedInsert()  // here Accending order display the all element in given linklist
        {
            Node newnode = this.head;  //assigned head to newNode 

            if (this.head == null || this.head.data >= newnode.data) //compare condition is head is null and head data and is largest newNode data
            {
                newnode.next = this.head; //head is assigned to the newNode next
                this.head = newnode; //newNode assigned to the head
            }
            else
            {
                Node temp = this.head; //here Node type of temp variable create and assigned to the head

                /* Locate the node before the point of insertion */
                while (temp.next != null && temp.next.data < newnode.data) //comparing condition
                {
                    temp = temp.next; //increment temp variable
                }
                newnode.next = temp.next; //assigned to the temp next to the newNode next
                temp.next = newnode; //newnode assigned to the temp next
            }
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
