using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC5LinkedListProblem..");
            UC6Deletelast mylist5 = new UC6Deletelast();
            Console.WriteLine("\n insertAfter Operation Performed here:");
            mylist5.insert(56);
            mylist5.insert(30);
            mylist5.insert(70);
            mylist5.RemoveLast();
            mylist5.DisplayAllEle();
           
        }
    }
}
