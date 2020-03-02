using System;
using System.Collections.Generic;
using System.Text;

namespace MyGenericsProject
{
    class Node<T>
    {
        public T data;
        public Node<T> link;

        public Node(T info)
        {
            data = info;
            link = null;
        }
    }
}
