using System;
using System.Collections.Generic;
using System.Text;

namespace BTS_uc1
{
    class Node
    {
        public int data;
        public Node LeftNode;
        public Node RightNode;

        public Node()
        {
            this.LeftNode = null;
            this.RightNode = null;
        }
    }
}