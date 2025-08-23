#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N, M; cin >> N >> M;

    map<int, vector<int>> graph;
    vector<bool> visited(N + 1, false); // set -> vector<bool>

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
    queue<int> HaveToVisit;

    for (auto value : graph)
    {
        if (visited[value.first])
        {
            continue;
        }
        
        HaveToVisit.push(value.first);
        
        while (!HaveToVisit.empty())
        {
            int node = HaveToVisit.front();
            HaveToVisit.pop();

            if (visited[node])
            {
                continue;
            }

            visited[node] = true;
            for (int i : graph[node])
            {
                HaveToVisit.push(i);
            }
        }

        count++;
    }
    
    cout << count;
    
    return 0;
}
