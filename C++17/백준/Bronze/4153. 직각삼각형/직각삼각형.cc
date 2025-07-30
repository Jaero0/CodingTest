#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    int a[3];

    while (true)
    {
        cin >> *(a) >> *(a + 1) >> *(a + 2);

        if (*a == 0 && *(a + 1) == 0 && *(a + 2) == 0)
        {
            break;
        }

        sort(a, a + 3);

        if (a[0] * a[0] + a[1] * a[1] == a[2] * a[2]) cout << "right" << "\n";
        else cout << "wrong" << "\n";
    }

    cout << endl;

    return 0;
}