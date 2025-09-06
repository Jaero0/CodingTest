#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N;
    cin >> N;

    vector<pair<int, int>> startEnd;

    for (int i = 0; i < N; ++i)
    {
        int t, t1;
        cin >> t >> t1;

        startEnd.emplace_back(t, t1);
    }

    sort(startEnd.begin(), startEnd.end(),
    [](const pair<int,int>& f, const pair<int,int>& s) {
        if (f.second == s.second)
            return f.first < s.first;
        
        return f.second < s.second;
    });

    int count = 0;
    int end = -1;

    for (auto [f, s] : startEnd)
    {
        if (f >= end)
        {
            end = s;
            count++;
        }
    }

    cout << count;
    
    return 0;
}
