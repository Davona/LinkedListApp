using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class DNode<K>
    {
        public K _data;
        public DNode<K> _next;
        public DNode<K> _prev;
        public DNode(K data)
        {
            _data = data;
            _next = null;
            _prev = null;
        }
    }
}
