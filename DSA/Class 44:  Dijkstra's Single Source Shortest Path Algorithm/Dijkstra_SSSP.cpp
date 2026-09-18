class Solution {
private:
    vector<int> edges[101], cost[101];
public:
    int networkDelayTime(vector<vector<int>>& times, int n, int k) {
        for(auto& time: times) { // time = [from_node, to_node, weight]
            int fromNode = time[0];
            int toNode = time[1];
            int weight = time[2];
            edges[fromNode].push_back(toNode);
            cost[fromNode].push_back(weight);
        }

        vector<int> distance(n + 1, INT_MAX);
        distance[k] = 0;

        // minHeap -> [minCost, node]
        priority_queue<vector<int>, vector<vector<int>>, greater<vector<int>>> minHeap;
        minHeap.push({0, k});

        while(!minHeap.empty()) {
            vector<int> u = minHeap.top(); minHeap.pop();
            int timeToReachTheNode = u[0];
            int currentNode = u[1];

            if(distance[currentNode] < timeToReachTheNode) {
                continue;
            }

            for(int i = 0; i < edges[currentNode].size(); i++) {
                int nextNode = edges[currentNode][i];
                int currentCost = cost[currentNode][i];
                if(timeToReachTheNode + currentCost < distance[nextNode]) {
                    distance[nextNode] = timeToReachTheNode + currentCost;
                    minHeap.push({timeToReachTheNode + currentCost, nextNode});
                }
            } 
        }

        int minTimeForAllNodes = 0;
        for(int node = 1; node <= n; node++) {
            minTimeForAllNodes = max(minTimeForAllNodes, distance[node]);
        }
        return minTimeForAllNodes == INT_MAX ? -1 : minTimeForAllNodes;
    }
};
