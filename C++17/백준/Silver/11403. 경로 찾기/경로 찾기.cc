#include "bits/stdc++.h"
using namespace std;

//5525
int main()
{
    int N; cin >> N;

    vector<vector<int>> matrix(N, vector<int>(N));

    map<int, vector<int>> one_side_graph;

    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < N; ++j)
        {
            int t; cin >> t;

            matrix[i][j] = t;

            if (t == 1)
            {
                if (one_side_graph[i].empty())
                {
                    vector<int> v = {j};
                    one_side_graph[i] = v;
                }
                else
                {
                    one_side_graph[i].push_back(j);
                }
            }
        }
    }

    queue<int> HaveToVisit;
    vector<vector<bool>> visited(N, vector<bool>(N, false));

    for (int i = 0; i < N; ++i)
    {
        for (auto gr : one_side_graph[i])
        {
            if (visited[i][gr] == true)
            {
                continue;
            }
            
            HaveToVisit.push(gr);
        }

        while (!HaveToVisit.empty())
        {
            int node = HaveToVisit.front();
            HaveToVisit.pop();

            if (visited[i][node] == true)
            {
                continue;
            }

            visited[i][node] = true;

            for (int j : one_side_graph[node])
            {
                if (visited[i][j] == true)
                {
                    continue;
                }
                
                HaveToVisit.push(j);
            }
        }
    }

    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < N; ++j)
        {
            cout << (visited[i][j] == true ? 1 : 0) << " ";
        }
        
        cout << "\n";
    }

    return 0;
}