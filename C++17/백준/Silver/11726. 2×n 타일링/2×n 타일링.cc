#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    vector<int> v;
    //0 pass
    v.push_back(-1);

    v.push_back(1);
    v.push_back(2);

    for (int i = 3; i <= 1000; ++i)
    {
        v.push_back((v[i-1] + v[i-2]) % 10007);
    }
    

    int c; cin >> c;
    cout << v[c];
    
    return 0;
}


