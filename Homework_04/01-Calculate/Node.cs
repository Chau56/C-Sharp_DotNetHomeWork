using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Calculate
{
    class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T date)
        {
            Next = null;
            Data = date;
        }
    }
}
