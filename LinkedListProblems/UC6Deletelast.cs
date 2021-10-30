using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class UC6Deletelast
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

        internal Node RemoveLast() //removing last element in given linklist
        {
            if (this.head == null) //check the head is null or not
            {
                return null;
            }
            if (this.head.next == null) //check the head->next is null or not
            {
                return null;
            }
            Node newNode6 = this.head;  //here Node type of newNode6 is created
            while (newNode6.next.next != null)  //check the till last node is null
            {
                newNode6 = newNode6.next; //increment in newNode6
            }
            newNode6.next = null; //then last secound node is break the last element int given linklist
            return head;
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
