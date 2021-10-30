using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC10LinkedListProblem..");
            UC10AccendingOrder mylist10 = new UC10AccendingOrder();
            Console.WriteLine("\n Accending order Operation Performed here:");
            mylist10.insert(56);
            mylist10.insert(30);
            mylist10.insert(40);
            mylist10.insert(70);
            mylist10.sortedInsert();
            mylist10.DisplayAllEle();
        }
    }
}
