#include <algorithm>

#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c, c1; cin >> c >> c1;

    vector<int> v;

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;
        v.push_back(t);
    }

    sort(v.begin(), v.end());

    cout << v[c - c1];
    
    return 0;
}
