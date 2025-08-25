#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N, M, A;
    cin >> N >> M >> A;

    if (N != M && N != A && M != A)
    {
        int m = std::max(std::max(N,M), A);
        cout << m * 100;
    }
    else if (N == M && M == A)
    {
        cout << 10000 + N * 1000;
    }
    else
    {
        int ch = 0;
        if (N == M || N == A)
        {
            ch = N;
        }
        else if (M == A || M == N)
        {
            ch = M;
        }
        else
        {
            ch = A;
        }

        cout << ch * 100 + 1000;
    }
    
    return 0;
}
