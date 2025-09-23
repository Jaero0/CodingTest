#include "bits/stdc++.h"
using namespace std;


int main()
{
    int N; cin >> N;

    vector<vector<int>> tri;
    vector<vector<int>> dp;
    
    for (int i = 0; i < N; ++i)
    {
        vector<int> vt;
        vector<int> dvt;;
        for (int j = 0; j <= i; ++j)
        {
            int t; cin >> t;
            vt.push_back(t);
            dvt.push_back(0);
        }

        tri.push_back(vt);
        dp.push_back(dvt);
    }

    dp[0][0] = tri[0][0];

    for (int i = 0; i < N-1; ++i)
    {
        for (int j = 0; j <= i; ++j)
        {
            int lsum = std::max(dp[i][j] + tri[i+1][j], dp[i+1][j]);
            int rsum = dp[i][j] + tri[i+1][j+1];

            dp[i+1][j] = lsum;
            dp[i+1][j+1] = rsum;
        }
    }

    int m = 0;
    for (int v: dp[N-1])
    {
        m = std::max(m, v);
    }

    cout << m;
    
    return 0;
}