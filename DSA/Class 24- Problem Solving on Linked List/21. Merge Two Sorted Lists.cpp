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
    ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) {
        auto first_pointer = list1;
        auto seceond_pointer = list2;
        ListNode* dummy_head = new ListNode(0, nullptr);
        auto current_node = dummy_head;
        while(first_pointer != nullptr && seceond_pointer != nullptr) {
            if(first_pointer -> val < seceond_pointer -> val) {
                current_node -> next = first_pointer;
                first_pointer = first_pointer -> next;
            }
            else {
                current_node -> next = seceond_pointer;
                seceond_pointer = seceond_pointer -> next;
            }
            current_node = current_node -> next;
        }

        if(first_pointer == nullptr) {
            current_node -> next = seceond_pointer;
        }
        else {
            current_node -> next = first_pointer;
        }

        return dummy_head -> next;
    }
};
