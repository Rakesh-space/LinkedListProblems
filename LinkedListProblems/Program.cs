using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC5LinkedListProblem..");
            UC5DeleteFirst mylist5 = new UC5DeleteFirst();
            Console.WriteLine("\n insertAfter Operation Performed here:");
            mylist5.insert(56);
            mylist5.insert(30);
            mylist5.insert(70);
            mylist5.RemoveFirst();
            mylist5.DisplayAllEle();
           
        }
    }
}
