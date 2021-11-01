using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class DoublyLinkedList<T>
    {
        public DNode<T> head;
        public void InsertFront(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            newNode._next = head;
            newNode._prev = null;
            if (head != null)
            {
                head._prev = newNode;
            }
            head = newNode;
        }
        public void InsertLast(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            if (head == null)
            {
                newNode._next = null;
                head = newNode;
                return;
            }
            DNode<T> lastNode = GetLastNode();
            lastNode._next = newNode;
            newNode._prev = lastNode;
        }
        private DNode<T> GetLastNode()
        {
            DNode<T> temp = head;
            while (temp._next != null)
            {
                temp = temp._next;
            }
            return temp;
        }
        public void InsertAfter(DNode<T> prev_node, T new_data)
        {
            if (prev_node == null)
            {
                throw new ArgumentNullException("The given previous Node cannot be null");
            }
            DNode<T> newNode = new DNode<T>(new_data);
            newNode._next = prev_node._next;
            prev_node._next = newNode;
            newNode._prev = prev_node;
            if (newNode._prev != null)
            {
                newNode._next._prev = newNode;
            }
        }
        public void DeleteNodeByKey(T key)
        {
            DNode<T> temp = head;
            EqualityComparer<T> c = EqualityComparer<T>.Default;
            if (temp != null && c.Equals(temp._data, key))
            {
                head = temp._next;
                head._prev = null;
                return;
            }
            while (temp != null && !c.Equals(temp._data, key))
            {
                temp = temp._next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp._next != null)
            {
                temp._next._prev = temp._prev;
            }
            if (temp._prev != null)
            {
                temp._prev._next = temp._next;

            }
        }
        public void ReverseLinkedList()
        {
            DNode<T> prev = null;
            DNode<T> current = head;
            DNode<T> temp = null;
            while (current != null)
            {
                temp = current._next;
                current._next = prev;
                if (current._prev != null)
                {
                    prev._prev = current;

                }
                prev = current;
                current = temp;
            }
            head = prev;
            prev._prev = null;
        }
    }
}
