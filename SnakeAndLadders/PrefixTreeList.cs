using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class PrefixTreeList
    {
        class TreeNode
        {
            public char data;
            public bool isleaf;
            public List<TreeNode> children = new List<TreeNode>();

            public TreeNode(char d)
            {
                data = d;
            }

            public TreeNode()
            {

            }
        }

        TreeNode root = new TreeNode();
        public PrefixTreeList()
        {

        }

        public void Add(string value)
        {
            TreeNode node = root;
            foreach (char c in value)
            {
                if (node.children.Any(node1 => node1.data == c))
                {
                    node = node.children.Find(node1 => node1.data == c);
                }
                else
                {
                    var temp = new TreeNode(c);
                    node.children.Add(temp);
                    node = temp;
                }
            }
            if (node != root)
                node.isleaf = true;
        }

        public bool Contains(string value)
        {
            TreeNode node = root;
            foreach (var c in value)
            {
                if (node.children.Any(node1 => node1.data == c))
                {
                    node = node.children.Find(node1 => node1.data == c);
                }
                else
                {
                    return false;
                }
            }
            if (node.isleaf)
                return true;
            return false;
        }
    }
}
