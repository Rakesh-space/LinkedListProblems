using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class UC9DeleteAtPossi
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
        //Delete an element at the given position
        public void deleteAtPossi(int possi) //delete at given possition wise
        {
            if (possi < 1)  //here cheked the 1 less value
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (possi == 1 && head != null)  //here cheked the possi=1 and head not null
            {
                Node nodeToDelete = head;  // then assgined the head newToDelete
                head = head.next;   // here logic implement to the delete previoues node
                nodeToDelete = null;
            }
            else
            {
                Node temp = head; //here head assigned to the temp 
                for (int i = 1; i < possi - 1; i++) //till possi-1 then i increment
                {
                    if (temp != null) //till temp not null 
                    {
                        temp = temp.next;//temp increment
                    }
                }
                if (temp != null && temp.next != null) //here till temp not null and temp.next not null
                {
                    Node nodeToDelete = temp.next;//to assigned the temp.next nodeToDelete
                    temp.next = temp.next.next; //here nodetodelete previoues node to link to temp.next.next
                    nodeToDelete = null;
                }
                else
                {
                    Console.Write("\nThe node is already null.");
                }
            }
        }

        internal void DisplayAllEle() //display the data of linkedlist
        {
            Console.WriteLine("\nDisplay LinkedList element is:");
            Node t = this.head;
            if (t == null)  //cheking the linklinst is empty or not
            {
                Console.WriteLine("\n Linked List empty"); a
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
