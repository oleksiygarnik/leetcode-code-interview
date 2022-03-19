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
    public int SumOfLeftLeaves(TreeNode root) {
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        int result = 0;
        while(stack.Count != 0)
        {
            var current = stack.Pop();
            
            if(current.left != null)
            {
                stack.Push(current.left);
                
                if(current.left.left == null && current.left.right == null)
                    result += current.left.val;
            }
            
            if(current.right != null)
                stack.Push(current.right);            
        }
        
        return result;
    }
}