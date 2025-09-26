#include "bits/stdc++.h"
using namespace std;

//5525
int main()
{
    int N; cin >> N; 
    int M; cin >> M;

    int sum = 0;
    for (int i = 0; i < M; ++i)
    {
        int t, t1; cin >> t >> t1;

        sum += t * t1;
    }

    if (N == sum)
    {
        cout << "Yes";
    }
    else
    {
        cout << "No";
    }
    
    return 0;
}