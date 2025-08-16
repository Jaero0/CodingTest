#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    vector<int> v;
    v.push_back(-1);

    v.push_back(1);
    v.push_back(3);

    for (int i = 3; i <= 1000; ++i)
    {
        v.push_back((v[i-1] + v[i-2] * 2) % 10007);
    }

    cout << v[c];

    return 0;
}


