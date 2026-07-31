class Solution {
private:
    const static int INVALID = -1;
    bool isGreaterThanLeft(int mid, vector<int>& nums) {
        return (mid == 0 || nums[mid - 1] < nums[mid]);
    }
    bool isGreaterThanRight(int mid, vector<int>& nums) {
        return (mid + 1 == nums.size() || nums[mid] > nums[mid + 1]);
    }
public:
    int findPeakElement(vector<int>& nums) {
        int lo = 0, hi = nums.size() - 1;
        while(lo <= hi){
            int mid = lo + (hi - lo)/2;
            if(isGreaterThanLeft(mid, nums) && isGreaterThanRight(mid, nums)) return mid;
            else if(isGreaterThanLeft(mid, nums)) lo = mid + 1;
            else hi = mid - 1;
        }
        return INVALID;
    }
};
