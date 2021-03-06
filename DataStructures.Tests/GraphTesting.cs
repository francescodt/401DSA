﻿using DataStructures.Graphing;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class GraphTesting
    {

        [Fact]
        public void EmptyGraphIsNull()
        {
            Graph<int> newGraph = new Graph<int>();

            Assert.Null(newGraph.GetNodes());
        }

        [Fact]
        public void VerticiesAreCool()
        {
            Graph<int> newGraph = new Graph<int>();
            newGraph.AddNode(2);
            

            Assert.Contains(2, newGraph.GetNodes());

        }

        [Fact]
        public void MultipleVerticiesAreEvenCooler()
        {
            Graph<int> newGraph = new Graph<int>();

            newGraph.AddNode(1);
            newGraph.AddNode(2);
            newGraph.AddNode(3);


            Assert.Contains(1, newGraph.GetNodes());
            Assert.Contains(2, newGraph.GetNodes());
            Assert.Contains(3, newGraph.GetNodes());

        }

        [Fact]
        public void WeightIsBadMmkay()
        {
            Graph<int> newGraph = new Graph<int>();
            newGraph.AddNode(1);
            newGraph.AddNode(2);
            newGraph.AddEdge(1, 2, 3);

            Assert.Equal(3, newGraph.GetNeighbors(1).GetValueOrDefault(2));
        }

        [Fact]
        public void GettingSizedUp()
        {
            Graph<int> newGraph = new Graph<int>();
            newGraph.AddNode(2);
            newGraph.AddNode(4);
            newGraph.AddNode(6);
            newGraph.AddNode(8);
            newGraph.AddNode(10);

            Assert.Equal(5, newGraph.Size());

        }

        [Fact]
        public void BreadthDoesntNotWork()
        {
            Graph<int> newGraph = new Graph<int>();
            Assert.Null(newGraph.BreadthFirstTraversal(2));
        }

        //[Fact]
        //public void ButDoesBreadthWork()
        //{
        //    Graph<int> newGraph = new Graph<int>();

        //    newGraph.AddNode(1);
        //    newGraph.AddNode(2);
        //    newGraph.AddNode(3);
        //    newGraph.AddNode(4);

        //    newGraph.AddEdge(1, 2);
        //    newGraph.AddEdge(1, 3);
        //    newGraph.AddEdge(2, 4);
        //    newGraph.AddEdge(3, 4);

        //    int[] expected = new int[] { 1, 2, 3, 4 };

        //    newGraph.BreadthFirstTraversal();

        //    Assert.Equal(expected, );
        //}
    }
}
