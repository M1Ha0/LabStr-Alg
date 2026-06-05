using System;
using System.Collections.Generic;
using System.Text;

namespace LabTree
{
    public class TreeNode
    {
        public int Value { get; set; }
        public List<TreeNode> Children { get; set; }
        public TreeNode(int value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }
    }
}
