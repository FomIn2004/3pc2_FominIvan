using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1
{
    internal class BinarySearchTree
    {
        //Начинаем с 1 задания
            public Node root;
            public BinarySearchTree()
            {
                this.root = null;
            }
            public void Add(int value)
            {
                if (root == null)
                {
                    root = new Node(value);
                }
                else
                {
                    AddRecursively(value, root);
                }
            }
            private void AddRecursively(int value, Node node)
            {
                if (value < node.value)
                {
                    if (node.left == null)
                    {
                        node.left = new Node(value);
                    }
                    else
                    {
                        AddRecursively(value, node.left);
                    }
                }
                else
                {
                    if (node.right == null)
                    {
                        node.right = new Node(value);
                    }
                    else
                    {
                        AddRecursively(value, node.right);
                    }
                }
            }
            public int SumValues()
            {
                return SumValuesRecursively(root);
            }

            private int SumValuesRecursively(Node node)
            {
                if (node == null)
                {
                    return 0;
                }
                else
                {
                    return node.value + SumValuesRecursively(node.left) + SumValuesRecursively(node.right);
                }
            }
        //Для второго задания ибо оно похоже на 1 и зачем делать все заного
        public int CountInternalNodes()
        {
            return CountInternalNodesRecursively(root);
        }
        private int CountInternalNodesRecursively(Node node)
        {
            if (node == null || (node.left == null && node.right == null))
            {
                return 0;
            }
            else
            {
                return 1 + CountInternalNodesRecursively(node.left) + CountInternalNodesRecursively(node.right);
            }
        }
        //Для третьего задания ибо нам опять нужно создать дерево поиска, оно у нас уже есть
        public List<int> GetNegativeValues()
        {
            List<int> negativeValues = new List<int>();
            GetNegativeValuesRecursively(root, negativeValues);
            return negativeValues;
        }

        private void GetNegativeValuesRecursively(Node node, List<int> negativeValues)
        {
            if (node == null)
            {
                return;
            }

            if (node.value < 0)
            {
                negativeValues.Add(node.value);
            }

            GetNegativeValuesRecursively(node.left, negativeValues);
            GetNegativeValuesRecursively(node.right, negativeValues);
        }

    }
}
    

