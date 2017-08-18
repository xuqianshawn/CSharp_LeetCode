using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace coding
{
 
      public class Node
      {
          public Node[] Children;
          public Node Right;
          public int Value;
          public Node(int value) {
          this.Value = value;
         }
      }

    class Program
    {
        public static void populateInterRightSiblings(Node node1, Node node2)
        {
            if (node1 == null || node1.Children == null || node2 == null || node2.Children == null)
            {
                return;
            }
            //node1 and node2 are neighbour, connect node1's rightmost to node2's leftmost 
            node1.Children.Last().Right=node2.Children.First();
        }
        public static void populateIntraRightSiblings(Node node)
        {
            if (node == null || node.Children == null || node.Children.Length == 1)
            {
                return;
            }
            int counterChildren=node.Children.Length;
            for (int i = 0; i < counterChildren; i++)
            {
                Node child = node.Children[i];
                if (i < counterChildren - 1)
                {
                    child.Right = node.Children[i + 1];
                }
                populateIntraRightSiblings(child);
                if (i < counterChildren - 1)
                {
                    populateInterRightSiblings(child, node.Children[i + 1]);
                }
               
            }
        }
        static void Main(string[] args)
        {


            Node _1 = new Node(1);
            Node _6 = new Node(6);
            Node _8 = new Node(8);
            Node _11 = new Node(11);
            Node _13 = new Node(13);
            Node _15 = new Node(15);
            Node _17 = new Node(17);
            Node _22 = new Node(22);
            Node _25 = new Node(25);
            Node _27 = new Node(27);

            _1.Children = new Node[] { _6 };
            _8.Children = new Node[] { _1, _11 };
            _13.Children = new Node[] { _8, _17 };
            _17.Children = new Node[] { _15, _25 };
            _25.Children = new Node[] { _22, _27 };

            Node root = _13;
            populateIntraRightSiblings(root);


            Console.ReadLine();

        }
    }
}
