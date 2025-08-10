#include <algorithm>

#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    vector<int> v;

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;
        v.push_back(t);
    }

    sort(v.begin(), v.end());

    for (int v1 : v)
    {
        cout << v1 << "\n";
    }
    
    return 0;
}
