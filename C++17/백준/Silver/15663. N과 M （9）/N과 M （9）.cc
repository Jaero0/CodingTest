#include "bits/stdc++.h"
using namespace std;

int N, M;
vector<short> nums;
bool used[9];

void BT(short k, vector<short>& v)
{
    if (k == M)
    {
        for (short i = 0; i < M; ++i)
        {
            cout << v[i] << " ";
        }
        
        cout << "\n";
        return;
    }

    
    for (short i = 0; i < N; ++i)
    {
        if (used[i] == true)
        {
            continue;
        }
        if (i > 0 && nums[i] == nums[i-1] && !used[i-1]) continue;

        v[k] = nums[i];
        used[i] = true;
        BT(k+1, v);
        used[i] = false;
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

    BT(0, v);
    
    return 0;
}