#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c;
    cin >> c;

    vector<int> v;
    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;
        v.push_back(t);
    }

    if (v.size() == 1)
    {
        cout << v[0] * v[0];
        return 0;
    }

    sort(v.begin(), v.end());

    cout << v[0] * v[v.size()-1];

    return 0;
}
