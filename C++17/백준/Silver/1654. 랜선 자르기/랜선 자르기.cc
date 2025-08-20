#include "bits/stdc++.h"
using namespace std;

bool BinarySearch(vector<int> &v, int maxValue, int n)
{
    int count = 0;
    for (int i : v)
    {
        count += i / maxValue;
    }

    if (count  < n)
    {
        return false;
    }

    return true;
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int k, n; cin >> k >> n;

    vector<int> cables;
    unsigned int maxValue = 0;

    for (int i = 0; i < k; ++i)
    {
        unsigned int t; cin >> t;
        maxValue = std::max(maxValue, t);
        cables.push_back(t);
    }

    int low = 1;

    int ans = 0;

    while (low <= maxValue)
    {
        int mid = (low + maxValue) / 2;

        
        if (BinarySearch(cables, mid, n))
        {
            ans = mid;
            low = mid + 1;
        }
        else
        {
            maxValue = mid - 1;
        }
    }

    cout << ans;
    
    
    return 0;
}
