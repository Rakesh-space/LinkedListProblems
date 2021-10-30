using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC9LinkedListProblem..");
            UC9DeleteAtPossi mylist9 = new UC9DeleteAtPossi();
            Console.WriteLine("\n deleteAfter Operation Performed here:");
            mylist9.insert(56);
            mylist9.insert(30);
            mylist9.insert(40);
            mylist9.insert(70);
            //   mylist9.DisplayAllEle();
            mylist9.deleteAtPossi(3);
            mylist9.DisplayAllEle();
        }
    }
}
