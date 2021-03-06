/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root==null){
            return root;
        }
        else if(root.val>val){
            return SearchBST(root.left,val);
        }
        else if(root.val<val){
            return SearchBST(root.right,val);
        }
        else{
            return root;
        }
    }
}
