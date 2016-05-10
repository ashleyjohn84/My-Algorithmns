using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class SwapTreeNodes
    {
        static List<Node> nodes = new List<Node>();
   
        static List<List<int>> outputList = new List<List<int>>();
        static void MainFunction()
        {
            int noOfNodes = Convert.ToInt32(Console.ReadLine());
            Node root =  CreateTree(noOfNodes);
            int noOfSwaps = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < noOfSwaps; i++)
            {
                List<int> output = new List<int>();
                nodes.Clear();
                int swapLevel = Convert.ToInt32(Console.ReadLine());
                SwapTree(swapLevel, root,0);
                SwapNodesAtAllLevels();
                InOrder(root,output);
                outputList.Add(output);
            }
            foreach (var output in outputList)
            {
                foreach (var i in output)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }


        }

        private static void InOrder(Node root,List<int> output )
        {
            if (root != null)
            {
                InOrder(root.left, output);
                output.Add(root.data);
                InOrder(root.right, output);
            }
        }


        private static void SwapTree(int swapLevel, Node root,int currentLevel)
        {

            
            if (root != null)
            {
                if ((currentLevel + 1) % swapLevel == 0)
                {
                    nodes.Add(root);
                }

                SwapTree(swapLevel, root.left, currentLevel + 1);
                SwapTree(swapLevel, root.right, currentLevel + 1);
            }
        }

        private static void SwapNodesAtAllLevels()
        {
            foreach (var node in nodes)
            {
                var temp = node.left;
                node.left = node.right;
                node.right = temp;
            }
        }



        private static Node CreateTree(int nodes)
        {
            Node root = new Node();
            root.data = 1;
            Queue<Node> queue = new Queue<Node>();
            Node left, right, current;
            current = root;


            for (int i = 0; i < nodes; i++)
            {
  
                var input =
                    Console.ReadLine().ToString().Split(new char[] {' '}).Select(x => Convert.ToInt32(x)).ToList();
                if (input[0] != -1)
                {
                    left = new Node();
                    left.data = input[0];
                    current.left = left;
                    queue.Enqueue(left);
                }
                if (input[1] != -1)
                {
                    right = new Node();
                    right.data = input[1];
                    current.right = right;
                    queue.Enqueue(right);
                }
                if(queue.Count > 0)
                current = queue.Dequeue();

            }
            return root;
        }


        public class Node
        {
            public int data;
            public Node left;
            public Node right;
        }
    }
}
