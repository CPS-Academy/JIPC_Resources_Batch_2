class MyLinkedList {
private:
    class Node {
        public:
        int value;
            Node* nextPtr;
            Node(int _value, Node* _nextPtr) {
                value = _value;
                nextPtr = _nextPtr;
            }
    };
    int linkedListSize = 0;
    Node* dummyHead;
public:
    MyLinkedList() {
        dummyHead = new Node(0, nullptr);
    }
    
    int get(int index) {
        if(index >= linkedListSize) {
            return -1;
        }
        index++;
        auto currentNode = dummyHead;
        while(index--) {
            currentNode = currentNode -> nextPtr;
        }
        return currentNode -> value;
    }
    
    void addAtHead(int val) {
        addAtIndex(0, val);
    }
    
    void addAtTail(int val) {
        addAtIndex(linkedListSize, val);
    }
    
    void addAtIndex(int index, int val) {
        if(index > linkedListSize) {
            return;
        }
        auto currentNode = dummyHead;
        while(index--) {
            currentNode = currentNode -> nextPtr;
        }
        Node* newNode = new Node(val, currentNode -> nextPtr);
        currentNode -> nextPtr = newNode;
        linkedListSize++;
    }
    
    void deleteAtIndex(int index) {
        if(index >= linkedListSize) {
            return;
        }
        auto currentNode = dummyHead;
        while(index--) {
            currentNode = currentNode -> nextPtr;
        }
        auto deleteNode = currentNode -> nextPtr;
        currentNode -> nextPtr = currentNode -> nextPtr -> nextPtr;
        linkedListSize--;
        delete deleteNode;
    }
};

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList* obj = new MyLinkedList();
 * int param_1 = obj->get(index);
 * obj->addAtHead(val);
 * obj->addAtTail(val);
 * obj->addAtIndex(index,val);
 * obj->deleteAtIndex(index);
 */
