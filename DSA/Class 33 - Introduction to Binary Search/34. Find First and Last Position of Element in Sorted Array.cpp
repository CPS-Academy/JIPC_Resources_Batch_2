class Solution {
private:
    int findLowerbound(vector<int>& nums, int target) {
        int low = 0, high = nums.size() - 1;
        int upperbound = nums.size();
        while(low <= high) {
            int mid = low + (high - low)/2;
            if(target <= nums[mid]) {
                upperbound = mid;
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        return upperbound;
    }
    int findUpperbound(vector<int>& nums, int target) {
        int low = 0, high = nums.size() - 1;
        int lowerbound = nums.size();
        while(low <= high) {
            int mid = low + (high - low)/2;
            if(target < nums[mid]) {
                lowerbound = mid;
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        return lowerbound;
    }
public:
    vector<int> searchRange(vector<int>& nums, int target) {
        int lowerbound = lower_bound(nums.begin(), nums.end(), target) - nums.begin();
        int upperbound = upper_bound(nums.begin(), nums.end(), target) - nums.begin();
        if(lowerbound == upperbound) {
            return {-1, -1};
        }
        return {lowerbound, upperbound - 1};
    }
};
