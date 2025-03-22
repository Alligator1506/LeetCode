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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        if (root == null) return result;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                result.Add(current.val);
                stack.Push(current);
                current = current.left;
            }
            current = stack.Pop();
            current = current.right;
        }
        return result;
    }
}