class Solution {
private:
    const static int UNVISITED = 0;
    constexpr static int direction[5] = {0, 1, 0, -1, 0};

    bool isInside(vector<int> cell, int sideLength)
    {
        int x = cell[1], y = cell[2];
        return 0 <= x && x < sideLength && 0 <= y && y < sideLength;
    }

    int findLeastTime(vector<vector<int>>& grid)
    {
        priority_queue<vector<int>, vector<vector<int>>, greater<vector<int>>> Q; 
        Q.push({grid[0][0], 0, 0});
        int sideLength = grid.size();
        vector<vector<bool>> visited = vector<vector<bool>>(sideLength, vector<bool>(sideLength, UNVISITED));
        visited[0][0] = true;

        int maxValue = 0;
        while(!Q.empty()){
            vector<int> currentCell = Q.top();
            Q.pop();

            //  cout << currentCell[1] << " " << currentCell[2] << '\n';
            //  cout << grid[ currentCell[1] ][ currentCell[2] ] << '\n';

            maxValue = max(maxValue, grid[ currentCell[1] ] [ currentCell[2] ]);

            if(currentCell[1] + 1 == sideLength && currentCell[2] + 1 == sideLength) break;

            for(int i = 1; i < 5; i++){
                vector<int> nextCell = {
                    -1, 
                    currentCell[1] + direction[i - 1], 
                    currentCell[2] + direction[i]
                };

                if(isInside(nextCell, sideLength) && !visited[ nextCell[1] ][ nextCell[2] ]){
                    nextCell[0] = grid[ currentCell[1] + direction[i - 1] ][ currentCell[2] + direction[i] ];
                    Q.push({grid[nextCell[1]][nextCell[2]], nextCell[1], nextCell[2]});
                    visited[ nextCell[1] ][ nextCell[2] ] = true;

                    // cout << nextCell[1] << " yy " << nextCell[2] << '\n';
                }
            }

            cout << "here2\n";
        }

        return maxValue;
    }

public:
    int swimInWater(vector<vector<int>>& grid) {

        return findLeastTime(grid);
    }
};
