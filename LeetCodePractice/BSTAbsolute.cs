using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class TreeNode
    {
        public int val; //stores the value of the node
        public TreeNode left; // store references
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) // constructor
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class BST
    {
        public TreeNode prevNode = null;
        public int minDiff = int.MaxValue;
        public int GetMinimumDifference(TreeNode root)
        {
            InOrderTraversal(root);
            return minDiff;

        }
        public void InOrderTraversal(TreeNode node)
        { 
        if (node == null) return;
        InOrderTraversal(node.left);
            if (prevNode != null)
            {
                int dif = node.val - prevNode.val;
                minDiff = Math.Min(dif, minDiff);
            }
            prevNode = node; 
            
        InOrderTraversal(node.right);
        }

       

    }
}


    //in-order traversal of the BST, visiting nodes in ascending order
    //compare each node with the previous node to find the absolute difference
    //Continuosuly updating the minimum difference to find the smallest difference 
    