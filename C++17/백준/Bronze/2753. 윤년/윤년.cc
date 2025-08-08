#include "bits/stdc++.h"
using namespace std;

int main()
{
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);

    int c; cin >> c;

    if (c % 400 == 0)
    {
        cout << 1;
    }
    else if (c % 4 == 0 && c % 100 != 0)
    {
        cout << 1;
    }
    else
    {
        cout << 0;
    }
    
    
    return 0;
}
