#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int count = 0;
    cin >> count;

    for (int i = 0; i < count; ++i)
    {
        int h, w, p = 0;
        cin >> h >> w >> p;

        int side = p / h;
        int height = p % h;

        if (height == 0)
        {
            cout << h * 100 + side << '\n';
            continue;
        }

        cout << height * 100 + side + 1 << '\n';
    }

    return 0;
}