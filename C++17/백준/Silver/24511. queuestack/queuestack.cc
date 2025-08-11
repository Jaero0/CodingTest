#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    //init
    int c; cin >> c;

    vector<int> qs;

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;

        qs.push_back(t);
    }

    deque<int> dq;

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;
        if (qs[i] == 0)
        {
            dq.push_back(t);
        }
    }

    //insert
    cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int input; cin >> input;

        dq.push_front(input);
        cout << dq.back() << " ";
        dq.pop_back();
    }
    
    return 0;
}
