#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    string s; cin >> s;

    list<char> list;
    list.push_back('0');

    for (int i = 0; i < s.length(); ++i)
    {
        list.push_back(s[i]);
    }

    int t; cin >> t;
    auto ptr = list.end();

    for (int i = 0; i < t; ++i)
    {
        char ts; cin >> ts;
        char c;

        if (ts == 'P')
        {
            cin >> c;
        }

        switch (ts)
        {
        case 'L':
            if (ptr == list.begin())
            {
                continue;
            }

            --ptr;
            break;
        case 'D':
            if (ptr == list.end())
            {
                continue;
            }

            ++ptr;
            break;
        case 'B':
            if (ptr == list.begin())
            {
                continue;
            }
            --ptr;
            ptr = list.erase(ptr);
            break;
        case 'P':
            list.insert(ptr, c);
            break;
        }
    }

    for (char c : list)
    {
        if (c == '0')
        {
            continue;
        }
        cout << c;
    }
    
    return 0;
}
