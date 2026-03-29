class Solution {
public:
    int romanToInt(string s) {
        unordered_map<char, int> romanSymbolToIntegeValueMap;
        romanSymbolToIntegeValueMap['I'] = 1;
        romanSymbolToIntegeValueMap['V'] = 5;
        romanSymbolToIntegeValueMap['X'] = 10;
        romanSymbolToIntegeValueMap['L'] = 50;
        romanSymbolToIntegeValueMap['C'] = 100;
        romanSymbolToIntegeValueMap['D'] = 500;
        romanSymbolToIntegeValueMap['M'] = 1000;

        int integerValue = romanSymbolToIntegeValueMap[ s.back() ];
        for(int i = s.size() - 2; i >= 0; i--) {
            if(romanSymbolToIntegeValueMap[ s[i] ] < romanSymbolToIntegeValueMap[ s[i + 1] ]) { // alpha < beta (-)
                integerValue -= romanSymbolToIntegeValueMap[ s[i] ];
            }
            else { // alpha >= beta (+)
                integerValue += romanSymbolToIntegeValueMap[ s[i] ];
            }
        }
        return integerValue;
    }
};
/*
    157 -> CLVII
    99  -> IC
*/
