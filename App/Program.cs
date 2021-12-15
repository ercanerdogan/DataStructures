using System;
using System.Linq;
using DataStuctures.LinkedList.Singly;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            //var rnd = new Random();
            //var inital = Enumerable.Range(1, 5).OrderBy(x => rnd.Next()).ToList();

            //var list = new SinglyLinkedList<int>(inital);

            //DisplayList(list);

            //Console.WriteLine("-----");

            //Console.WriteLine($"{list.RemoveFirst()} has been removed");
            //Console.WriteLine($"{list.RemoveFirst()} has been removed");
            //Console.WriteLine("-----");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);

            //}


            //Console.WriteLine("-----");

            //Console.WriteLine($"{list.RemoveLast()} has been removed");
            //Console.WriteLine("-----");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);

            //}


            Console.WriteLine("-----");

            var list = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 5 });

            list.Remove(3);

            list.Remove(5);

            DisplayList(list);

            Console.WriteLine("-----");



            Console.ReadKey();


        }
        private static void DisplayList(SinglyLinkedList<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
        }

        private static void usageSamples01()
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
        }

        private static void UsageSamples02()
        {

            //LINQ samples
            var rnd = new Random();
            var inital = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();

            var linkedList2 = new SinglyLinkedList<int>(inital);

            linkedList2.Where(x => x % 2 == 1).ToList().ForEach(x => Console.Write(x + " "));

            Console.ReadKey();
        }
    }
}
