using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC8LinkedListProblem..");
            UC8InsertAfter mylist8 = new UC8InsertAfter();
            Console.WriteLine("\n insertAfter Operation Performed here:");
            mylist8.insert(56);
            mylist8.insert(30);
            mylist8.insert(70);
            mylist8.insertAfter(mylist8.head.next, 40);
            mylist8.DisplayAllEle();
        }
    }
}
