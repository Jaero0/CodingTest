#include "bits/stdc++.h"
using namespace std;

int Fibo(int a)
{
    if (a == 0)
    {
        return 0;
    }
    if (a == 1)
    {
        return 1;
    }

    return Fibo(a - 1) + Fibo(a-2);
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    vector<int> v;
    for (int i = 0; i <= 20; ++i)
    {
        v.push_back(Fibo(i));
    }
    
    int c;
    cin >> c;

    cout << v[c];
    
    return 0;
}
