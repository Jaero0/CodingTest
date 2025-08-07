#include "bits/stdc++.h"
using namespace std;

int main()
{
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);

    int c, c1; std:: cin >> c >> c1;

    set<string> set;

    for (int i = 0; i < c; ++i)
    {
        string t; cin >> t;

        set.insert(t);
    }

    int count = 0;

    for (int i = 0; i < c1; ++i)
    {
        string t; cin >> t;

        if (set.count(t))
        {
            count++;
        }
    }

    std::cout << count;

    return 0;
}
