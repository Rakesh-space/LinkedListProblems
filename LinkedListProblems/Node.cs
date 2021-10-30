using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class Node
    {
        internal int data; //declare the integer type data variable
        internal Node next; //next varible is Node type class under the considar as a integer type (next) variable
        internal int possi;
        internal Node(int data) //here is constructor
        {
            this.data = data; //value assgined to the instance variables
            next = null;
        }
    }
}
