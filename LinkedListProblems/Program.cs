using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC3LinkedListProblem..");
            UC3AddLast mylist3 = new UC3AddLast();
            Console.WriteLine("\n AddLast Operation Performed here:");
            mylist3.AddLast(56);
            mylist3.AddLast(30);
            mylist3.AddLast(70);
            mylist3.DisplayAllEle();
          
        }
    }
}
