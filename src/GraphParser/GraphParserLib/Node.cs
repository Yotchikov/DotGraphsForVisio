﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphParserLib
{
    public class Node
    {
        private string style;
        private List<Edge> edges;

        public Node(string attributes)
        {
            this.style = attributes;
        }

        public void AddNeighbour(Node second, string attributes)
        {
            edges.Add(new Edge(this, second, attributes));
        }
    }
}
