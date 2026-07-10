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
    class TreeNodeMetaData {
    public:
        bool isSubtreeBST;
        int subtreeSum;
        int minLimit;
        int maxLimit;
        TreeNodeMetaData() {
            isSubtreeBST = true;
            subtreeSum = 0;
            minLimit = INT_MAX; // For a null node the limits should be invalid
            maxLimit = INT_MIN; // For a null node the limits should be invalid
        }
    };
    TreeNodeMetaData* findMaxSumBST(TreeNode* currentNode, int& maxSumBST) {
        if(currentNode == nullptr) {
            return new TreeNodeMetaData();
        }
        TreeNodeMetaData* leftSubtreeMetaData = findMaxSumBST(currentNode->left, maxSumBST);
        TreeNodeMetaData* rightSubtreeMetaData = findMaxSumBST(currentNode->right, maxSumBST);

        if(leftSubtreeMetaData->isSubtreeBST && rightSubtreeMetaData->isSubtreeBST 
            && leftSubtreeMetaData->maxLimit < currentNode->val && currentNode->val < rightSubtreeMetaData->minLimit) { // if currentNode is a bst
                TreeNodeMetaData* currentSubtreeMetadata = new TreeNodeMetaData();
                currentSubtreeMetadata->subtreeSum = currentNode->val + leftSubtreeMetaData->subtreeSum + rightSubtreeMetaData->subtreeSum;
                currentSubtreeMetadata->minLimit = min(leftSubtreeMetaData->minLimit, currentNode->val);
                currentSubtreeMetadata->maxLimit = max(rightSubtreeMetaData->maxLimit, currentNode->val);
                maxSumBST = max(maxSumBST, currentSubtreeMetadata->subtreeSum);
                return currentSubtreeMetadata;
        }
        // if currentNode is not a bst
        TreeNodeMetaData* currentSubtreeMetadata = new TreeNodeMetaData();
        currentSubtreeMetadata->isSubtreeBST = false;
        return currentSubtreeMetadata;
    }
public:
    int maxSumBST(TreeNode* root) {
        int maxSumBST = 0;
        findMaxSumBST(root, maxSumBST);
        return maxSumBST;
    }
};
