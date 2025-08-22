#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    priority_queue<int> pq;

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;

        if (t == 0)
        {
            if (pq.empty())
            {
                cout << 0 << "\n";
                continue;
            }

            cout << pq.top() << "\n";
            pq.pop();
            continue;
        }

        pq.push(t);
    }
    
    return 0;
}
