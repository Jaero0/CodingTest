#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N; cin >> N;

    for (int i = 0; i < N; ++i)
    {
        list<char> list;
        auto ptr = list.end();

        string s; cin >> s;

        for (char c : s)
        {
            switch (c)
            {
            case '<':
                if (ptr == list.begin())
                {
                    continue;
                }
                --ptr;
                break;
            case '>':
                if (ptr == list.end())
                {
                    continue;
                }
                ++ptr;
                break;
            case '-':
                if (ptr == list.begin())
                {
                    continue;
                }
                --ptr;
                ptr = list.erase(ptr);
                break;
            default:
                list.insert(ptr, c);
                break;
            }
        }

        for (char value : list)
        {
            cout<<value;
        }
        cout << "\n";
    }

    return 0;
}
