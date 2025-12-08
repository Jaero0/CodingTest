#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int ad = 0;

    for (int i = 0; i < 5; ++i)
    {
        int64_t s = 0;
        cin >> s;

        ad += (s * s) % 10;

        if (ad >= 10)
        {
            ad %= 10;
        }
    }

    cout << ad;

    return 0;
}