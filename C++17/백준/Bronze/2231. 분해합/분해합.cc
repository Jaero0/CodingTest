#include <bits/stdc++.h>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int sum; cin >> sum;

    for (int i = 1; i <= sum; ++i)
    {
        int temp = i;
        int copy = i;

        while (copy != 0)
        {
            temp += copy % 10;
            copy /= 10;
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
