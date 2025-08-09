#include <algorithm>

#include "bits/stdc++.h"
using namespace std;

int calc(int days, int money)
{
    int f = money - 500;
    int s = money * 0.9;
    int t = money - 2000;
    int fo = money * 0.75;
    
    if (0 <= days && days < 5)
    {
        return money;
    }

    if (5 <= days && days < 10)
    {
        return f < 0 ? 0 : f;
    }

    if (10 <= days && days < 15)
    {
        int min1 = min(f,s);
        return min1 > 0 ? min1 : 0;
    }

    if (15 <= days && days < 20)
    {
        int min1 = min({f, s, t});
        return min1 > 0 ? min1 : 0;
    }

    if (20 <= days)
    {
        int min1 = min({f,s,t,fo});
        return min1 > 0 ? min1 : 0;
    }
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    

    int c, c1; cin >> c >> c1;

    cout << calc(c,c1);
    
    return 0;
}
