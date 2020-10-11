using System;

namespace ImplementingLinkedList
{
    public class LinkedList
    {
        private class ListNode
        {
            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }

            public ListNode(int value)
            {
                this.Value = value;
            }
        }

        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                ListNode first = new ListNode(element);
                this.head = first;
                this.tail = first;
            }
            else
            {
                ListNode first = new ListNode(element);
                first.NextNode = this.head;
                this.head.PreviousNode = first;
                this.head = first;
            }

            this.Count++;
        }

        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                ListNode last = new ListNode(element);
                this.head = last;
                this.tail = last;
            }
            else
            {
                ListNode last = new ListNode(element);
                last.PreviousNode = this.tail;
                this.tail.NextNode = last;
                this.tail = last;
            }

            this.Count++;
        }

        public int RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements in the list.");
            }

            int result = this.head.Value;

            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.head = this.head.NextNode;
                this.head.PreviousNode = null;
            }

            this.Count--;

            return result;
        }

        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements in the list.");
            }

            int result = this.tail.Value;

            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.tail = this.tail.PreviousNode;
                this.tail.NextNode = null;
            }

            this.Count--;

            return result;
        }

        public void ForEach()
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] arr = new int[this.Count];
            int idx = 0;

            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                arr[idx++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }

    }
}
