#include "bits/stdc++.h"
using namespace std;

int main()
{
    int T; cin >> T;

    for (int i = 0; i < T; ++i)
    {
        int t; cin >> t;

        multiset<int> ms;

        for (int j = 0; j < t; ++j)
        {
            string st; cin >> st;
            int it; cin >> it;

            if (st == "I")
            {
                ms.insert(it);
                continue;
            }

            if (ms.empty())
            {
                continue;
            }

            if (it == 1)
            {
                ms.erase(--ms.end());
                continue;
            }

            ms.erase(ms.begin());
        }

        if (ms.empty())
        {
            cout << "EMPTY" << "\n";
            continue;
        }

        cout << *--ms.end() << " " << *ms.begin() << "\n";
    }

    return 0;
}
