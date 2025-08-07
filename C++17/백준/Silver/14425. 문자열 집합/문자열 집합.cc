#include "bits/stdc++.h"

int main()
{
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);

    int c, c1; std:: cin >> c >> c1;

    std::map<std::string, int> map;

    for (int i = 0; i < c; ++i)
    {
        std::string ch; std::cin >> ch;

        map[ch] = i + 100;
    }

    int count = 0;
    for (int i = 0; i < c1; ++i)
    {
        std::string temp; std::cin >> temp;
        if (map[temp] > 1)
        {
            count++;
        }
    }

    std::cout << count;

    return 0;
}
