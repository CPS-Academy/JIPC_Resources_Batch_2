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
    int K;
    bool isTwoSumExists;
    unordered_set<int> nodeValues;
    void inorderTraverse(TreeNode* currentNode) {
        if(currentNode == nullptr) {
            return;
        }
        inorderTraverse(currentNode->left);
        if(nodeValues.count(K - currentNode->val)) {
            isTwoSumExists = true;
        }
        nodeValues.insert(currentNode->val);
        inorderTraverse(currentNode->right);
    }
public:
    bool findTarget(TreeNode* root, int k) {
        this->K = k;
        isTwoSumExists = false;
        inorderTraverse(root);
        return isTwoSumExists;
    }
};
