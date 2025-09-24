#include "bits/stdc++.h"
using namespace std;

//5525
int main()
{
    int N, M, C; cin >> N >> M >> C;

    M += C;

    if (M > 59)
    {
        N += M / 60;
        M %= 60;
    }

    if (N > 23)
    {
        N %= 24;
    }

    cout << N << " " << M;
    return 0;
}