using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC1LinkedListProblem..");
            UC1CreateLinkedList mylist = new UC1CreateLinkedList();
            mylist.insert(56);
            mylist.insert(30);
            mylist.insert(70);
            mylist.insert(90);
            mylist.DisplayAllEle();
        }
    }
}
