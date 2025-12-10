#include <bits/stdc++.h>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int sum; cin >> sum;

    for (int i = 1; i <= sum; ++i)
    {
        int temp = i;

        if (i < 10)
        {
            temp += i;
        }
        else if (i < 100)
        {
            temp += i / 10 + i % 10;
        }
        else if (i < 1000)
        {
            temp += i / 100 + i % 100 / 10 + i % 10;
        }
        else if (i < 10000)
        {
            temp += i / 1000 + i % 1000 / 100 + i % 100 / 10 + i % 10;
        }
        else if (i < 100000)
        {
            temp += i / 10000 + i % 10000 / 1000 + i % 1000 / 100 + i % 100 / 10 + i % 10;
        }
        else if (i < 1000000)
        {
            temp += i / 100000 + i % 100000 / 10000 + i % 10000 / 1000 + i % 1000 / 100 + i % 100 / 10 + i % 10;
        }
        else // 100만
        {
            temp += 1;
        }

        if (temp == sum)
        {
            cout << i;
            return 0;
        }
    }

    cout << 0;
    return 0;
}
