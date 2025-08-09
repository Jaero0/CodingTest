#include <algorithm>
#include <chrono>

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

    stack<int> st;

    for (int i = 0; i < c; ++i)
    {
        int t;
        cin >> t;

        size_t size = st.size();

        if (t == 1)
        {
            int temp; cin >> temp;
            st.push(temp);
        }
        else if (t == 2)
        {
            if (size == 0)
            {
                cout << -1 << "\n";
            }
            else
            {
                cout << st.top() << "\n";
                st.pop();
            }
        }
        else if (t == 3)
        {
            cout << size << "\n";
        }
        else if (t == 4)
        {
            if (size == 0)
            {
                cout << 1 << "\n";
            }
            else
            {
                cout << 0 << "\n";
            }
        }
        else if (t == 5)
        {
            if (size == 0)
            {
                cout << -1 << "\n";
            }
            else
            {
                cout << st.top() << "\n";
            }
        }
    }

    return 0;
}
