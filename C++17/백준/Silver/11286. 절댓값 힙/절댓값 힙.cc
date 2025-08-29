#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N;
    cin >> N;

    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> pq;

    for (int i = 0; i < N; ++i)
    {
        int c; cin >> c;

        if (c == 0)
        {
            if (pq.empty())
            {
                cout << 0;
            }
            else
            {
                cout << pq.top().second;
                pq.pop();
            }

            cout << "\n";
        }
        else
        {
                pq.emplace((c < 0 ? -c : c), c);
        }
    }
    
    return 0;
}