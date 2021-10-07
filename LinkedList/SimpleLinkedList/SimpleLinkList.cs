using LinkedList.Models;
using System;

namespace LinkedList.SimpleLinkedList
{
    public class SimpleLinkList<T>
    {
        Node<T> Head = null;
        Node<T> Tail = null;

        /// <summary>
        /// Add node at last of linklist O(n) complexity
        /// </summary>
        /// <param name="data"></param>
        public void AddLast(T data)
        {
            Node<T> nodeItem = new Node<T>();
            nodeItem.data = data;

            if (Head == null)
            {
                Head = nodeItem;
                nodeItem.next = null;
            }
            else
            {
                var currentNode = Head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }

                currentNode.next = nodeItem;

                nodeItem.next = null;
            }
        }

        /// <summary>
        /// Add Last with O(1) complexity
        /// </summary>
        /// <param name="data"></param>
        public void AddLastWithOptimization(T data)
        {
            Node<T> nodeItem = new Node<T>();
            nodeItem.data = data;

            if (Head == null)
            {
                Tail = Head = nodeItem;
                nodeItem.next = null;
            }
            else
            {
                var currentNode = Tail;
                currentNode.next = nodeItem;
                Tail = nodeItem;
                nodeItem.next = null;
            }
        }

        /// <summary>
        /// Add Item as first Node
        /// </summary>
        /// <param name="data"> data need to be inserted</param>
        public void AddFirst(T data)
        {
            Node<T> nodeItem = new Node<T>();
            nodeItem.data = data;

            if (Head == null)
            {
                nodeItem.next = null;
                Head = nodeItem;
            }
            else
            {
                nodeItem.next = Head;
                Head = nodeItem;
            }
        }

        public void ReadAll()
        {
            var currentNode = Head;
            while (currentNode.next != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
            Console.WriteLine(currentNode.data);
        }
    }
}
