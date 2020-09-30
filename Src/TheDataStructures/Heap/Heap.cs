using System;
using System.Collections.Generic;
using System.Text;

namespace TheBasic.Heap
{

    public class Heap
    {
        public HeapNode RootNode { get; private set; }

        public List<HeapNode> NodeList { get; private set; } = new List<HeapNode>();

        public Heap(long[] values, long size)
        {
            CreateHeap(values, size);
        }

        public void AddItem(int value)
        {
            var newNode = new HeapNode { Value = value };

            NodeList.Add(newNode);

            Heapify(RootNode);
        }

        public void DeleteItem(int value)
        {
            HeapNode node = SearchItemInner(RootNode, value);
            node.Left = null;
            node.Right = null;
            node.Parent = null;

            Heapify(RootNode);
        }

        /// <summary>
        /// Implementation is depends on Min/Max heap
        /// </summary>
        /// <param name="node"></param>
        private void Heapify(HeapNode node)
        {
            if (null == node || null == node.Parent)
            {
                return;
            }

            if (node.Value < node.Parent.Value)
            {
                HeapNode temp = node.Parent;
                node.Parent = node;
                node = temp;

                Heapify(node);
            }
        }


        public HeapNode SearchItem(int value)
        {
            return SearchItemInner(RootNode, value);
        }

        private HeapNode SearchItemInner(HeapNode node, int value)
        {
            if (null == node)
            {
                return null;
            }

            if (node.Value == value)
            {
                return node;
            }

            HeapNode nd = SearchItemInner(node.Left, value);

            if (null != nd)
            {
                return nd;
            }
            else
            {
                return SearchItemInner(node.Right, value);
            }
        }

        private void CreateHeap(long[] values, long size)
        {
            PopulateNodes(values, size);
            SetLeftRightParentNode(values, size);

            RootNode = NodeList[0];
        }

        private void PopulateNodes(long[] values, long size)
        {
            for (long i = 0; i < size; i++)
            {
                var node = new HeapNode
                {
                    Value = values[i]
                };

                node.Parent = GetParentNode(i);

                NodeList.Add(node);
            }
        }

        private void SetLeftRightParentNode(long[] values, long size)
        {
            for (long i = 0; i < size / 2; i++)
            {
                HeapNode currentNode = NodeList[Convert.ToInt32(i)];
                currentNode.Left = GetLeftNode(i);
                currentNode.Right = GetRightNode(i);
            }
        }

        private HeapNode GetParentNode(long index)
        {
            if (index == 0)
            {
                return null;
            }

            long parentNodeIndex = (long)Math.Ceiling(Convert.ToDecimal(index) / 2) - 1;

            return NodeList[(int)parentNodeIndex];
        }

        private HeapNode GetLeftNode(long index)
        {
            if (index == 0)
            {
                return NodeList[(int)index + 1];
            }

            long leftNodeIndex = 2 * index + 1;

            return NodeList[(int)leftNodeIndex];
        }

        private HeapNode GetRightNode(long index)
        {
            if (index == 0)
            {
                return NodeList[(int)index + 2];
            }

            long rightNodeIndex = 2 * index + 2;

            return NodeList[(int)rightNodeIndex];
        }

    }
}
