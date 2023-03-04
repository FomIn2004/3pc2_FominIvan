using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1
{
    //Для начала создадим класс Node
    internal class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
