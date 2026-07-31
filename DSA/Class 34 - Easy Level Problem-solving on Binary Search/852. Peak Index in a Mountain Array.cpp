class Solution {
public:
    int peakIndexInMountainArray(vector<int>& nums) {
        int high = nums.size() - 2, low = 1;
        int ans = -1;
        while(low <= high) {
            int mid = low + (high - low)/2;
            if(nums[mid] > nums[mid-1] && nums[mid] > nums[mid+1])
            {
                ans = mid;
                break;
            }
            else if(nums[mid] > nums[mid-1] && nums[mid] < nums[mid+1])low = mid + 1;
            else high = mid - 1;
        }
        return ans;
    }
}; 
