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
    int findRangeSumBST(TreeNode* currentNode, int low, int high) {
        if(currentNode == nullptr) {
            return 0;
        }
        int currentValue = currentNode -> val;
        int rangeSum = 0;
        if(low <= currentValue && currentValue <= high) {
            rangeSum += currentValue;
        }
        if(low < currentValue) { // low >= currentValue --> X
            rangeSum += findRangeSumBST(currentNode -> left, low, high);
        }
        if(currentValue < high) { // currentValue >= high --> X
            rangeSum += findRangeSumBST(currentNode -> right, low, high);
        }

        return rangeSum;
    }
public:
    int rangeSumBST(TreeNode* root, int low, int high) {
        return findRangeSumBST(root, low, high);
    }
};
