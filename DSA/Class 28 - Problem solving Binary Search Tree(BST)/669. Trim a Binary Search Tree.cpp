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
public:
    TreeNode* trimBST(TreeNode* currentNode, int low, int high) {
        if(currentNode == nullptr) {
            return nullptr;
        }
        int currentValue = currentNode -> val;
        if(low <= currentValue && currentValue <= high) {
            currentNode -> left = trimBST(currentNode->left, low, high);
            currentNode -> right = trimBST(currentNode->right, low, high);
            return currentNode;
        }
        else if(currentValue < low) {
            return trimBST(currentNode->right, low, high);
        }
        else {
            return trimBST(currentNode->left, low, high);
        }
    }
};
