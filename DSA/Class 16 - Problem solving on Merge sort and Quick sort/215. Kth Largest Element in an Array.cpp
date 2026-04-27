class Solution {
private:
    int quickSelect(vector<int>& nums, int k) { // k = 5
        int pivot = nums[ rand() % nums.size() ];
        vector<int> greaterValues, smallerValues, pivotValues;

        for(auto& num: nums) {
            if(num > pivot) {
                greaterValues.push_back(num); // 3
            }
            else if(num < pivot) {
                smallerValues.push_back(num); // 2
            }
            else {
                pivotValues.push_back(num); // 1
            }
        }

        int greaterValuesLength = greaterValues.size();
        int smallerValuesLength = smallerValues.size();
        int pivotValuesLength = pivotValues.size();
        if(k <= greaterValuesLength) {
            return quickSelect(greaterValues, k);
        }
        if(greaterValuesLength + pivotValuesLength < k) {
            return quickSelect(smallerValues, k - greaterValuesLength - pivotValuesLength);
        }
        return pivot;
    }
public:
    int findKthLargest(vector<int>& nums, int k) {
        return quickSelect(nums, k);
    }
};
