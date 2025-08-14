#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    vector<int> v;
    //0번 무시
    v.push_back(-1);

    v.push_back(1);
    v.push_back(2);
    v.push_back(4);

    for (int i = 4; i <= 11; ++i)
    {
        v.push_back(v[i-1] + v[i-2] + v[i-3]);
    }

    int c; cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;
        cout << v[t] << "\n";
    }

    
    return 0;
}


