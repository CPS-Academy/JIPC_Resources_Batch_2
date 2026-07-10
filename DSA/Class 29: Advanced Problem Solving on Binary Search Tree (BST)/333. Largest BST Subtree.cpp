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
        int subtreeNodeCount;
        int minLimit;
        int maxLimit;
        TreeNodeMetaData() {
            isSubtreeBST = true;
            subtreeNodeCount = 0;
            minLimit = INT_MAX; // For a null node the limits should be invalid
            maxLimit = INT_MIN; // For a null node the limits should be invalid
        }
    };
    TreeNodeMetaData* findLargestBSTSubtree(TreeNode* currentNode, int& largestBST) {
        if(currentNode == nullptr) {
            return new TreeNodeMetaData();
        }
        TreeNodeMetaData* leftSubtreeMetaData = findLargestBSTSubtree(currentNode->left, largestBST);
        TreeNodeMetaData* rightSubtreeMetaData = findLargestBSTSubtree(currentNode->right, largestBST);

        if(leftSubtreeMetaData->isSubtreeBST && rightSubtreeMetaData->isSubtreeBST 
            && leftSubtreeMetaData->maxLimit < currentNode->val && currentNode->val < rightSubtreeMetaData->minLimit) { // if currentNode is a bst
                TreeNodeMetaData* currentSubtreeMetadata = new TreeNodeMetaData();
                currentSubtreeMetadata->subtreeNodeCount = 1 + leftSubtreeMetaData->subtreeNodeCount + rightSubtreeMetaData->subtreeNodeCount;
                currentSubtreeMetadata->minLimit = min(leftSubtreeMetaData->minLimit, currentNode->val);
                currentSubtreeMetadata->maxLimit = max(rightSubtreeMetaData->maxLimit, currentNode->val);
                largestBST = max(largestBST, currentSubtreeMetadata->subtreeNodeCount);
                return currentSubtreeMetadata;
        }
        // if currentNode is not a bst
        TreeNodeMetaData* currentSubtreeMetadata = new TreeNodeMetaData();
        currentSubtreeMetadata->isSubtreeBST = false;
        return currentSubtreeMetadata;
    }
public:
    int largestBSTSubtree(TreeNode* root) {
        int largestBST = 0;
        findLargestBSTSubtree(root, largestBST);
        return largestBST;
    }
};
