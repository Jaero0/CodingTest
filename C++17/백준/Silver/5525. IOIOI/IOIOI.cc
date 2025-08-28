#include "bits/stdc++.h"
using namespace std;

//5525
int main()
{
    int N, S;
    cin >> N >> S;

    string IO;
    for (int i = 0; i < N; ++i)
    {
        IO += "IO";
    }
    IO += 'I';

    string input; cin >> input;

    int count = 0;
    for (int i = 0; i < S; ++i)
    {
        size_t io_len = IO.length();
        
        string t = input.substr(i);
        string t1 = t;

        if (t1.length() < io_len)
        {
            break;
        }

        int find = t.find(IO);
        if (find < 0)
        {
            break;
        }
        t1.replace(find, io_len, " ");

        if (t1.length() == t.length())
        {
            break;
        }

        i += t1.find(' ') + 1;
        count ++;
    }

    cout << count;
    
    return 0;
}