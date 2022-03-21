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
        
        var left = GetHeight(root.left);
        var right = GetHeight(root.right);
        
        return Math.Abs(left - right) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
    
    private int GetHeight(TreeNode root)
    {
        if(root is null)
            return 0;
        
        var left = GetHeight(root.left);
        var right = GetHeight(root.right);
        
        if(left > right)
            return left + 1;
        else
            return right + 1;
    }
}