class Solution {
public:
    int countNegatives(vector<vector<int>>& grid) {
        int colSize = grid[0].size();
        int negativeNumberCount = 0;
        for(int row = 0; row < grid.size(); row++) {
            int index = upper_bound(grid[row].begin(), grid[row].end(), 0, greater<int>()) - grid[row].begin();
            negativeNumberCount += colSize - index;
        }
        return negativeNumberCount;
    }
};
