using DataStructures.BinaryTrees;
using System;
using System.Collections;
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

        [Fact]
        public void AddToTree()
        {
            BinarySearchTree<int> newNode = new BinarySearchTree<int>();

            newNode.Add(1);
            int expected = 1;

            Assert.Equal(expected, newNode.Root.Value);
        }

        [Fact]
        public void AddLeftChildRightChildToSingleRootNode()
        {
            BinarySearchTree<int> newNode = new BinarySearchTree<int>();

            newNode.Add(2);
            newNode.Add(1);
            newNode.Add(3);

            Assert.Equal(2, newNode.Root.Value);
            Assert.Equal(1, newNode.Root.Left.Value);
            Assert.Equal(3, newNode.Root.Right.Value);
        }

        [Fact]
        public void CanReturnPreOrder()
        {
            BinarySearchTree<int> newNode = new BinarySearchTree<int>();
            newNode.Add(7);
            newNode.Add(4);
            newNode.Add(8);
            newNode.Add(1);

            
            Assert.True(newNode.Contains(newNode.Root, 7));
            Assert.True(newNode.Contains(newNode.Root.Left, 4));
            Assert.True(newNode.Contains(newNode.Root.Right, 8));
            Assert.True(newNode.Contains(newNode.Root.Left.Left, 1));
        }

       [Fact]
       public void CanFindMax()
        {
            NumberBinaryTree newNode = new NumberBinaryTree();
            newNode.Add(2);
            newNode.Add(1);
            newNode.Add(10);
            newNode.Add(40);
            newNode.Add(23);
            int expected = 40;

            Assert.Equal(expected, newNode.GetMax());
        }

        [Fact]

        public void BreadthTravesalTest()
        {
            
            NumberBinaryTree myTree = new NumberBinaryTree();
            myTree.Add(10);
            myTree.Add(5);
            myTree.Add(4);
            myTree.Add(13);
            int[] expected = new int[] { 10, 5, 13, 4 };

            List<int> actual = myTree.Breadth();

            Assert.Equal(expected, actual);
        }
    }

    


}
