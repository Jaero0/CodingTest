#include "bits/stdc++.h"
using namespace std;

int N, M;
int nums[9];

void BT(int k)
{
    if (k == M + 1)
    {
        for (int i = 1; i <= M; ++i)
        {
            cout << nums[i] << " ";
        }
        cout << "\n";
        return;
    }

    for (int i = 1; i <= N; ++i)
    {
        if (nums[k - 1] > i)
        {
            continue;
        }
        nums[k] = i;
        BT(k+1);
    }
}

int main()
{
    cin >> N >> M;
    BT(1);
    return 0;
}