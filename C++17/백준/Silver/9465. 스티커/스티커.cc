#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N; cin >> N;

    for (int i = 0; i < N; ++i)
    {
        int row; cin >> row;

        vector<vector<int>> sticker(2, vector<int>(row));
        vector<vector<int>> dp(2, vector<int>(row));

        for (int i = 0; i < row * 2; ++i)
        {
            cin >> sticker[i/row][i%row];
        }

        dp[0][0] = sticker[0][0];
        dp[1][0] = sticker[1][0];
        
        if (row > 1) {
            dp[0][1] = dp[1][0] + sticker[0][1];
            dp[1][1] = dp[0][0] + sticker[1][1];
        }

        for (int i = 2; i < row; ++i) {
            dp[0][i] = max(dp[1][i-1], dp[1][i-2]) + sticker[0][i];
            dp[1][i] = max(dp[0][i-1], dp[0][i-2]) + sticker[1][i];
        }

        cout << max(dp[0][row-1], dp[1][row-1]) << "\n";
    }
    
    return 0;
}