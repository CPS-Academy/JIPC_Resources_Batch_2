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
    ListNode* mergeKLists(vector<ListNode*>& lists) {
        auto cmp = [](ListNode* l, ListNode* r) {
            return l->val > r->val;
        };
        priority_queue<ListNode*, vector<ListNode*>, decltype(cmp)> pq(cmp);

        for(auto headNode: lists) {
            if(headNode != nullptr) {
                pq.push(headNode);
            }
        }

        ListNode dummyHead(0);
        ListNode* currentNode = &dummyHead;
        while(!pq.empty()) {
            currentNode->next = pq.top();
            pq.pop();
            currentNode = currentNode->next;
            if(currentNode->next) {
                pq.push(currentNode->next);
            }
        }

        return dummyHead.next;
    }
};
