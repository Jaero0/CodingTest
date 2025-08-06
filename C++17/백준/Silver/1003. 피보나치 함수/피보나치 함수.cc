#include <chrono>
#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int input;
    cin >> input;

    vector<int> zero;
    vector<int> one;

    //0일때
    zero.push_back(1);
    one.push_back(0);

    //1
    zero.push_back(0);
    one.push_back(1);

    int max = 2;
    for (int i = 0; i < input; ++i)
    {
        int c; cin >> c;

        for (max; max < c + 1; ++max)
        {
            int z1 = zero[max-1];
            int z2 = zero[max-2];
            int o1 = one[max-1];
            int o2 = one[max-2];

            zero.push_back(z1 + z2);
            one.push_back(o1 + o2);
        }

        cout << zero[c] << " " << one[c] << "\n";
    }

    return 0;
}
