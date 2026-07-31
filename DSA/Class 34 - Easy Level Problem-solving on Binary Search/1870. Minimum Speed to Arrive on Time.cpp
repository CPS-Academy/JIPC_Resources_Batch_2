class Solution {
public:
    int minSpeedOnTime(vector<int>& dist, double hour) {
        int low = 1, high = INT_MAX/2, minSpeed = -1;
        while(low <= high) {
            int mid = low + (high - low)/2; // current speed of all trains
            double passedTime = 0.0;
            for(int i = 0; i < dist.size(); i++) {
                int distance = dist[i];
                if(i + 1 == dist.size()) {
                    passedTime += 1.00 * distance/mid;
                }
                else {
                    passedTime += (distance + mid - 1) / mid;
                }
            }
            if(passedTime <= hour) {
                minSpeed = mid;
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        return minSpeed;
    }
};
