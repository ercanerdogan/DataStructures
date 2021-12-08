using System;
using System.Collections.Generic;
using System.Text;

namespace DataStuctures.LinkedList.Singly
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString() => $"{Value}";
    }
}
