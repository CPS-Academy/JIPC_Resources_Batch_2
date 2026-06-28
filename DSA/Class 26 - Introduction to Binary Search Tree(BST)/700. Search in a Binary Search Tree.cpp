/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
private:
    TreeNode* searchTheValueInBST(TreeNode* currentNode, int val) { // T.C: O(MAX_DEPTH)
        if(currentNode == nullptr || currentNode -> val == val) {
            return currentNode;
        }
        if(val < currentNode -> val) {
            return searchTheValueInBST(currentNode -> left, val);
        }
        return searchTheValueInBST(currentNode -> right, val);
    }
public:
    TreeNode* searchBST(TreeNode* root, int val) {
        return searchTheValueInBST(root, val);
    }
};
