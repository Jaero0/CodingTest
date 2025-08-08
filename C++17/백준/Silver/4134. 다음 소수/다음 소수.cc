#include "bits/stdc++.h"
using namespace std;


int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    for (int i = 0; i < c; ++i)
    {
        uint32_t input; cin >> input;

        if (input <= 2)
        {
            cout << "2" << "\n";
            continue;
        }
        
        while (true)
        {
            bool isPrime = true;
            
            for (uint32_t i = 2; i * i <= input; ++i)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == false)
            {
                input++;
                continue;
            }

            cout << input << "\n";
            break;
        }
    }
    
    return 0;
}


