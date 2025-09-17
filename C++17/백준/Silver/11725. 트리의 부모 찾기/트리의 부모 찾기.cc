#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N; cin >> N;

    map<int,vector<int>> tree;
    
    for (int i = 0; i < N - 1; ++i)
    {
        int t, t1; cin >> t >> t1;

        if (!tree[t].empty())
        {
            tree[t].push_back(t1);
        }
        else
        {
            vector<int> vt = {t1};
            tree[t] = vt;
        }

        if (!tree[t1].empty())
        {
            tree[t1].push_back(t);
        }
        else
        {
            vector<int> vt = {t};
            tree[t1] = vt;
        }
    }

    queue<int> HaveToVisit;
    vector<int> v(N + 1);
    HaveToVisit.push(1);

    while (!HaveToVisit.empty())
    {
        int node = HaveToVisit.front();
        HaveToVisit.pop();

        for (int i : tree[node])
        {
            if (i == 1)
            {
                continue;
            }
            if (v[i] > 0)
            {
                continue;
            }
            
            HaveToVisit.push(i);
            v[i] = node;
        }
    }

    for (int i = 2; i <= N ; ++i)
    {
        cout << v[i] << "\n";
    }
    
    return 0;
}