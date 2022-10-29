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
    private int result = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        GetMaxHeight(root);
        
        return result;
    }
    
    private int GetMaxHeight(TreeNode root)
    {
        if(root is null)
            return 0;
        
        var lHeight = GetMaxHeight(root.left);
        var rHeight = GetMaxHeight(root.right);
        
        result = Math.Max(result, lHeight + rHeight);
        
        return lHeight > rHeight 
            ? lHeight + 1 
            : rHeight + 1;
    }
}