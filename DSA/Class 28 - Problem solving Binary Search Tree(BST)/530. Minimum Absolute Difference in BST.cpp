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
    int minDifference;
    TreeNode* prevNode;
    void inorderTraverse(TreeNode* currentNode) {
        if(currentNode == nullptr) {
            return;
        }
        inorderTraverse(currentNode -> left);
        if(prevNode != nullptr) {
            // cout << currentNode-> val << " " << prevNode->val << '\n';
            minDifference = min(minDifference, currentNode->val - prevNode->val);
        }
        prevNode = currentNode;
        inorderTraverse(currentNode -> right);
    }
public:
    int getMinimumDifference(TreeNode* root) {
        minDifference = INT_MAX;
        inorderTraverse(root);
        return minDifference;
    }
};
