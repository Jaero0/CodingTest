#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N, M;
    cin >> N >> M;
    
    if (N == M)
    {
        cout << 0;
        return 0;
    }
    
    int count = 0;
    queue<pair<int,int>> HaveToVisitWithCount;
    HaveToVisitWithCount.emplace(N, 0);

    vector<bool> visited(100001, false);
    
    while (!HaveToVisitWithCount.empty())
    {
        auto nodeCount = HaveToVisitWithCount.front();
        HaveToVisitWithCount.pop();

        int first = nodeCount.first;

        if (first - 1 == M || first + 1 == M || first * 2 == M)
        {
            count = nodeCount.second + 1;
            break;
        }
        
        if (visited[first] == true)
        {
                continue;
        }
        
        visited[first] = true;

        for (int next : {first - 1, first + 1, first * 2})
        {
            if (next < 0 || next > 100000 || visited[next] == true )
            {
                continue;
            }

            HaveToVisitWithCount.emplace(next, nodeCount.second + 1);
        }
    }

    cout << count;
    
    return 0;
}