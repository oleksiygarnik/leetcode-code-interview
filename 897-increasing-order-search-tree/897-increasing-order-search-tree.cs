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
    public TreeNode IncreasingBST(TreeNode root) {
        var current = new TreeNode();
        var result = current;
        foreach(var val in InOrderTraversal(root))
        {
            current.right = new TreeNode(val);
            current = current.right;
        }
        
        return result.right;
    }
    
    public IEnumerable<int> InOrderTraversal(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        
        while(stack.Count > 0 || root != null)
        {
            while(root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            
            root = stack.Pop();
            yield return root.val;
            
            root = root.right;
        }
    }
}