#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    
    int N, M; cin >> N >> M;

    vector<vector<int>> v(N, vector<int>(N));

    for (int i = 0; i < N; ++i)
    {
        int sum = 0;
        for (int j = 0; j < N; ++j)
        {
            int t; cin >> t;
            sum += t;
            v[i][j] = sum;
        }
    }

    for (int i = 0; i < M; ++i)
    {
        int x1,y1,x2,y2; cin >> x1>>y1>>x2>>y2;

        int sum = 0;
        int minus = 0;
        for (int j = x1 - 1; j <= x2 - 1; ++j)
        {
            sum += v[j][y2-1];
            
            if (y1 -2 >= 0)
            {
                minus += v[j][y1-2];
            }
        }

        cout << sum - minus << "\n";
    }
    
    return 0;
}