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
    public TreeNode InvertTree(TreeNode root) {
        return BinaryTree(root);
    }
    
    private TreeNode BinaryTree(TreeNode root)
    {
        if(root is null)
            return null;
        
        var temp = root.left;
        root.left = root.right;
        root.right = temp;
        
        BinaryTree(root.left);
        BinaryTree(root.right);
        
        return root;
    }
}