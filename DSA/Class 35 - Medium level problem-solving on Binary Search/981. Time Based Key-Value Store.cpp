class TimeMap {
public:
    unordered_map<string, vector<pair<int, string>>> key_timeValue_map;
    TimeMap() {
        key_timeValue_map.clear();
    }
    
    void set(string key, string value, int timestamp) {
        key_timeValue_map[key].push_back({timestamp, value});
    }
    
    string get(string key, int timestamp) {
        if(!key_timeValue_map.count(key) || timestamp < key_timeValue_map[key][0].first) {
            return "";
        }
        int low = 0, high = key_timeValue_map[key].size() - 1;
        int index = key_timeValue_map[key].size();
        while(low <= high) {
            int mid = low + (high - low)/2;
            if(key_timeValue_map[key][mid].first > timestamp) {
                index = mid;
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        return index == 0 ? "" : key_timeValue_map[key][index - 1].second;
    }
};

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap* obj = new TimeMap();
 * obj->set(key,value,timestamp);
 * string param_2 = obj->get(key,timestamp);
 */
