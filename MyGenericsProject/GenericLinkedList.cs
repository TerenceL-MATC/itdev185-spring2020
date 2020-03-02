using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MyGenericsProject
{
    class GenericLinkedList<T>
    {
        private Node<T> start;

        public GenericLinkedList()
        {
            start = null;
        }

        public void CreateList()
        {
            int i, n;
            T data;
            Type type = typeof(T);

            Write("Enter the number of nodes: ");

            while (!int.TryParse(ReadLine(), out n) || n < 0)
            {
                WriteLine("Value entered must be an non-negative integer.");
                Write("Enter the number of nodes: ");
            }

            if (n == 0)
                return;

            for (i = 0; i < n; i++)
            {
                Write("Enter the element to be inserted: ");

                object holder = null;
                do
                {
                    try
                    {
                        holder = Convert.ChangeType(ReadLine(), type);
                    }
                    catch (Exception)
                    {
                        WriteLine($"Value entered must be {typeof(T).Name}.");
                        Write("Enter the element to be inserted: ");
                    }
                } while (holder is null);

                data = (T)holder;
                InsertAtEnd(data);
            }
        }

        public bool IsEmpty()
        {
            return start is null;
        }

        public int Size()
        {
            if (IsEmpty())
            {
                return 0;
            }

            Node<T> p = start.link;
            int size;

            for (size = 1; p != null; p = p.link)
            {
                size++;
            }

            return size;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                WriteLine("The list is empty.");
                return;
            }


            Write("The list is: ");
            for (Node<T> p = start; p != null; p = p.link)
            {
                Write($"{p.data} ");
            }
            WriteLine();
        }

        public void InsertAtBeginning(T info)
        {
            Node<T> temp = new Node<T>(info);

            if (!IsEmpty())
            {
                temp.link = start;
            }

            start = temp;
        }

        public void InsertAtEnd(T info)
        {
            if (IsEmpty())
            {
                InsertAtBeginning(info);
                return;
            }

            Node<T> p;
            for (p = start; p.link != null; p = p.link) { }

            p.link = new Node<T>(info);
        }

        public void InsertAtPosition(T info, int position)
        {
            int highestPosition = Size() + 1;
            if (position < 1 || position > highestPosition)
            {
                WriteLine($"Can\'t insert at position {position}.  Position value must be from 1 to {highestPosition}.");
                return;
            }

            if (position is 1)
            {
                InsertAtBeginning(info);
            }
            else if (position == highestPosition)
            {
                InsertAtEnd(info);
            }
            else
            {
                Node<T> p = start,
                        temp = new Node<T>(info);

                for (int i = 1; i < position - 1; i++)
                {
                    p = p.link;
                }

                temp.link = p.link;
                p.link = temp;
            }
        }

        public T DeleteFirstNode()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException(@"Can't delete from an empty list");
            }

            T valueOfDeletedNode = start.data;

            if (Size() is 1)
            {
                start = null;
            }
            else
            {
                start = start.link;
            }

            return valueOfDeletedNode;
        }

        public T DeleteLastNode()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException(@"Can't delete from an empty list");
            }

            if (Size() is 1)
            {
                return DeleteFirstNode();
            }

            Node<T> p;

            for (p = start.link; p.link.link != null; p = p.link) { }

            T valueOfDeletedNode = p.link.data;
            p.link = null;
            return valueOfDeletedNode;
        }

        public T DeleteNodeAtPosition(int position)
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException(@"Can't delete from an empty list.");
            }

            int highestPosition = Size();
            if (position < 1 || position > highestPosition)
            {
                throw new InvalidOperationException($"Position {position} doesn\'t exist in the list.  Position value must be from 1 to {highestPosition}.");
            }

            if (position is 1)
            {
                return DeleteFirstNode();
            }

            if (position == highestPosition)
            {
                return DeleteLastNode();
            }

            Node<T> p = start;
            for (int i = 1; i < position - 1; i++)
            {
                p = p.link;
            }

            T valueOfDeletedNode = p.link.data;
            p.link = p.link.link;
            return valueOfDeletedNode;
        }

        public void ReverseList()
        {
            if (IsEmpty())
            {
                WriteLine(@"Can't reverse a empty list.");
                return;
            }

            //Check to see if there's more than one node in the list.
            if (start.link is null)
            {
                return;
            }

            Node<T> previous = null,
                    current = start,
                    next;

            while (current != null) //While there's still nodes to reverse
            {
                next = current.link;     //Identifies the next node to reverse
                current.link = previous; //Points link to node before it originally
                previous = current;      //Moves one step deeper into list for new position of previous
                current = next;          //Moves one step deeper into list for new position of next
            }

            start = previous; //Previous is the former end of the list. Now, become the start of the list.
        }

        public bool HasCycle()
        {
            if (FindCycle() is null)
            {
                return false;
            }

            return true;
        }

        private Node<T> FindCycle()
        {
            if (start is null || start.link is null)
            {
                return null;
            }

            Node<T> slowR = start,
                    fastR = start;

            while (fastR != null || fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;

                if (slowR == fastR)
                {
                    return slowR;
                }
            }

            return null;
        }

        public void RemoveCycle()
        {
            Node<T> c = FindCycle();

            if (c is null)
            {
                return;
            }

            WriteLine($"Value of the node at which the cycle was detected is {c.data}");

            Node<T> p = c,
                    q = c;

            int lenCycle = 0;

            do
            {
                lenCycle++;
                q = q.link;
            } while (p != q);

            WriteLine($"Length of cycle is {lenCycle}");

            int lenRemList;
            p = start;

            for (lenRemList = 0; p != q; lenRemList++)
            {
                p = p.link;
                q = q.link;
            }

            WriteLine($"Number of nodes not included in the cycle are {lenRemList}");

            int lengthList = lenCycle + lenRemList;
            WriteLine($"Length of the list is {lengthList}");

            p = start;
            for (int i = 1; i <= lengthList - 1; i++)
            {
                p = p.link;
            }

            p.link = null;
        }

        public void InsertCycle(T x)
        {
            if (start is null)
            {
                WriteLine(@"Can't insert a cycle on a empty list.");
                return;
            }

            Node<T> p,
                    px = null,
                    prev = null;

            for (p = start; p != null; p = p.link)
            {
                if (p.data.Equals(x))
                {
                    px = p;
                }

                prev = p;
            }

            if (px != null)
            {
                prev.link = px;
            }
            else
            {
                WriteLine($"{x} is not present in the list.");
            }
        }
    }
}
