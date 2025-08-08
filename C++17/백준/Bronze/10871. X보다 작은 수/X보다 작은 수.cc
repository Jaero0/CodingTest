#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c, c1; cin >> c >> c1;

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;

        if (t >= c1)
        {
            continue;
        }

        cout << t << " ";
    }
    
    
    return 0;
}
