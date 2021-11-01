using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class SinglyLinkedList<T>
    {
        public Node<T> head;
        public void InsertFront(T new_data)
        {
            Node<T> newNode = new Node<T>(new_data);
            newNode._next = head;
            head = newNode;
        }
        public void InsertLast(T new_data)
        {
            Node<T> newNode = new Node<T>(new_data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> lastNode = GetLastNode();
            lastNode._next = newNode;

        }
        private Node<T> GetLastNode()
        {
            Node<T> temp = head;
            while (temp._next != null)
            {
                temp = temp._next;
            }
            return temp;
        }
        public void InsertAfter(Node<T> prev_node, T new_data)
        {
            if (prev_node == null)
            {
                throw new ArgumentNullException("The given previous Node cannot be null");

            }
            Node<T> newNode = new Node<T>(new_data);
            newNode._next = prev_node._next;
            prev_node._next = newNode;
        }
        public void DeleteNodeByKey(T key)
        {
            EqualityComparer<T> c = EqualityComparer<T>.Default;
            Node<T> temp = head;
            Node<T> prev = null;
            if (temp != null && c.Equals(temp._data,key))
            {
                head = temp._next;
                return;
            }
            while (temp != null && !c.Equals(temp._data, key))
            {
                prev = temp;
                temp = temp._next;
            }
            if (temp == null)
            {
                return;
            }
            prev._next = temp._next;
        }
        public void ReverseLinkedList() 
        {
            Node <T> prev= null;
            Node<T> current = head;
            Node<T> temp = null;
            while (current != null)
            {
                temp = current._next;
                current._next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }
    }
}
