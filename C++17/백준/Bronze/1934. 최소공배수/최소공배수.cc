#include <algorithm>

#include "bits/stdc++.h"
using namespace std;

int GCD(int a, int b)
{
    if (a % b == 0)
    {
        return b;
    }

    return GCD(b, a % b);
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int t, t1; cin >> t >> t1;

        int gcd = GCD(t, t1);

        cout << t * t1 / gcd << "\n";
    }
    
    return 0;
}
