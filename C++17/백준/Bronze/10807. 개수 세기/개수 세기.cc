#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    
    int N; cin >> N;

    map<int,int> m;
    for (int i = 0; i < N; ++i)
    {
        int t; cin >> t;
        m[t] += 1;
    }

    cin >> N;
    cout << m[N];
    
    return 0;
}