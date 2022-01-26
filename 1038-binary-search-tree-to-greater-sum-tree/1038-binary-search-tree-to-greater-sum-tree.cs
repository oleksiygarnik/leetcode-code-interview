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
    public TreeNode BstToGst(TreeNode root) 
    {
        int sum = 0;
        Binary(root, ref sum);
        return root;
    }
    
    private void Binary(TreeNode root, ref int sum)
    {
       if(root.right != null)
           Binary(root.right, ref sum);
        
        sum += root.val;
        root.val = sum;
        
      if(root.left != null)
          Binary(root.left, ref sum);
    }
    
    private int GetSum(TreeNode root)
    {
        int result = 0;
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while(stack.Count != 0)
        {
            var current = stack.Pop();
            result+=current.val;
            
            if(current.left != null)
                stack.Push(current.left);
            if(current.right != null)
                stack.Push(current.right);
        }
        
        return result;
    }
}