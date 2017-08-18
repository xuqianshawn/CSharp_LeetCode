using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;


namespace coding
{
      public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
      public TreeNode() { }
     }
 


      public class Node
      {
          public Node[] Children;
          public Node Right;

          //those fields & constructor are added for debugging purpose
          public int Value;
          public Node(int value) {
          this.Value = value;
         }
      }

    class Program
    {

        // Encodes a tree to a single string.
        public static string serialize(TreeNode root)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string outputStr=serializer.Serialize(root);
            return outputStr;
        }

        // Decodes your encoded data to tree.
        public static TreeNode deserialize(string data)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            TreeNode output=serializer.Deserialize<TreeNode>(data);
            return output;
        }

        public static void populateInterRightSiblings(Node node1, Node node2)
        {
            if (node1 == null || node1.Children == null || node2 == null || node2.Children == null)
            {
                return;
            }
            //node1 and node2 are neighbour, connect node1's rightmost to node2's leftmost 
            node1.Children.Last().Right=node2.Children.First();
        }
        public static Dictionary<int, Int64> getFibonacciSeries()
        {
            Dictionary<int, Int64> cached = new Dictionary<int, Int64>();
            for (int i = 1; i <= 50; i++)
            {
                getFibonacciSeries(i, cached);
            }
            return cached;
        }
        public static Int64 getFibonacciSeries(int N, Dictionary<int, Int64> cache)
        {
            if (N == 1 || N == 2)
            {
                if (!cache.ContainsKey(N))
                {
                    cache.Add(N, 1);
                }
                return 1;
            }
            else if (cache.ContainsKey(N))
            {
               
                return cache[N];
            }
            else
            {
                Int64 temp = getFibonacciSeries(N - 2, cache) + getFibonacciSeries(N - 1, cache);
                cache.Add(N, temp);
                return temp;
            }
        
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
                    //assign Right field to next node at same level which share same parent
                    child.Right = node.Children[i + 1];
                }
                populateIntraRightSiblings(child);
                if (i < counterChildren - 1)
                {
                    //assign Right field to next node at same level which share different parent
                    populateInterRightSiblings(child, node.Children[i + 1]);
                }
               
            }
        }
        public static void Modify(string s)
        {
            s = s + "2";
        }
        static void Main(string[] args)
        {
            TreeNode _1= new TreeNode(1);
            TreeNode _2 = new TreeNode(2);
            TreeNode _3 = new TreeNode(3);
            TreeNode _4 = new TreeNode(4);
            TreeNode _5 = new TreeNode(5);
            string s = "inital";
            Modify(s);

            //_1.left = _2;
            //_1.right = _3;
            //_2.left = _4;
            //_3.left = _5;
            //string s=serialize(_1);
            //TreeNode _1nd= deserialize(s);
            ////Queue<TreeNode> trees = new Queue<TreeNode>();
            ////TreeNode t=trees.Dequeue();
            ////getFibonacciSeries();
            ////Node _1 = new Node(1);
            //var fields = _1.GetType().GetFields();
            //foreach (var field in fields)
            //{
            //    Console.Write("field Name: " + field.Name + " field Value: " + field.GetValue(_1));
            //}
            //Node _6 = new Node(6);
            //Node _8 = new Node(8);
            //Node _11 = new Node(11);
            //Node _13 = new Node(13);
            //Node _15 = new Node(15);
            //Node _17 = new Node(17);
            //Node _22 = new Node(22);
            //Node _25 = new Node(25);
            //Node _27 = new Node(27);

            //_1.Children = new Node[] { _6 };
            //_8.Children = new Node[] { _1, _11 };
            //_13.Children = new Node[] { _8, _17 };
            //_17.Children = new Node[] { _15, _25 };
            //_25.Children = new Node[] { _22, _27 };

            //Node root = _13;
            //populateIntraRightSiblings(root);

            //bool isitPalindrome = IsPalindrome(123454321);
            //bool isitPalindrome2 = IsPalindrome(1);
            //bool isitPalindrome3 = IsPalindrome(1211);
            Console.ReadLine();

        }
        public int MaxArea(int[] height)
        {
            if (height.Length < 1)
            {
                return 0;
            }
            int starting = 0;
            int ending = height.Length-1;
            int area = 0;
            while (starting < ending) {
                int temparea = (ending - starting) * Math.Min(height[starting],height[ending]);
                if (temparea > area)
                {
                    area = temparea;
                }
                if (height[starting] > height[ending])
                {
                    --ending;
                }
                else
                {
                    starting++;
                }
            }
            return area;
        }
        public static bool IsPalindrome(int x)
        {
            string inputStr = x.ToString();
            
            if (inputStr.Length==1)
            {
                return true;
            }
            for (int i = 0; i < inputStr.Length / 2; i++)
            {
                string front = inputStr.Substring(i, 1);
                string end = inputStr.Substring(inputStr.Length - i - 1, 1);
                if (!front.Equals(end))
                {
                    return false;
                }
            }
            return true;
           
        }

        
    }
}
