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
    bool checkValidity(TreeNode* currentNode, long long L, long long R) {
        if(currentNode == nullptr) {
            return true;
        }
        int currentValue = currentNode -> val;
        bool isCurrentNodeValid = (L <= currentValue && currentValue <= R);
        bool isLeftSubtreeValue = checkValidity(currentNode -> left, L, currentValue - 1LL);
        bool isRightSubtreeValue = checkValidity(currentNode -> right, currentValue + 1LL, R);
        return isCurrentNodeValid && isLeftSubtreeValue && isRightSubtreeValue;
        // (validate current value, validate leftsubtree, validate right subtree)
    }
public:
    bool isValidBST(TreeNode* root) {
        return checkValidity(root, LONG_LONG_MIN, LONG_LONG_MAX);
    }
};
