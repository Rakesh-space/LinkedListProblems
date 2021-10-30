using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC4LinkedListProblem..");
            UC4InsertBetween mylist4 = new UC4InsertBetween();
            Console.WriteLine("\n insertAfter Operation Performed here:");
            mylist4.insert(56);
            mylist4.insert(70);
            mylist4.insertAfter(mylist4.head.next, 30);
            mylist4.DisplayAllEle();

        }
    }
}
