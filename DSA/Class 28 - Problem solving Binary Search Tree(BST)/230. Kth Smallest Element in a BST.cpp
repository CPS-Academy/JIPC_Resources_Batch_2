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
    int kth_smallest_number;
    int K;
    int rank;
    void inorderTraverse(TreeNode* currentNode) {
        if(currentNode == nullptr || kth_smallest_number != -1) {
            return;
        }
        inorderTraverse(currentNode->left);
        if(rank == K) {
            kth_smallest_number = currentNode->val;
        }
        rank++;
        inorderTraverse(currentNode->right);
    }
public:
    int kthSmallest(TreeNode* root, int k) {
        this->K = k;
        rank = 1;
        kth_smallest_number = -1;
        inorderTraverse(root);
        return kth_smallest_number;
    }
};
