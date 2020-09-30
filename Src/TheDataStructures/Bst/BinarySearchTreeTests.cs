using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheBasic.Bst
{
    public class BinarySearchTreeTests
    {

        [Fact]
        public void TreeInsertTest()
        {
            var bt = new BinarySearchTree();
            bt.InsertItem(11);
        }

        [Fact]
        public void TreeBreathFirstTraversalTest()
        {
            var bt = new BinarySearchTree();
            bt.TraverseBreathFirst();
        }


        [Fact]
        public void TreeInOrderTraverseTest()
        {
            var bt = new BinarySearchTree();
            bt.TraverseInOrder();
        }

        [Fact]
        public void TreePreOrderTraverseTest()
        {
            var bt = new BinarySearchTree();
            bt.TraversePreOrder();
        }

        [Fact]
        public void TreePostOrderTraverseTest()
        {
            var bt = new BinarySearchTree();
            bt.TraversePostOrder();
        }

        [Fact]
        public void SearchTest()
        {
            var bt = new BinarySearchTree();
            TreeNode resultNode = bt.Search(5);

            Assert.NotNull(resultNode);
            Assert.Equal(5, resultNode.Value);
        }

        [Fact]
        public void HeightTest()
        {
            var bt = new BinarySearchTree();
            int height = bt.CalculateHeight();

            Assert.Equal(3, height);
        }
    }
}
