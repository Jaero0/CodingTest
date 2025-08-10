#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    deque<int> buf;

    for (int i = 0; i < c; ++i)
    {
        int s; cin >> s;

        if (s == 1)
        {
            int t; cin >> t;
            buf.push_front(t);
            continue;
        }
        
        if (s == 2)
        {
            int t; cin >> t;
            buf.push_back(t);
            continue;
        }
        
        if (s == 3)
        {
            if (buf.empty())
            {
                cout << -1 << "\n";
            }
            else {
                cout << buf.front() << "\n";
                buf.pop_front();
            }
            continue;
        }
        
        if (s == 4)
        {
            if (buf.empty())
            {
                cout << -1 << "\n";
            }
            else {
                cout << buf.back() << "\n";
                buf.pop_back();
            }
            continue;
        }
        
        if (s == 5)
        {
            cout << buf.size() << "\n";
            continue;
        }
        
        if (s == 6)
        {
            if (buf.empty())
            {
                cout << 1 << "\n";
            }
            else
            {
                cout << 0 << "\n";
            }
            continue;
        }
        
        if (s == 7)
        {
            if (buf.empty())
            {
                cout << -1 << "\n";
            }
            else
            {
                cout << buf.front() << "\n";
            }
            continue;
        }

        //else
        if (buf.empty())
        {
            cout << -1 << "\n";
        }
        else
        {
            cout << buf.back() << "\n";
        }

    }
    
    return 0;
}
