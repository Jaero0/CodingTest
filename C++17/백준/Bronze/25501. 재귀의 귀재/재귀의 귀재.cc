#include "bits/stdc++.h"
using namespace std;

int recursion(const char *s, int l, int r){
    if(l >= r) return 1;
    else if(s[l] != s[r]) return 0;
    else return recursion(s, l+1, r-1);
}

int isPalindrome(const char *s){
    return recursion(s, 0, strlen(s)-1);
}


int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    for (int i = 0; i < c; ++i)
    {
        string inp; cin >> inp;

        int checkCount = 0;

        size_t length = inp.length();
        bool isBreak = false;
        for (int j = 0; j < length / 2; ++j)
        {
            if (inp[j] == inp[length - 1 - j])
            {
                checkCount++;
            }
            else
            {
                checkCount++;
                isBreak = true;
                break;
            }
        }

        if (isBreak == true)
        {
            cout << 0 << " " << checkCount << "\n";
        }
        else
        {
            cout << 1 << " " << checkCount + 1 << "\n";
        }

    }
    
    
    return 0;
}
