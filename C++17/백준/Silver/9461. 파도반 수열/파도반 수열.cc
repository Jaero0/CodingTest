#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    vector<uint64_t> v;
    v.reserve(101);
    
    v.push_back(0);
    v.push_back(1);
    v.push_back(1);
    v.push_back(1);

    for (int i = 4; i <= 100; ++i)
    {
        v.push_back(v[i-2] + v[i-3]);
    }

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;
        cout << v[t] << "\n";
    }

    return 0;
}


