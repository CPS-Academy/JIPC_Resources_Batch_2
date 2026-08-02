class Solution {
private:
    static bool cmp(vector<int>& a, vector<int>& b) {
        if(a[0] == b[0]) {
            return a[1] > b[1];
        }
        return a[0] < b[0];
    }
public:
    int maxEnvelopes(vector<vector<int>>& envelopes) {
        int n = envelopes.size();
        vector<int> heightValues(n + 1, INT_MAX);
        heightValues[0] = 0;

        sort(envelopes.begin(), envelopes.end(), cmp);
        int maxLength = 1;
        for(auto& envelop: envelopes) {
            int index = lower_bound(heightValues.begin(), heightValues.end(), envelop[1]) - heightValues.begin();
            maxLength = max(maxLength, index);
            heightValues[index] = envelop[1];
        }
        return maxLength;
    }
};
