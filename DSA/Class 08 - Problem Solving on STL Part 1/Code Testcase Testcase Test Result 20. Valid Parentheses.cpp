class Solution {
public:
    bool isValid(string s) {
        stack<char> openingBrackets;
        unordered_map<char, char> closingToOpeningBracketMap;
        closingToOpeningBracketMap[')'] = '(';
        closingToOpeningBracketMap['}'] = '{';
        closingToOpeningBracketMap[']'] = '[';

        for(auto& bracket: s) {
            if(!closingToOpeningBracketMap.count(bracket)) {
                openingBrackets.push(bracket);
            }
            else if(!openingBrackets.empty() && openingBrackets.top() == closingToOpeningBracketMap[bracket]) {
                openingBrackets.pop();
            }
            else {
                return false;
            }
        }

        return openingBrackets.empty();
    }
};
