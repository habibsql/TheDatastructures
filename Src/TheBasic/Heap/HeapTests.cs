using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheBasic.Heap
{
    public class HeapTests
    {
        [Fact]
        public void ShouldCreateHeap()
        {
            long[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var heap = new HeapStructure(values, 9L);

            Assert.Equal<long>(heap.RootNode.Value, (long)1);

            Assert.Equal<long>(heap.RootNode.Left.Value, (long)2);

            Assert.Equal<long>(heap.RootNode.Right.Value, (long)3);

            Assert.Equal(9, heap.NodeList.Count);
        }
    }
}
