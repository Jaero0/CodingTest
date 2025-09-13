#include "bits/stdc++.h"
using namespace std;

int N, M;
int nums[9];
bool IsUsed[9] = {};

void BT(int k)
{
    if (k - 1 == M)
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
        if (IsUsed[i] == false)
        {
            //1
            nums[k] = i;
            //2
            IsUsed[i] = true;
            //3
            BT(k+1);
            //4
            IsUsed[i] = false;
        }
    }
}

int main()
{
    cin >> N >> M;
    BT(1);
    return 0;
}