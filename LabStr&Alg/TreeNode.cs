using GraphProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphProject
{
    public class TreeNode
    {
        public string Value { get; set; }
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(string value)
        {
            Value = value;
        }
    }
}
