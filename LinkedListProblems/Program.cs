using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC7LinkedListProblem..");
            UC7SearchOperation mylist7 = new UC7SearchOperation();
            Console.WriteLine("\n insertAfter Operation Performed here:");
            mylist7.insert(56);
            mylist7.insert(30);
            mylist7.insert(70);
            mylist7.DisplayAllEle();
            mylist7.Search(30);
            mylist7.DisplayAllEle();
        }
    }
}
