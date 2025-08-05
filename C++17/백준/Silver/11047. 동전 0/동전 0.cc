#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int c, total; cin >> c >> total;

    vector<int> v;
    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;

        v.push_back(t);
    }

    int count = 0;

    for (int i = c - 1; i >= 0; --i)
    {
        if (v[i] > total)
        {
            continue;
        }

        while (true)
        {
            if (total - v[i] < 0)
            {
                break;
            }
            total -= v[i];
            count++;
        }
    }

    cout << count;
    
    return 0;
}
