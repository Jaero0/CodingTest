#include <unordered_set>
#include <bits/stdc++.h>

int main()
{
    std::ios_base::sync_with_stdio(false);
    std::cin.tie(nullptr);

    int c; std::cin >> c;

    std::vector<int> sorted;
    std::vector<int> original;
    
    for (int i = 0; i < c; ++i)
    {
        int t; std::cin >> t;
        sorted.push_back(t);
        original.push_back(t);
    }

    std::sort(sorted.begin(), sorted.end());

    std::map<int, int> map;

    int idx = 1;
    for (int i : sorted)
    {
        if (map[i] < 1)
        {
            map[i] = idx;
            idx++;
        }
    }

    for (int i : original)
    {
        std::cout << map[i] - 1 << " ";
    }
    
    return 0;
}
