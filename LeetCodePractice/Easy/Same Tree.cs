using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null ^ q == null)
            {
                return false;
            }
            if (p == null && q == null)
            {
                return true;
            }
            if (p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


namespace LeetCode
{
    public static class BinaryTreeHelper
    {
        public static TreeNode? BuildTree(int?[] values)
        {
            if (values.Length == 0) return null;

            TreeNode? root = new TreeNode(values[0].GetValueOrDefault());
            Queue<TreeNode?> queue = new Queue<TreeNode?>();
            queue.Enqueue(root);

            int i = 1;
            while (i < values.Length)
            {
                TreeNode? current = queue.Dequeue();

                if (values[i] != null)
                {
                    current.left = new TreeNode(values[i].GetValueOrDefault());
                    queue.Enqueue(current.left);
                }
                i++;

                if (i < values.Length && values[i] != null)
                {
                    current.right = new TreeNode(values[i].GetValueOrDefault());
                    queue.Enqueue(current.right);
                }
                i++;
            }

            return root;
        }
    }
}