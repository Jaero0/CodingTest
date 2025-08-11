#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    deque<pair<int,int>> deq;
    

    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;
        deq.emplace_back(i + 1, t);
    }

    
    while (true)
    {
        int move = deq.front().second;
        cout << deq.front().first << " ";
        deq.pop_front();

        if (deq.empty())
        {
            break;
        }

        if (move > 0)
        {
            for (int i = 0; i < move - 1; ++i)
            {
                deq.push_back(deq.front());
                deq.pop_front();
            }
        }
        else
        {
            for (int i = 0; i < std::abs(move); ++i)
            {
                deq.push_front(deq.back());
                deq.pop_back();
            }
        }
    }
    
    return 0;
}
