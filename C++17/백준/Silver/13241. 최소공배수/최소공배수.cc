#include "bits/stdc++.h"
using namespace std;

long long int GCD(int a, int b)
{
    if (a % b == 0)
    {
        return b;
    }

    return GCD(b, a%b);
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    long long int c, c1; cin >> c >> c1;

    long long int gcd = GCD(c, c1);

    cout << c * c1 / gcd;
    
    return 0;
}


