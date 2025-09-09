#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N, M; cin >> N >> M;

    vector<pair<int,int>> moveTo;

    for (int i = 0; i < N + M; ++i)
    {
        int t, t1; cin >> t >> t1;

        moveTo.emplace_back(t, t1);
    }

    vector<int> visited(100, 100000);

    queue<pair<int,int>> HaveToVisit;
    HaveToVisit.emplace(1,0);

    int finish = 0;
    bool IsHund = false;

    while (!HaveToVisit.empty() && IsHund == false)
    {
        auto nodeCount = HaveToVisit.front();
        int node = nodeCount.first;
        int count = nodeCount.second;
        
        HaveToVisit.pop();

        if (visited[node] < count)
        {
            continue;
        }

        visited[node] = count;

        for (int i = 1; i <= 6; ++i)
        {
            int nn = node + i;

            if (nn == 100)
            {
                finish = count + 1;
                IsHund = true;
                break;
            }

            for (auto move_to : moveTo)
            {
                if (nn == move_to.first)
                {
                    nn = move_to.second;
                    break;
                }
            }

            if (visited[nn] < count + 1)
            {
                continue;
            }

            HaveToVisit.emplace(nn, count + 1);
        }
    }

    cout << finish;

    return 0;
}
