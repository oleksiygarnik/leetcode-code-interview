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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        var result = new List<int>();
        
        Traversal(root1, result);
        Traversal(root2, result);
        
        return result.OrderBy(x => x).ToList();
    }
    
    private void Traversal(TreeNode root, List<int> result)
    {
        if(root is null)
            return;
        
         var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while(stack.Count != 0)
        {
            var current = stack.Pop();
            result.Add(current.val);
            
            if(current.left != null)
                stack.Push(current.left);
            
            if(current.right != null)
                stack.Push(current.right);
        }
    }
}