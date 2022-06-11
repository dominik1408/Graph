using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Node<T>
    {
        T value;

        int number;

        List<Edge> edges = new List<Edge>();
    }
}
