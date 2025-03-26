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
    // public int CountNodes(TreeNode root)
    // {
    //     if (root == null) return 0;
    //     return 1 + CountNodes(root.left) + CountNodes(root.right);
    // }
    public int CountNodes(TreeNode root)
    {
        if (root == null) return 0;
        int leftHeight = GetHeight(root.left);
        int rightHeight = GetHeight(root.right);
        if (leftHeight == rightHeight)
        {
            return (1 << leftHeight) + CountNodes(root.right);
        }
        else
        {
            return (1 << rightHeight) + CountNodes(root.left);
        }
    }

    public int GetHeight(TreeNode root)
    {
        if (root == null) return 0;
        return 1 + GetHeight(root.left);
    }
}