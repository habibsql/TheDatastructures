using System;
using System.Collections.Generic;
using System.Text;

namespace TheBasic.Heap
{
    public class HeapNode
    {
        public long Value { get; set; }

        public HeapNode Left { get; set; }

        public HeapNode Right { get; set; }
        
        public HeapNode Parent { get; set; }
    }
}
