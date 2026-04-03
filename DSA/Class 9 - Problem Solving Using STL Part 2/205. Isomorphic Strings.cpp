class Solution {
public:
    bool isIsomorphic(string s, string t) {
        unordered_map<char, char> mappingFromS, mappingFromT;
        int stringLength = s.size();
        for(int i = 0; i < stringLength; i++) {
            mappingFromS[ s[i] ] = t[i];
            mappingFromT[ t[i] ] = s[i];
        }

        for(int i = 0; i < stringLength; i++) {
            if(mappingFromS[ s[i] ] != t[i] || mappingFromT[ t[i] ] != s[i]) {
                return false;
            }
        }
        return true;
    }
};
