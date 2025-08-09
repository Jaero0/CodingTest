#include "bits/stdc++.h"
using namespace std;

#define MAX_NUM 1000000
bool primes[MAX_NUM + 1] = {false};

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c;
    cin >> c;

    queue<int> horizontal;
    stack<int> vertical;

    for (int i = 0; i < c; ++i)
    {
        int t;
        cin >> t;
        horizontal.push(t);
    }

    int order = 1;
    bool isSad = false;
    
    while (true)
    {
        if (horizontal.empty() && vertical.empty())
        {
            break;
        }
        else if (!horizontal.empty() && vertical.empty())
        {
            if (horizontal.front() != order)
            {
                vertical.push(horizontal.front());
                horizontal.pop();
                continue;
            }

            horizontal.pop();
            order++;
        }
        else if (horizontal.empty() && !vertical.empty())
        {
            if (vertical.top() != order)
            {
                isSad = true;
                break;
            }

            vertical.pop();
            order++;
        }
        else
        {
            if (horizontal.front() != order && vertical.top() != order)
            {
                vertical.push(horizontal.front());
                horizontal.pop();
                continue;
            }

            if (horizontal.front() == order)
            {
                horizontal.pop();
                order++;
                continue;
            }

            vertical.pop();
            order++;
        }
    }

    cout << (isSad == true ? "Sad" : "Nice");

    return 0;
}
