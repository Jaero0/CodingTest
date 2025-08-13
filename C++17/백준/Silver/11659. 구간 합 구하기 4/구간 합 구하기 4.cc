#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c, c1; cin >> c >> c1;

    vector<int> sums;
    sums.reserve(c);
    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;

        if (i != 0)
        {
            sums.push_back(sums[i-1] + t);
            continue;
        }
        
        sums.push_back(t);
    }

    int t, t1;
    for (int i = 0; i < c1; i++)
    {
        cin >> t >> t1;
        
        if (t - 2 < 0)
        {
            cout << sums[t1-1] << "\n";
        }
        else
        {
            cout << sums[t1-1] - sums[t-2] << "\n";
        }
    }
    
    
    return 0;
}
