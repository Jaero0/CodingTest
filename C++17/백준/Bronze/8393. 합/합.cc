#include "bits/stdc++.h"
using namespace std;

//5525
int main()
{
    int N; cin >> N;

    int sum = 0;
    for (int i = 1; i <= N; ++i)
    {
        sum += i;
    }

    cout << sum ;
    return 0;
}