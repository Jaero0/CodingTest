#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int first = 0;
    int ascendingSum = 0;
    int descendingSum = 0;
    int totalSum = 0;
    
    for (int i = 1; i <= 8; ++i)
    {
        int input = 0; cin >> input;

        //1. mixed
        if (i == 1)
        {
            first = input;
            
            if (input != 1 && input != 8)
            {
                cout << "mixed";
                return 0;
            }
        }

        //2.
        ascendingSum += i;
        descendingSum += 8 - (i - 1);
        totalSum += input;

        if (ascendingSum != totalSum && descendingSum != totalSum)
        {
            cout << "mixed";
            return 0;
        }
    }
    
    if (first == 1)
    {
        cout << "ascending";
    }
    else
    {
        cout << "descending";
    }
    
    
    return 0;
}