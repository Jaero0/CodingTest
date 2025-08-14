#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c, c1; cin >> c >> c1;

    if (c > 0)
    {
        if (c1 < 0)
        {
            cout << 4;
        }
        else
        {
            cout << 1;
        }
    }
    else
    {
        if (c1 < 0)
        {
            cout << 3;
        }
        else
        {
            cout << 2;
        }
    }
    
    return 0;
}


