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
    public bool IsBalanced(TreeNode root) 
    {
        if(root is null)
            return true;
        
        var left = Inner(root.left);
        var right = Inner(root.right);
        
        return Math.Abs(left - right) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
    
    private int Inner(TreeNode root)
    {
        if(root == null)
            return 0;
        
        return 1 + Math.Max(Inner(root.left), Inner(root.right));
        
    }
}