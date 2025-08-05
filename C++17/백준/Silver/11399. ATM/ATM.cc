#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    vector<int> v;
    for (int i = 0; i < c; ++i)
    {
        int t; cin >> t;
        v.push_back(t);
    }

    std::sort(v.begin(), v.end());

    int total = 0;

    for (int i = 0; i < c; ++i)
    {
        for (int j = 0; j <= i; ++j)
        {
            total += v[j];
        }
    }

    cout << total;
    
    return 0;
}
