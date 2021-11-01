using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<string> singlyLinkedList = new SinglyLinkedList<string>();
            singlyLinkedList.InsertFront("A");
            singlyLinkedList.InsertFront("B");
            singlyLinkedList.InsertFront("C");
            singlyLinkedList.InsertFront("D");
            singlyLinkedList.InsertFront("E");
            singlyLinkedList.DeleteNodeByKey("D");
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.InsertFront(4);
            doublyLinkedList.InsertFront(3);
            doublyLinkedList.InsertFront(2);
            doublyLinkedList.InsertFront(1);
            doublyLinkedList.InsertFront(0);
            doublyLinkedList.ReverseLinkedList();
        }
    }
}
