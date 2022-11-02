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
    
    private List<int> _result = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) 
    {
        Traversal(root);
        
        return _result;
    }
    
    void Traversal(TreeNode root)
    {
        if(root != null)
        {
        Traversal(root.left);
        
        _result.Add(root.val);
        
        Traversal(root.right);
        }
    }
}
