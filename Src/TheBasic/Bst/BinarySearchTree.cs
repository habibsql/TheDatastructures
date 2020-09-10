using System;
using System.Collections.Generic;
using System.Text;

namespace TheBasic.Bst
{
    public class BinarySearchTree
    {
        public TreeNode RootNode { get; private set; }

        public BinarySearchTree()
        {
            BuildBinarySearchTree();
        }

        public void InsertItem(int itemValue)
        {
            TreeNode newNode = new TreeNode
            {
                Value = itemValue
            };

            if (null == RootNode)
            {
                RootNode = newNode;
                return;
            }

            TreeNode currentNode = RootNode;
            TreeNode parentNode = null;

            while (true)
            {
                parentNode = currentNode;

                if (itemValue <= currentNode.Value)
                {
                    currentNode = currentNode.Left;

                    if (null == currentNode)
                    {
                        parentNode.Left = newNode;
                        return;
                    }

                }

                if (itemValue > currentNode.Value)
                {
                    currentNode = currentNode.Right;

                    if (null == currentNode)
                    {
                        parentNode.Right = newNode;
                        return;
                    }
                }
            }
        }

        public void TraverseInOrder()
        {
            InOrder(RootNode);
        }

        public void TraversePostOrder()
        {
            PostOrder(RootNode);
        }

        public void TraversePreOrder()
        {
            PreOrder(RootNode);
        }

        public void TraverseBreathFirst()
        {
            BreathFirst(RootNode);
        }

        public TreeNode Search(int value)
        {
            return SearchValue(RootNode, value);
        }

        public int CalculateHeight()
        {
            return CalculateMaxHeight(RootNode);
        }

        private void BuildBinarySearchTree()
        {
            var node20 = new TreeNode
            {
                Value = 20,
            };
            var node15 = new TreeNode
            {
                Value = 15
            };
            var node25 = new TreeNode
            {
                Value = 25
            };
            var node10 = new TreeNode
            {
                Value = 10
            };
            var node18 = new TreeNode
            {
                Value = 18
            };
            var node23 = new TreeNode
            {
                Value = 23
            };
            var node27 = new TreeNode
            {
                Value = 27
            };
            var node5 = new TreeNode
            {
                Value = 5
            };
            var node12 = new TreeNode
            {
                Value = 12
            };
            var node17 = new TreeNode
            {
                Value = 17
            };

            var node19 = new TreeNode
            {
                Value = 19
            };
            var node22 = new TreeNode
            {
                Value = 22
            };
            var node24 = new TreeNode
            {
                Value = 24
            };

            var node26 = new TreeNode
            {
                Value = 26
            };
            var node28 = new TreeNode
            {
                Value = 28
            };

            node20.Left = node15;
            node20.Right = node25;
            node15.Left = node10;
            node15.Right = node18;
            node10.Left = node5;
            node10.Right = node12;
            node18.Left = node17;
            node18.Right = node19;
            node25.Left = node23;
            node25.Right = node27;
            node23.Left = node22;
            node23.Right = node24;
            node27.Left = node26;
            node27.Right = node28;

            RootNode = node20;
        }

        private void InOrder(TreeNode node)
        {
            if (null == node)
            {
                return;
            }

            InOrder(node.Left);

            System.Diagnostics.Debug.WriteLine("+InOrder -> Node Value=" + node.Value);

            InOrder(node.Right);
        }

        private void PreOrder(TreeNode node)
        {
            if (null == node)
            {
                return;
            }

            System.Diagnostics.Debug.WriteLine("+PreOrder -> Node Value=" + node.Value);

            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        private void PostOrder(TreeNode node)
        {
            if (null == node)
            {
                return;
            }

            PostOrder(node.Left);
            PostOrder(node.Right);

            System.Diagnostics.Debug.WriteLine("+PostOrder -> Node Value=" + node.Value);
        }

        private void BreathFirst(TreeNode node)
        {
            if (null == node)
            {
                return;
            }

            var tempQueue = new Queue<TreeNode>();
            tempQueue.Enqueue(RootNode);

            while (tempQueue.Count > 0)
            {
                TreeNode currentNode = tempQueue.Dequeue();

                System.Diagnostics.Debug.WriteLine($"+BreathFirst -> Node Value = {currentNode.Value}");

                if (null != currentNode.Left)
                {
                    tempQueue.Enqueue(currentNode.Left);
                }

                if (null != currentNode.Right)
                {
                    tempQueue.Enqueue(currentNode.Right);
                }
            }
        }

        private TreeNode SearchValue(TreeNode node, int value)
        {
            if (null == node)
            {
                return null;
            }

            if (node.Value == value)
            {
                return node;
            }

            if (value < node.Value)
            {
                return SearchValue(node.Left, value);
            }
            else
            {
                return SearchValue(node.Right, value);
            }
        }

        private int CalculateMaxHeight(TreeNode node)
        {
            if (null == node)
            {
                return -1;
            }

            int leftHeight = CalculateMaxHeight(node.Left);
            int rightHeight = CalculateMaxHeight(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}

