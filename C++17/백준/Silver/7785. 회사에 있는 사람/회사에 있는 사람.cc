#include "bits/stdc++.h"
using namespace std;


int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    map<string, bool> map;
    
    for (int i = 0; i < c; ++i)
    {
        string name, state; cin >> name >> state;

        if (state == "enter")
        {
            map[name] = true;
            continue;
        }

        if (map[name] == true)
        {
            map[name] = false;
        }
    }

    for (auto it = map.rbegin(); it != map.rend(); ++it)
    {
        if (it->second == true)
        {
            cout << it->first << "\n";
        }
    }

    
    return 0;
}
