#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    int arr[50001] = {0};
    
    arr[0] = -1;
    arr[2] = 2;
    arr[3] = 3;

    for (int i = 1; i * i <= 50000; ++i)
    {
        arr[i * i] = 1;

        if (i * i * 2 <= 50000)
        {
            arr[i*i*2] = 2;
        }
    }
    
    for (int i = 5; i <= c; ++i)
    {
        if (arr[i] > 0)
        {
            continue;
        }

        int min = 10000;
        for (int j = 1; j*j <= i; ++j)
        {
            min = std::min((arr[j*j] + arr[i-j*j]), min);
        }

        arr[i] = min;
    }

    cout << arr[c];

    return 0;
}


