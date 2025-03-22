/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        if (root == null) return result;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        TreeNode last = null;
        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            current = stack.Peek();
            if (current.right == null || current.right == last)
            {
                result.Add(current.val);
                last = stack.Pop();
                current = null;
            }
            else
            {
                current = current.right;
            }
        }
        return result;
    }
}