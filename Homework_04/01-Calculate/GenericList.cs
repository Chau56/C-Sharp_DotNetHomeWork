using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Calculate
{
    class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public Node<T> Tail
        {
            get => tail;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node = head;
            while (node != tail && head != null)
            {
                action(node.Data);
                node = node.Next;
            }
        }
    }
}
