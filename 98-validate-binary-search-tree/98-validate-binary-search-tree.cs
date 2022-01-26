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
    public bool IsValidBST(TreeNode root) {
        var stack = new Stack<(TreeNode, long, long)>();
        stack.Push((root, long.MinValue, long.MaxValue));
        
        while(stack.Count != 0)
        {
            var item = stack.Pop();
            var current = item.Item1;
            var min = item.Item2;
            var max = item.Item3;
            
            if(current.val <= min || current.val >= max)
                return false;
            
            if(current.left != null)
                stack.Push((current.left, min, current.val));
            
            if(current.right != null)
                stack.Push((current.right, current.val, max));
        }
        
        return true;
    }
}