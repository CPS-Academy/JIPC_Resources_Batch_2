class KthLargest {
private:
    multiset<int> minHeap; // K minHeap.top() -> 
    int k;
public:
    KthLargest(int k, vector<int>& nums) {
        this->k = k;
        for(auto& num: nums) {
            add(num);
        }
    }
    
    int add(int val) { // O(Log(K))
        minHeap.insert(val);
        if(minHeap.size() > this->k) {
            minHeap.erase(minHeap.begin());
        }
        return *minHeap.begin();
    }

    int remove(int val) { // O(Log(K))

    }

    /*
    k = 3
    [4, 5, 8, 2] k'th leargest value = 4
    [4, 5, 8, 2, 3] k'th leargest value = 4
    [4, 5, 8, 2, 3, 5] k'th leargest value = 5
    [4, 5, 8, 2, 3, 5, 10] k'th leargest value = 5
    [4, 5, 8, 2, 3, 5, 10, 9] k'th leargest value = 8
    */
};

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest* obj = new KthLargest(k, nums);
 * int param_1 = obj->add(val);
 */




class KthLargest {
private:
    priority_queue<int, vector<int>, greater<int>> minHeap; // K minHeap.top() -> 
    int k;
public:
    KthLargest(int k, vector<int>& nums) {
        this->k = k;
        for(auto& num: nums) {
            add(num);
        }
    }
    
    int add(int val) {
        minHeap.push(val);
        if(minHeap.size() > this->k) {
            minHeap.pop();
        }
        return minHeap.top();
    }

    /*
    k = 3
    [4, 5, 8, 2] k'th leargest value = 4
    [4, 5, 8, 2, 3] k'th leargest value = 4
    [4, 5, 8, 2, 3, 5] k'th leargest value = 5
    [4, 5, 8, 2, 3, 5, 10] k'th leargest value = 5
    [4, 5, 8, 2, 3, 5, 10, 9] k'th leargest value = 8
    */
};

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest* obj = new KthLargest(k, nums);
 * int param_1 = obj->add(val);
 */
