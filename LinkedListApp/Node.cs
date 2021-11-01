using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class Node<K>
    {
        public K _data;
        public Node<K> _next;
        public Node(K data)
        {
            _data = data;
            _next = null;
        }
    }
}
