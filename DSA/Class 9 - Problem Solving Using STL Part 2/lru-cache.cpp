class LRUCache {
private:
    const static int INVALID = -1;

    unordered_map<int, int> key_value;
    unordered_map<int, list<int>::iterator> addressOf;
    list<int> lruCache;
    int maxCapacity;

    void evict() {
        key_value.erase(lruCache.front());
        addressOf.erase(lruCache.front());
        lruCache.pop_front();
    }

public:
    LRUCache(int capacity) {
        maxCapacity = capacity;
    }
    
    int get(int key) {
        if(!key_value.count(key)) {
            return INVALID;
        }
        lruCache.erase(addressOf[key]);
        lruCache.push_back(key);
        addressOf[key] = (--lruCache.end());
        return key_value[key];
    }
    
    void put(int key, int value) {
        if(maxCapacity == lruCache.size() && !key_value.count(key)) {
            evict();
        }
        if(key_value.count(key)) {
            lruCache.erase(addressOf[key]);
        }
        lruCache.push_back(key);
        addressOf[key] = --lruCache.end();
        key_value[key] = value;
    }
};

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache* obj = new LRUCache(capacity);
 * int param_1 = obj->get(key);
 * obj->put(key,value);
 */
