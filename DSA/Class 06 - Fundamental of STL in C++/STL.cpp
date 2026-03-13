#include<bits/stdc++.h>
using namespace std;
int main()
{
/*  1. Pair

    pair<int, string> demoPair;
    demoPair.first = 1;
    demoPair.second = "Karim";
    cout << demoPair.first << " " << demoPair.second << '\n';

    pair<int, string> demoPair2 = {1, "Karim"};
    cout << demoPair2.first << " " << demoPair2.second << '\n';


    // (x, y) -> (1, 2), (2, 5), (6, 7)
    pair<double, double> cordinate[5];
    for(int i = 0; i < 5; i++) {
        cordinate[i].first = i;
        cordinate[i].second = i + 1;
    }
    for(int i = 0; i < 5; i++) {
        cout << cordinate[i].first << " " << cordinate[i].second << '\n';
    }


    pair<double, pair<double, double>> cordinate3d[5];

    for(int i = 0; i < 5; i++) {
        cordinate3d[i].first = i;
        cordinate3d[i].second.first = i + 1;
        cordinate3d[i].second.second = i + 2;
    }
    for(int i = 0; i < 5; i++) {
        cout << cordinate3d[i].first << " " << cordinate3d[i].second.first
        << " " << cordinate3d[i].second.second << '\n';
    }
*/

/* 2. Vector
    vector<int> vec;
    for(int i = 0; i < 10; i++) {
        vec.push_back(i);
    }
    for(int i = 0; i < vec.size(); i++) {
        cout << vec[i] << " ";
    }
    cout << '\n';

    vec.pop_back();
    for(int i = 0; i < vec.size(); i++) {
        cout << vec[i] << " ";
    }
    cout << '\n';
    */

// 3. Unordered_set
/*
    unordered_set<string> hashSetOfStrings;
    hashSetOfStrings.insert("Samin");
    hashSetOfStrings.insert("Yasir");
    hashSetOfStrings.insert("Samin");

    cout << "hash set size: " << hashSetOfStrings.size() << '\n';
    for(auto name: hashSetOfStrings) {
        cout << name << "\n";
    }
    cout << "Rakib: " << hashSetOfStrings.count("Rakib") << '\n';
    cout << "Samin: " << hashSetOfStrings.count("Samin") << '\n';

    hashSetOfStrings.erase("Samin");

    unordered_set<string>::iterator it;
    for(it = hashSetOfStrings.begin(); it != hashSetOfStrings.end(); it++) {
        cout << *it << "\n";
    }


    unordered_set<string> namesSet;
    for(int i = 0; i < 3; i++) {
        string name;
        cin >> name;
        namesSet.insert(name);
    }
    for(auto name: namesSet) {
        cout << name << "\n";
    }
    */

    /* 4. Set
    set<int> valueSet;
    valueSet.insert(1);
    valueSet.insert(10);
    valueSet.insert(5);
    valueSet.insert(7);
    valueSet.insert(10);

    for(auto value: valueSet) {
        cout << value << '\n';
    }

    for(auto it = valueSet.rbegin(); it != valueSet.rend(); it++) {
        cout << *it << " ";
    }
    cout << '\n'
   */

   /*
   multiset<string> names;
   names.insert("Samin");
   names.insert("Nabila");
   names.insert("Rakib");
   names.insert("Nabila");

   for(auto name: names) {
        cout << name << '\n';
    }

    auto namePtr = names.find("Nabila");
    names.erase(namePtr);

    cout << "After erase: \n";
    for(auto name: names) {
        cout << name << '\n';
    }
    */


    unordered_map<double, string> values;
    values[3.14] = "pi";
    values[9.8] = "g";
    values.insert({1, "abcd"});

    cout << values[3.14] << " " << values[9.8] << "\n";
    cout << values[3.15] << " " << values[9.9] << "\n";
    cout << values[1.0] << "\n";

    values[3.14] = "PI";

    values.erase(9.8);

    for(auto keyValuePair: values) {
        cout << keyValuePair.first << " key:value " << keyValuePair.second << '\n';
    }
    cout << "9.8 " << values.count(9.8) << '\n';
    cout << "3.14 " << values.count(3.14) << '\n';

    return 0;
}
