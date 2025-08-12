#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;
    
    set<string> s;

    int count = 0;
    for (int i = 0; i < c; ++i)
    {
        string inp; cin >> inp;

        if (inp =="ENTER")
        {
            count += s.size();
            s.clear();
            continue;
        }

        s.insert(inp);
    }

    if (!s.empty())
    {
        count += s.size();
    }

    cout << count;
    
    return 0;
}
