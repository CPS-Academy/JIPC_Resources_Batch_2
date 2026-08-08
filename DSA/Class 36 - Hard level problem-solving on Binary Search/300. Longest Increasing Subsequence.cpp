class Solution {
private:
    int find_lis_ending_at(int value, vector<int>& LIS) { // T.C: O(logN)
        int low = 0, high = LIS.size(), index = 0;
        while(low <= high) {
            int mid = low + (high - low)/2;
            if(value <= LIS[mid]) {
                index = mid;
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        LIS[index] = value;
        return index;
    }
public:
    int lengthOfLIS(vector<int>& nums) { // T.C: O(N*Nlog)
        vector<int> LIS(nums.size() + 1, INT_MAX); // LIS[i] = val; -> LIS is val ending at index i.
        LIS[0] = INT_MIN;
        int maxLIS = 0;
        for(int i = 0; i < nums.size(); i++) {
            maxLIS = max(maxLIS, find_lis_ending_at(nums[i], LIS));
        }
        return maxLIS;
    }
};


class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        vector<int> LIS(nums.size(), 1); // LIS[i] = val; -> LIS is val ending at index i.
        int maxLIS = 0;
        for(int i = 0; i < nums.size(); i++) {
            LIS[i] = 1;
            for(int j = 0; j < i; j++) {
                if(nums[j] < nums[i]) {
                    LIS[i] = max(LIS[i], 1 + LIS[j]);
                }
            }
            maxLIS = max(maxLIS, LIS[i]);
        }
        return maxLIS;
    }
};
