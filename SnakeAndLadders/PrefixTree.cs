using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class PrefixTreeDict
    {
        class TreeNode
        {
            public char data;
            public bool isleaf;
            public Dictionary<char,TreeNode> children = new Dictionary<char, TreeNode>();

            public TreeNode(char d)
            {
                data = d;
            }

            public TreeNode()
            {
                
            }
        }

        TreeNode root = new TreeNode();
        public PrefixTreeDict()
        {
            
        }

        public void Add(string value)
        {
            TreeNode node = root;
            foreach (char c in value)
            {
                if (node.children.ContainsKey(c))
                {
                    node = node.children[c];
                }
                else
                {
                    var temp = new TreeNode(c);
                    node.children.Add(c, temp);
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
                if (node.children.ContainsKey(c))
                {
                    node = node.children[c];
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
