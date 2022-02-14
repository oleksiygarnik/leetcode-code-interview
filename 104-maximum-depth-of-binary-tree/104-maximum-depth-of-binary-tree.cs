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
    public int MaxDepth(TreeNode root) {
        if(root is null)
            return 0;
        
        var lDepth = MaxDepth(root.left);
        var rDepth = MaxDepth(root.right);
        
        if(lDepth > rDepth)
            return lDepth + 1;
        else
            return rDepth + 1;
    }
}