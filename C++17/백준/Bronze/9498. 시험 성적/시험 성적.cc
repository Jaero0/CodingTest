#include "bits/stdc++.h"
using namespace std;

int main()
{
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);

    int c; cin >> c;

    if (90 <= c)
    {
        cout << "A";
    }
    else if (80 <= c)
    {
        cout << "B";
    }
    else if (70 <= c)
    {
        cout << "C";
    }
    else if (60 <= c)
    {
        cout << "D";
    }
    else 
        cout << "F";
    
    
    return 0;
}
