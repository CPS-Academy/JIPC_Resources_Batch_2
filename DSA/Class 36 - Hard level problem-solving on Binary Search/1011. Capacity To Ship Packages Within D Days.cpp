class Solution {
private:
    bool isDeliverableWithInDays(int capacity, vector<int>& weights, int remainingDays) { // T.C: O(|W|)
        int remainingCapacity = capacity;
        for(auto& weight: weights) {
            if(remainingCapacity >= weight) {
                remainingCapacity -= weight;
                continue;
            }
            remainingCapacity = capacity - weight;
            remainingDays--;
        }
        return remainingDays > 0;
    }
    int binary_search_on_capacity(int low, int high, vector<int>& weights, int days) { // T.C: O(|W|*log(C))
        int minTruckCapacity = high;
        while(low <= high) {
            int mid = low + (high - low)/2;
            if(isDeliverableWithInDays(mid, weights, days)) { // delivering all the weights to warehouse with the truck capacity of 'mid' is possible within 'days'
                minTruckCapacity = mid;
                high = mid - 1;
            }
            else{
                low = mid + 1;
            }
        }
        return minTruckCapacity;
    }
public:
    int shipWithinDays(vector<int>& weights, int days) { // O(|W|*log(C))
        int minCapacity = 0, maxCapacity = 0;
        for(auto& weight: weights) { // T.C: O(|W|)
            minCapacity = max(minCapacity, weight);
            maxCapacity += weight;
        }
        return binary_search_on_capacity(minCapacity, maxCapacity, weights, days); // O(|W|*log(C))
    }
};
