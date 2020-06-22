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


    }
}
