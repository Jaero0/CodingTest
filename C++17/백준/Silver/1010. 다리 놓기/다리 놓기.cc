#include <unordered_map>

#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c;
    cin >> c;

    int arr[30][30] {0};

    arr [0][0] = 1;
    for (int n = 0; n < 30; ++n)
    {
        for (int m = 0; m < 30; ++m)
        {
            if (n == 0)
            {
                arr[n][m] = m+1;
            }
            else
            {
                if (m < n)
                {
                    continue;
                }

                arr[n][m] = arr[n-1][m-1] + arr[n][m-1];
            }
        }
    }

    for (int i = 0; i < c; ++i)
    {
        int n, m; cin >> n >> m;

        cout << arr[n-1][m-1] << "\n";
    }

    return 0;
}
