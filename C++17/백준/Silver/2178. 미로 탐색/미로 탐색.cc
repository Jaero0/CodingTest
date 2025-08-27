#include "bits/stdc++.h"
using namespace std;

const int dx[4] = {-1,1,0,0};
const int dy[4] = {0,0,-1,1};

int main()
{
    int N, M;
    cin >> N >> M;

    vector<vector<char>> graph(N, vector<char>(M));

    for (int i = 0; i < N; ++i)
    {
        string s; cin >> s;

        for (int j = 0; j < M; ++j)
        {
            graph[i][j] = s[j];
        }
    }

    vector<vector<bool>> visited(N, vector<bool>(M, false));

    queue<pair<pair<int,int>,int>> HaveToVisitNodeCount;
    HaveToVisitNodeCount.emplace(make_pair(0,0), 1);

    int c = 0;
    while (!HaveToVisitNodeCount.empty())
    {
        auto nodeCount = HaveToVisitNodeCount.front();
        HaveToVisitNodeCount.pop();

        auto node = nodeCount.first;
        int y = node.first;
        int x = node.second;
        int count = nodeCount.second;

        if (y + 1 == N && x + 1 == M)
        {
            c = count;
            break;
        }
        
        if (visited[y][x] == true)
        {
            continue;
        }

        visited[y][x] = true;

        for (int move = 0; move < 4; ++move)
        {
            int my = y + dy[move];
            int mx = x + dx[move];

            if (my < 0 || mx < 0 || my >= N || mx >= M || visited[my][mx] == true || graph[my][mx] == '0')
            {
                continue;
            }

            HaveToVisitNodeCount.emplace(make_pair(my,mx), count + 1);
        }
    }

    cout << c;
    
    return 0;
}