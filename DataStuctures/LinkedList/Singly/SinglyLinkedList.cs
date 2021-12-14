using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStuctures.LinkedList.Singly
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {

        public SinglyLinkedList()
        {

        }
        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.AddLast(item);
            }


        }
        public SinglyLinkedListNode<T> Head { get; set; }

        private bool isHeadNull => Head == null;

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if (isHeadNull)
            {
                Head = newNode;
                return;
            }

            var current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;

        }
        public void AddAfter(SinglyLinkedListNode<T> refNode, T value)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException("");
            }

            var newNode = new SinglyLinkedListNode<T>(value);

            if (isHeadNull)
            {
                Head = newNode;
            }

            var current = Head;
            while (current.Next != null)
            {
                if (current.Equals(refNode))
                {
                    newNode.Next = current.Next;
                    refNode.Next = newNode;
                    return;
                }

                current = current.Next;
            }

        }

        public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException("");
            }

            if (isHeadNull)
            {
                throw new ArgumentNullException("");
            }

            var current = Head;
            while (current.Next != null)
            {
                if (current.Equals(refNode))
                {
                    newNode.Next = current.Next;
                    refNode.Next = newNode;
                    return;
                }

                current = current.Next;
            }
        }

        public void AddBefore(SinglyLinkedListNode<T> refNode, T value)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException("");
            }

            if (isHeadNull)
            {
                throw new ArgumentNullException("");
            }

            var current = Head;
            var newNode = new SinglyLinkedListNode<T>(value);

            if (current.Equals(refNode))
            {
                newNode.Next = current;
                Head = newNode;
                return;

            }

            while (current.Next != null)
            {
                if (current.Next == refNode)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
            }

            current = current.Next;


        }

        public void AddBefore(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentNullException("");
            }

            if (isHeadNull)
            {
                throw new ArgumentNullException("");
            }

            var current = Head;

            if (current.Equals(refNode))
            {
                newNode.Next = current;
                Head = newNode;
                return;

            }

            while (current.Next != null)
            {
                if (current.Next == refNode)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
            }

            current = current.Next;

        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception("Underflow! Nothing to remove");

            var firstValue = Head.Value;
            Head = Head.Next;

            return firstValue;


        }

        public T RemoveLast()
        {
            if (isHeadNull)
                throw new Exception("Underflow! Nothing to remove");

            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            var lastValue = prev.Next.Value;
            prev.Next = null;

            return lastValue;


        }
    }
}
