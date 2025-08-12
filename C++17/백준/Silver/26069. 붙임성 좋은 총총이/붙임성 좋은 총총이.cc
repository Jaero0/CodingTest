#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;
    
    set<string> s;

    bool isChong = false;
    
    for (int i = 0; i < c; ++i)
    {
        string inp, inp2; cin >> inp >> inp2;

        if (inp == "ChongChong" || inp2 == "ChongChong")
        {
            s.insert(inp);
            s.insert(inp2);
            isChong = true;
        }

        if (isChong == false)
        {
            continue;
        }

        if (s.count(inp) > 0)
        {
            s.insert(inp2);
        }
        else if (s.count(inp2) > 0)
        {
            s.insert(inp);
        }
    }

    cout << s.size();
    
    return 0;
}
