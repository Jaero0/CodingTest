#include "bits/stdc++.h"
using namespace std;

int GCD(int a, int b)
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

    int c, m; cin >> c >> m;
    int c1, m1; cin >> c1 >> m1;

    int gcd = GCD(m, m1);

    int resM = m1 * m / gcd;

    int resC = resM / m * c;
    int resC1 = resM / m1 * c1;
    int i = resC + resC1;

    int gcd2 = GCD(i, resM);

    cout << i / gcd2 << " " << resM / gcd2;
    
    return 0;
}


