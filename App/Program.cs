using System;
using DataStuctures.LinkedList.Singly;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            linkedList.AddLast(4);

            linkedList.AddLast(5);


            linkedList.AddAfter(linkedList.Head.Next, 32);

            var newNode = new SinglyLinkedListNode<int>(45);

            linkedList.AddAfter(linkedList.Head.Next.Next, newNode);



            linkedList.AddBefore(linkedList.Head.Next, 91);


            linkedList.AddBefore(linkedList.Head, 0);


            newNode = new SinglyLinkedListNode<int>(99);


            linkedList.AddBefore(linkedList.Head, newNode);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);

            }



            Console.ReadKey();

        }
    }
}
