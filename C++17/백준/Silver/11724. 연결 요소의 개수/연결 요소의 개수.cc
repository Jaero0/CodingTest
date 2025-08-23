#include "bits/stdc++.h"
using namespace std;

void DFS(map<int, vector<int>> &g, int visitingNode, vector<bool> &visited)
{
    for (int i : g[visitingNode])
    {
        if (visited[i] == true)
        {
            continue;
        }
        visited[i] = true;

        DFS(g, i, visited);
    }
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N, M; cin >> N >> M;

    map<int, vector<int>> graph;
    vector<bool> visited (N+1, false);

    for (int i = 0; i < N; ++i)
    {
        vector<int> a;
        graph[i+1] = a;
    }
    
    for (int i = 0; i < M; ++i)
    {
        int t, t1; cin >> t >> t1;

        
        graph[t].push_back(t1);
        graph[t1].push_back(t);
    }

    int count = 0;

    for (auto value : graph)
    {
        if (visited[value.first] == true)
        {
            continue;
        }
        DFS(graph, value.first ,visited);
        visited[value.first] = true;

        count++;
        
    }

    cout << count;
    
    
    return 0;
}
