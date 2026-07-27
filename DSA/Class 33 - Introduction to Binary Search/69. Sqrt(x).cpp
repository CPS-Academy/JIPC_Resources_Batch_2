class Solution {
public:
    int mySqrt(int x) {
        int low = 0, high = x;
        int squareRoot = high;
        while(low <= high) {
            int mid = low + (high - low)/2;
            if((long long)mid*mid <= x) {
                squareRoot = mid;
                low = mid + 1;
            }
            else {
                high = mid - 1;
            }
        }
        return squareRoot;
    }
};
