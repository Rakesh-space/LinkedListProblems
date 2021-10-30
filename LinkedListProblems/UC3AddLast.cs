using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class UC3AddLast
    {

        internal Node head;
        internal void AddLast(int data) //Appending in last ..
        {
            Node new_node2 = new Node(data);  //here create new_node2 allocate memory here and assinged the data
            if (this.head == null)   //checking the head is null or not
            {
                this.head = new_node2; //assigned the new_node2 to head
            }
            else
            {
                Node temp = this.head;   //here Node type temp variable created
                while (temp.next != null)  //check the temp.next till not null then addLast node
                {
                    temp = temp.next;      //increment node
                }
                temp.next = new_node2; //new_node2 assgined to the temp->next
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
