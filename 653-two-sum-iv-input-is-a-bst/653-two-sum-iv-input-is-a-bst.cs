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
    public bool FindTarget(TreeNode root, int k) {
         var stack = new Stack<TreeNode>();
        stack.Push(root);
        
         while(stack.Count != 0)
        {
            var current = stack.Pop();
             if(IsExist(root, k - current.val, current))
                return true;
           
            if(current.left != null)
                stack.Push(current.left);
            if(current.right != null)
                stack.Push(current.right);
        }
        
        return false;
    }
    
    public bool IsExist(TreeNode root, int target, TreeNode curr)
    {
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while(stack.Count != 0)
        {
            var current = stack.Pop();
            
            if(current.val == target && curr != current)
            {
            Console.WriteLine("leha");
                return true;
            }
            
            if(current.left != null)
                stack.Push(current.left);
            if(current.right != null)
                stack.Push(current.right);
        }
        
        return false;
    }
}