using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3_skeleton
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(object data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
