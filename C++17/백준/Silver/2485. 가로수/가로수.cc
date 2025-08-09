#include <algorithm>

#include "bits/stdc++.h"
using namespace std;

int GetGCD(int a, int b)
{
    if (a % b == 0)
    {
        return b;
    }

    return GetGCD(b, a % b);
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    vector<int> v;

    int c; cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;
        v.push_back(t);
    }
    
    vector<int> subs;
    subs.reserve(c - 1);
    
    for (int i = 0; i < c - 1; ++i)
    {
        subs.push_back(v[i + 1] - v[i]);
    }

    int gcd = 0;
    for (int i = 0; i < subs.size(); ++i)
    {
        if (gcd == 0)
        {
            gcd = GetGCD(subs[i], subs[i+1]);
            i++;
            continue;
        }

        gcd = GetGCD(gcd, subs[i]);
        
        
    }

    int count = 0;
    for (int i = 0; i < c - 1; ++i)
    {
        if (v[i] != v[i+1] - gcd)
        {
            count += (v[i+1] - v[i]) / gcd - 1;
        }
    }

    cout << count;
    
    return 0;
}
