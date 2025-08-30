#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N, S;
    cin >> N >> S;
    
    string input; cin >> input;

    int tempCount = 0;
    string temp;
    int lastIdx = 0;

    int realCount = 0;
    for (int i = 0; i < S - 2; ++i)
    {
        if (input[i] == 'I')
        {
            temp += input[i];
            temp += input[i+1];
            temp += input[i+2];
            
            if (temp == "IOI")
            {
                
                if (i != lastIdx)
                {
                    tempCount = 0;
                }
                
                lastIdx = i+2;
                
                tempCount++;

                if (tempCount == N)
                {
                    realCount++;
                    tempCount--;
                }

                i += 1;
                temp.clear();
            }
            else
            {
                tempCount = 0;
                temp.clear();
            }
        }
    }

    cout << realCount;
    
    return 0;
}