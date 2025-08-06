#include <chrono>
#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int input;
    cin >> input;

    vector<int> stairs;

    for (int i = 0; i < input; ++i)
    {
        int t; cin >> t;
        stairs.push_back(t);
    }

    vector<pair<int,int>> skip_stair_continue_stair;

    skip_stair_continue_stair.emplace_back(0, stairs[0]);
    skip_stair_continue_stair.emplace_back(stairs[1], stairs[0] + stairs[1]);

    for (int i = 2; i < input; ++i)
    {
        int skip = stairs[i] + std::max(skip_stair_continue_stair[i-2].first, skip_stair_continue_stair[i-2].second);
        int cont = stairs[i] + skip_stair_continue_stair[i-1].first;

        skip_stair_continue_stair.emplace_back(make_pair(skip, cont));
    }

    int max = std::max(skip_stair_continue_stair[input-1].first, skip_stair_continue_stair[input-1].second);

    cout << max;
    return 0;
}
