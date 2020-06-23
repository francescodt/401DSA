using DataStructures.Graphing;
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
        
    }
}
