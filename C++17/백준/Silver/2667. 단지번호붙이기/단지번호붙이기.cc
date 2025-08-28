#include "bits/stdc++.h"
using namespace std;

constexpr int dx[4] = {-1,1,0,0};
constexpr int dy[4] = {0,0,-1,1};

int main()
{
    int N;
    cin >> N;

    vector<vector<char>> graph(N, vector<char>(N));

    for (int i = 0; i < N; ++i)
    {
        string t; cin >> t;

        for (int j = 0; j < N; ++j)
        {
            graph[i][j] = t[j];
        }
    }

    vector<vector<bool>> visited(N, vector<bool>(N, false));
    queue<pair<int,int>> HaveToVisit;

    int count = 0;
    vector<int> houseCount;
    for (int y = 0; y < N; ++y)
    {
        for (int x = 0; x < N; ++x)
        {
            if (graph[y][x] == '0' || visited[y][x] == true)
            {
                continue;
            }

            set<pair<int,int>> tempVisit;

            HaveToVisit.emplace(y, x);

            while (!HaveToVisit.empty())
            {
                auto node = HaveToVisit.front();
                HaveToVisit.pop();

                int nodeY = node.first;
                int nodeX = node.second;

                if (visited[nodeY][nodeX] == true)
                {
                    continue;
                }

                visited[nodeY][nodeX] = true;
                tempVisit.emplace(nodeY, nodeX);

                for (int move = 0; move < 4; ++move)
                {
                    int my = nodeY + dy[move];
                    int mx = nodeX + dx[move];

                    if (my < 0 || my >= N || mx < 0 || mx >= N || graph[my][mx] == '0' || visited[my][mx] == true)
                    {
                        continue;
                    }

                    HaveToVisit.emplace(my, mx);
                }
            }

            count++;
            houseCount.push_back(tempVisit.size());
        }
    }

    cout << houseCount.size() << "\n";
    std::sort(houseCount.begin(), houseCount.end());

    for (auto p : houseCount)
    {
        cout << p << "\n";
    }
    
    return 0;
}