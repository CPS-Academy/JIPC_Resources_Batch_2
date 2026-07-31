class Solution {
private:
    int binarySearch(vector<int>& nums, int start, int finish, int target) {
        while(start <= finish) {
            int mid = start + (finish - start)/2;
            if(nums[mid] == target) {
                return mid;
            }
            if(nums[mid] < target) {
                start = mid + 1;
            }
            else {
                finish = mid - 1;
            }
        }
        return -1;
    }
public:
    int search(vector<int>& nums, int target) {
        int n = nums.size();
        int low = 0, high = n - 1, pivotPoint = nums.size();
        while(low <= high) {
            int mid = low + (high - low)/2;
            if(nums[mid] < nums[0]) {
                pivotPoint = mid;
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }

        cout << "pivotPoint: " << pivotPoint << '\n';

        if(nums[0] <= target) {
            return binarySearch(nums, 0, pivotPoint - 1, target);
        }
        return binarySearch(nums, pivotPoint, n - 1, target);
    }
};



class Solution {
public:
    int search(vector<int>& nums, int target) {
        int low = 0, high = nums.size() - 1;
        while(low <= high) {
            int mid = low + (high - low)/2;
            if(nums[mid] == target) {
                return mid;
            }
            else if(nums[low] <= nums[mid]) {
                if(nums[low] <= target && target <= nums[mid]) {
                    high = mid - 1;
                }
                else {
                    low = mid + 1;
                }
            }
            else {
                if(nums[mid] <= target && target <= nums[high]) {
                    low = mid + 1;
                }
                else {
                    high = mid - 1;
                }
            }
        }
        return -1;
    }
};











