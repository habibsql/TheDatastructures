using System;
using System.Collections.Generic;
using System.Text;

namespace TheBasic.Heap
{
    public class HeapNode
    {
        // Parent will be null if it is RootNode
        public HeapNode Parent { get; set; }

        public HeapNode Left { get; set; }

        public HeapNode Right { get; set; }

        public long Value { get; set; }
       
    }
}
