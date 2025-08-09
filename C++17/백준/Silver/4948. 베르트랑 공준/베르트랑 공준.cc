#include "bits/stdc++.h"
using namespace std;


vector<bool> primes(246913);

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    primes[0] = true;
    primes[1] = true;

    for (int i = 2; i * i <= 246913; ++i)
    {
        for (int j = i * i; j <= 246913; j += i)
        {
            primes[j] = true;
        }
    }

    while (true)
    {
        int t; cin >> t;

        if (t == 0)
        {
            break;
        }

        int count = 0;
        for (int i = t + 1; i <= t * 2; ++i)
        {
            if (primes[i] == false)
            {
                count++;
            }
        }

        cout << count << "\n";
    }
    
    return 0;
}


