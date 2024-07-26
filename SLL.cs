using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            public Node(object data, Node next = null)
            {
                Data = data;
                Next = next;
            }
        }
        private Node head;
        private int size;

        public SLL()
        {
            head = null;
            size = 0;
        }

        public void Append(object data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            size++;
        }

        public void Clear()
        {
            head = null;
            size = 0;
        }

        public bool Contains(object data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= size) throw new IndexOutOfRangeException();

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next?.Next;
            }
            size--;
        }

        public int IndexOf(object data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public void Insert(object data, int index)
        {
            if (index < 0 || index > size) throw new IndexOutOfRangeException();
            if (data == null) throw new ArgumentNullException(nameof(data));

            if (index == 0)
            {
                head = new Node(data, head);
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(data, current.Next);
            }
            size++;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Prepend(object data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            head = new Node(data, head);
            size++;
        }

        public void Replace(object data, int index)
        {
            if (index < 0 || index >= size) throw new IndexOutOfRangeException();
            if (data == null) throw new ArgumentNullException(nameof(data));

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = data;
        }

        public object Retrieve(int index)
        {
            if (index < 0 || index >= size) throw new IndexOutOfRangeException();

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public int Size()
        {
            return size;
        }
    }

}
