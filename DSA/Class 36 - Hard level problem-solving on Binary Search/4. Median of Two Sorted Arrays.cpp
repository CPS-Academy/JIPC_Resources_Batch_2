class Solution {
public:
    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2) {
        int nums1Size = nums1.size();
        int nums2Size = nums2.size();
        int total = nums1Size + nums2Size;
        int half = total/2;

        if(nums1Size > nums2Size){
            swap(nums1, nums2);
            swap(nums1Size, nums2Size);
        }

        int lo = -1, hi = nums1Size - 1;
        while(true){
            int i = lo + (hi - lo)/2; // nums1
            int j = half - i - 2; // nums2

            cout << lo << ' ' << hi << '\n';

            int nums1Left = (i >= 0) ? nums1[i] : INT_MIN;
            int nums1Right = (i + 1 < nums1Size) ? nums1[i + 1] : INT_MAX;

            int nums2Left = (j >= 0) ? nums2[j] : INT_MIN;
            int nums2Right = (j + 1 < nums2Size) ? nums2[j + 1] : INT_MAX;

            if(nums1Left <= nums2Right && nums2Left <= nums1Right){
                return (total&1) ? min(nums1Right, nums2Right) : 
                (max(nums1Left, nums2Left) + min(nums1Right, nums2Right))/2.0;
            }
            else if(nums1Left > nums2Right){
                hi = i - 1;
            }
            else lo = i + 1;
        }
    }
};
