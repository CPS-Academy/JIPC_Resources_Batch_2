#include<bits/stdc++.h>
using namespace std;

struct Compare {
    bool operator()(pair<int, pair<int, int>> point1, pair<int, pair<int, int>> point2) {
        if(point1.first == point2.first) {
            return point2.second < point1.second;
        }
        return point1.first < point2.first; // 1 < 2
    }
};

bool cmp(pair<int, int> point1, pair<int, int> point2) {
    if(point1.first == point2.first) {
        return point2.second < point1.second;
    }
    return point1.first < point2.first; // 1 < 2
}

int main()
{
    /*
    1. MAP
    map<string, int> nameRollMap;

    nameRollMap["Rasel"] = 1;
    nameRollMap["Samin"] = 30;
    nameRollMap["Nasim"] = 4;

    for(auto nameRollPair: nameRollMap) {
        cout << nameRollPair.first << " " << nameRollPair.second << '\n';
    }

    nameRollMap.erase("Samin");
    cout << "is Samin Exist: " << nameRollMap.count("Samin");
    cout << "is Rasel Exist: " << nameRollMap.count("Rasel");
    */

    /*
    1. MULTI-MAP
    multimap<string, int> nameRollMap;
    nameRollMap.insert({"Rasel", 1});
    nameRollMap.insert({"Samin", 30});
    nameRollMap.insert({"Nasim", 4});
    nameRollMap.insert({"Samin", 31});
    nameRollMap.insert({"Nasim", 4});

    for(auto nameRollPair: nameRollMap) {
        cout << nameRollPair.first << " " << nameRollPair.second << '\n';
    }
    cout << '\n';

    nameRollMap.erase(nameRollMap.find("Samin"));

    for(auto nameRollPair: nameRollMap) {
        cout << nameRollPair.first << " " << nameRollPair.second << '\n';
    }
    */

    /* Stack
    stack<int> stk;
    stk.push(1);
    stk.push(5);
    stk.push(2);

    cout << "top value: " << stk.top() << '\n';
    stk.pop();
    stk.pop();

    stk.push(5);
    stk.push(15);
    stk.push(25);

    while(!stk.empty()) {
        cout << "current top value: " << stk.top() << " current stack size: " << stk.size() << '\n';
        stk.pop();
    }
    */

    /* Queue
    queue<string> q;
    q.push("Rasel");
    q.push("Rakib");
    q.push("Atik");

    q.pop();
    q.push("Samin");

    while(!q.empty()) {
        cout << q.front() << '\n';
        q.pop();
    }
    */

    /*
    priority_queue<int, vector<int>, greater<int>> pq;
    pq.push(5);
    pq.push(10);
    pq.push(1);
    pq.push(7);

    while(!pq.empty()) {
        cout << pq.top() << '\n';
        pq.pop();
    }
    */

    /*
    priority_queue<pair<int, int>, vector<pair<int, int>>, Compare> pq;
    pq.push({1, 2});
    pq.push({5, 4});
    pq.push({1, 5});
    pq.push({2, 6});
    pq.push({2, 10});

    while(!pq.empty()) {
        cout << pq.top().first << " " << pq.top().second << '\n';
        pq.pop();
    }
    */

    /* Deque
    deque<string> names;
    names.push_front("Samin");
    names.push_back("Rakib");
    names.push_back("Atik");
    names.push_front("Suzon");
    names.push_front("Anupam");

    cout << names.front() << " front:back " << names.back() << '\n';
    names.pop_front();
    cout << names.front() << " front:back " << names.back() << '\n';

    for(int i = 0; i < names.size(); i++) {
        cout << names[i] << " ";
    }
    cout << '\n';
    */

    /*
    vector<pair<int, int>> points;
    for(int i = 0; i < 5; i++) {
        int x, y;
        cin >> x >> y;
        points.push_back({x, y});
    }
    cout << '\n';
    sort(points.begin(), points.end(), greater<>());
    for(int i = 0 ;i < 5; i++) {
        cout << points[i].first << " " << points[i].second << '\n';
    }
    cout << '\n';
    */

    vector<int> v;
    for(int i = 0; i < 5; i++) {
        int x;
        cin >> x;
        v.push_back(x);
    }
    sort(v.begin(), v.end());

    cout << *lower_bound(v.begin(), v.end(), 3) << '\n';
    cout << lower_bound(v.begin(), v.end(), 3) - v.begin() << '\n';
    cout << upper_bound(v.begin(), v.end(), 3) - v.begin() << '\n';

    set<int> s;
    s.insert(1);
    s.insert(10);
    s.insert(13);
    s.insert(15);
    cout << *s.lower_bound(12) << '\n';

    return 0;
}
