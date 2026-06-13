/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* left;
    Node* right;
    Node* next;

    Node() : val(0), left(NULL), right(NULL), next(NULL) {}

    Node(int _val) : val(_val), left(NULL), right(NULL), next(NULL) {}

    Node(int _val, Node* _left, Node* _right, Node* _next)
        : val(_val), left(_left), right(_right), next(_next) {}
};
*/

class Solution {
    vector<Node*> depthwiseNodeList;
    void DFS(Node* currentNode, int depth) {
        if(currentNode == nullptr) {
            return;
        }
        
        if(depthwiseNodeList.size() <= depth) {
            depthwiseNodeList.push_back(currentNode);
        }
        else{
            depthwiseNodeList[depth] -> next = currentNode;
            depthwiseNodeList[depth] = currentNode;
        }

        DFS(currentNode -> left, depth + 1);
        DFS(currentNode -> right, depth + 1);
    }
public:
    Node* connect(Node* root) {
        DFS(root, 0);
        return root;
    }
};
