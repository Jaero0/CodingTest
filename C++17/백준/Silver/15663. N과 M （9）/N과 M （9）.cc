#include "bits/stdc++.h"
using namespace std;

int N, M;
vector<short> nums;
bool used[9];
set<string> se;

void BT(short k, vector<short>* v)
{
    if (k == M)
    {
        string s;
        for (short i = 0; i < M; ++i)
        {
            s += to_string((*v)[i]) + " ";
        }

        if (se.count(s) == 1)
        {
            return;
        }

        se.insert(s);
        cout << s << "\n";
        return;
    }

    
    for (short i = 0; i < N; ++i)
    {
        if (used[i] == true)
        {
            continue;
        }

        (*v)[k] = nums[i];
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

    BT(0, &v);
    
    return 0;
}