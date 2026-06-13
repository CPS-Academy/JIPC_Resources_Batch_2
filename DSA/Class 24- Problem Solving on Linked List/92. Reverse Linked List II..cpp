/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* reverseBetween(ListNode* head, int left, int right) {
        ListNode* dummyHead = new ListNode(0, head);
        auto currentNode = dummyHead;
        ListNode* startNode = nullptr;
        ListNode* endNode = nullptr;
        ListNode* breforeStartNode = nullptr;
        ListNode* nextEndNode = nullptr;
        ListNode* prevNode = nullptr;
        while(currentNode) {
            if(left == 0) {
                breforeStartNode = prevNode;
                startNode = currentNode;
            }
            if(right == 0) {
                endNode = currentNode;
                nextEndNode = endNode -> next;
                break;
            }
            prevNode = currentNode;
            currentNode = currentNode -> next;
            left--;
            right--;
        }

        if(startNode == endNode) {
            return dummyHead -> next;
        }

        prevNode = startNode;
        currentNode = startNode -> next;
        while(currentNode != nextEndNode) {
            cout << currentNode -> val << '\n';
            auto nextNode = currentNode -> next;
            currentNode -> next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
        }

        startNode -> next = nextEndNode;
        if(breforeStartNode != nullptr) {
            breforeStartNode -> next = endNode;
        }

        return dummyHead -> next;
    }
};
