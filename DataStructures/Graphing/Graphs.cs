using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Graphing
{
    public class Graph<T>
    {
        Dictionary<T, Dictionary<T, int>> Nodes;
        public Graph()
        {
            Nodes = new Dictionary<T, Dictionary<T, int>>();
        }

        public bool AddNode(T value)
        {
            if (Nodes.ContainsKey(value)) return false;

            Nodes.Add(value, new Dictionary<T, int>());
            return true;
        }

        public bool AddEdge(T firstNodeValue, T secondNodeValue, int weight = 1, bool oneWay = false)
        {

            if (!Nodes.ContainsKey(firstNodeValue) || !Nodes.ContainsKey(secondNodeValue)) return false;

            Dictionary<T, int> nodeOne = Nodes[firstNodeValue];
            Dictionary<T, int> nodeTwo = Nodes[secondNodeValue];

            if (nodeOne.ContainsKey(firstNodeValue)) return false;

            if (!oneWay && !firstNodeValue.Equals(secondNodeValue))
            {
                if (nodeTwo.ContainsKey(firstNodeValue)) return false;
                nodeTwo.Add(firstNodeValue, weight);
            }


            nodeOne.Add(secondNodeValue, weight);
            return true;
        }

        public List<T> GetNodes()
        {
            if (Nodes.Keys.Count < 1) return null;
            return Nodes.Keys.ToList();
        }

        public Dictionary<T, int> GetNeighbors(T value)
        {
            if (!Nodes.ContainsKey(value)) return null;

            return Nodes[value];
        }

        public int Size()
        {
            return Nodes.Keys.Count;
        }

        public List<T> BreadthFirstTraversal(T value)
        {
            if (!Nodes.ContainsKey(value))
            {
                return null;
            }

            Dictionary<T, bool> visited = new Dictionary<T, bool>();
            visited.Add(value, true); 

            List<T> output = new List<T> { value };
            Queue<T> breadthTraversal = new Queue<T>();

            while (breadthTraversal.Count > 0)
            {
                var currentValue = breadthTraversal.Dequeue();
                if (visited.ContainsKey(currentValue))
                {
                    continue;
                }

                visited.Add(currentValue, true);
                output.Add(currentValue);

                foreach (var edge in Nodes[value])
                {
                    breadthTraversal.Enqueue(edge.Key);
                }
            }

            return output;
        }
    }
}
