using DataStructures.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void InstantiateEmptyTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            Assert.Null(binaryTree.Root);
        }
    }


}
