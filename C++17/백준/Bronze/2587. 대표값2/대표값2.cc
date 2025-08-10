#include <algorithm>

#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);


    vector<int> v;
    int sum = 0;
    for (int i = 0; i < 5; ++i)
    {
        int t; cin >> t;
        sum += t;
        v.push_back(t);
    }

    sort(v.begin(), v.end());

    cout << sum / 5 << "\n" << v[2];
    
    return 0;
}
