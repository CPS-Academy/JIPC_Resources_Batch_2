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
        auto cmp = [](ListNode* L, ListNode* R) {
            return L->val > R->val;
        };
        priority_queue<ListNode*, vector<ListNode*>, decltype(cmp)> min_heap;

        for(auto& node: lists) {
            if(node != nullptr) {
                min_heap.push(node);
            }
        }

        ListNode* dummy_head = new ListNode(0, nullptr);
        auto current_node = dummy_head;
        while(!min_heap.empty()) {
            current_node -> next = min_heap.top();
            current_node = current_node -> next;
            min_heap.pop();
            if(current_node -> next) {
                min_heap.push(current_node -> next);
            }
        }

        return dummy_head -> next;
    }
};
