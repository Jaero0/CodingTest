#include "bits/stdc++.h"
using namespace std;

int N, M;
vector<short> nums;
map<short, short> used;

void BT(int k, vector<short>& v)
{
    if (k == M + 1)
    {
        for (int i = 1; i <= M; ++i)
        {
            cout << v[i] << " ";
        }
        cout << "\n";
        return;
    }

    for (int i = 0; i < N; ++i)
    {
        if (v[k - 1] > nums[i])
        {
            continue;
        }

        if (i != 0 && nums[i-1] == nums[i])
        {
            continue;
        }

        v[k] = nums[i];
        BT(k+1, v);
        v[k] = 0;
    }
}

int main()
{
    cin >> N >> M;

    vector<short> v(N + 1);

    for (short i = 0; i < N; ++i)
    {
        short t; cin >> t;
        nums.push_back(t);
    }

    sort(begin(nums), end(nums));

    BT(1, v);
    
    return 0;
}