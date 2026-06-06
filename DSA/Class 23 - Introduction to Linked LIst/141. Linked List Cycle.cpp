/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    bool hasCycle(ListNode *head) {
        auto hare = head;
        auto tortoise = head;
        while(hare != nullptr) {
            tortoise = tortoise -> next;
            if(hare -> next == nullptr) {
                return false;
            }
            hare = hare -> next -> next;
            if(hare == tortoise) {
                return true;
            }
        }
        return false;
    }
};
