class LRUCache {
private:
    list<int> cache;
    unordered_map<int, list<int>::iterator> addressOf;
    unordered_map<int, int> key_value;
    int capacity;
public:
    LRUCache(int capacity) {
        cache.clear();
        this->capacity = capacity;
    }
    
    int get(int key) {
        if(!key_value.count(key)) return -1;
        cache.erase(addressOf[key]);
        cache.push_back(key);
        addressOf[key] = --cache.end();
        return key_value[key];
    }
    
    void put(int key, int value) {
        if(!key_value.count(key) && key_value.size() == capacity) {
            addressOf.erase(cache.front());
            key_value.erase(cache.front());
            cache.pop_front();
        }
        if(key_value.count(key)) {
            cache.erase(addressOf[key]);
            addressOf.erase(key);
        }
        cache.push_back(key);
        addressOf[key] = --cache.end();
        key_value[key] = value;
    }
};

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache* obj = new LRUCache(capacity);
 * int param_1 = obj->get(key);
 * obj->put(key,value);
 */
