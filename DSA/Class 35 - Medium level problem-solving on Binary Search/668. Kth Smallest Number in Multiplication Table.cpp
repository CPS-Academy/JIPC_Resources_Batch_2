class Solution {
public:
    int findKthNumber(int m, int n, int k) {
        int kth_smallest;
        int low = 1, high = m*n;
        while(low <= high) {
            int mid = low + (high - low)/2;
            int smallerCount = 0;
            for(int row = 1; row <= m; row++) {
                smallerCount += min(n, mid/row);
            }
            if(smallerCount >= k) {
                kth_smallest = mid;
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        return kth_smallest;
    }
};
