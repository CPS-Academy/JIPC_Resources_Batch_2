#include <bits/stdc++.h>
using namespace std;

class Solution {
public:
    vector<int> TwoSum(vector<int>& nums, int target) {
        for(int i = 0; i < nums.size(); i++) {
            for(int j = i + 1; j < nums.size(); j++) {
                if(nums[i] + nums[j] == target) {
                    return {i, j};
                }
            }
        }
        return {-1, -1};
    }
};

int main() {
    Solution sol;

    vector<int> nums = {2, 7, 11, 15};
    int target = 9;

    vector<int> result = sol.TwoSum(nums, target);

    cout << "Indices: " << result[0] << ", " << result[1] << endl;
}