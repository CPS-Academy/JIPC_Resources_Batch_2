/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* left;
    Node* right;
    Node* parent;
};
*/

class Solution {
public:
    Node* inorderSuccessor(Node* node) {
        if(node->right != nullptr) { // has a right subtree, where successor exists
            auto successorNode = node->right; // right move
            while(successorNode->left != nullptr) { // series of left moves
                successorNode = successorNode->left;
            }
            return successorNode;
        }
        // this has no right nodes
        auto successorNode = node;
        while(successorNode->parent && successorNode->parent->val < successorNode->val) { // series of right parent moves
            successorNode = successorNode->parent;
        }
        return successorNode->parent;
    }
};
