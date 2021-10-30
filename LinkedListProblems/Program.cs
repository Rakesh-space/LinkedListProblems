using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC2LinkedListProblem..");
            UC2AddFirst mylist2 = new UC2AddFirst();
            Console.WriteLine("\n AddFirst Operation Performed here:");
            mylist2.AddFirst(56);
            mylist2.AddFirst(30);
            mylist2.AddFirst(70);
            mylist2.DisplayAllEle();
        }
    }
}
