#include <algorithm>

#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    queue<int> q;

    for (int i = 0; i < c; ++i)
    {
        string s; cin >> s;

        if (s == "push")
        {
            int t; cin >> t;

            q.push(t);
            continue;
        }
        if (s == "pop")
        {
            if (q.empty())
            {
                cout << -1 << "\n";
            }
            else
            {
                cout << q.front() << "\n";
                q.pop();
            }
            continue;
        }
        if (s == "size")
        {
            cout << q.size() << "\n";
            continue;
        }
        if (s == "empty")
        {
            if (q.empty())
            {
                cout << 1 << "\n";
            }
            else
            {
                cout << 0 << "\n";
            }
            continue;
        }
        if (s == "front")
        {
            if (q.empty())
            {
                cout << -1 << "\n";
            }
            else
            {
                cout << q.front() << "\n";
            }
            continue;
        }
        if (s == "back")
        {
            if (q.empty())
            {
                cout << -1 << "\n";
            }
            else
            {
                cout << q.back() << "\n";
            }
        }
    }
    
    return 0;
}
