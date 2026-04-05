class Solution {
public:
    vector<vector<string>> groupStrings(vector<string>& strings) {
        unordered_map<string, vector<string>> finalString_inputString_map;
        for(auto& currentString: strings) {
            int difference = currentString[0] - 'a';
            string finalString = "";
            for(auto& ch: currentString) {
                int value = ch - difference; // 'z' - 25 -> 120 - 25 -> 95 = 'a'
                if(value < 'a') value += 26;
                finalString += (char)(value);
            }
            finalString_inputString_map[finalString].push_back(currentString);
        }

        vector<vector<string>> groupStringList;
        for(auto& keyValuePair: finalString_inputString_map) {
            groupStringList.push_back(keyValuePair.second);
        }
        return groupStringList;
    }
};
