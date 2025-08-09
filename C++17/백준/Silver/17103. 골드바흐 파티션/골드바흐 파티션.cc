#include <algorithm>
#include <chrono>

#include "bits/stdc++.h"
using namespace std;

#define MAX_NUM 1000000
bool primes[MAX_NUM+ 1] = {false};

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    
    primes[0] = true;
    primes[1] = true;

    for (int i = 2; i * i <= MAX_NUM; ++i)
    {
        for (int j = i * i; j <= MAX_NUM; j += i)
        {
            primes[j] = true;
        }
    }

    set<int> primeNum;
    int maxInput = 2;

    int c; cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int N; cin >> N;
        
        if (maxInput <= N)
        {
            for (int i = maxInput; i <= N; ++i)
            {
                if (primes[i] == false)
                {
                    primeNum.insert(i);
                }
            }

            maxInput = N;
        }

        int count = 0;

        size_t size = primeNum.size();

        for (auto i_num : primeNum)
        {
            if (i_num > N / 2)
            {
                break;
            }
            if (primeNum.count(N - i_num) > 0)
            {
                count++;
            }
        }

        cout << count << "\n";
    }
    
    return 0;
}


