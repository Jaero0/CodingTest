#include "bits/stdc++.h"

int main()
{
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);

    int sC; std::cin >> sC;

    std::set<int> sanggeun;
    for (int i = 0; i < sC; ++i)
    {
        int t; std::cin >> t;
        sanggeun.insert(t);
    }

    int c; std::cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int t; std::cin >> t;
        if (sanggeun.find(t) != sanggeun.end())
        {
            std::cout << 1 << " ";
            continue;
        }

        std::cout << 0 << " ";
    }

    return 0;
}
