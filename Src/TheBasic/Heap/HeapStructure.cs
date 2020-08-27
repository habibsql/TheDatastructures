using System;
using System.Collections.Generic;
using System.Text;

namespace TheBasic.Heap
{

    public class HeapStructure
    {
        public HeapNode RootNode { get; private set; }

        public List<HeapNode> NodeList { get; private set; } = new List<HeapNode>();

        public HeapStructure(long[] values, long size)
        {
            CreateHeap(values, size);
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

            long parentNodeIndex = (long) Math.Ceiling(Convert.ToDecimal(index) / 2 ) - 1;

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
