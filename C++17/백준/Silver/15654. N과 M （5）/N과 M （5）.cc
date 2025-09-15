#include "bits/stdc++.h"
using namespace std;

int N, M;
vector<int> v;
int nums[9];
bool IsUsed[9];

void BT(int k)
{
    if (k == M)
    {
        for (int i = 0; i < M; ++i)
        {
            cout << nums[i] << " ";
        }
        cout << "\n";
        return;
    }

    for (int i = 0; i < N; ++i)
    {
        if (IsUsed[i] == true)
        {
            continue;
        }

        nums[k] = v[i];
        IsUsed[i] = true;
        BT(k+1);
        IsUsed[i] = false;
    }
}

int main()
{
    cin >> N >> M;
    
    for (int i = 0; i < N; ++i)
    {
        int t; cin >> t;
        v.push_back(t);
    }
    sort(v.begin(), v.end());
    
    BT(0);
    return 0;
}