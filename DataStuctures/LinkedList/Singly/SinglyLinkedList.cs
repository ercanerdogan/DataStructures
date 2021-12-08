using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStuctures.LinkedList.Singly
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
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
    }
}
