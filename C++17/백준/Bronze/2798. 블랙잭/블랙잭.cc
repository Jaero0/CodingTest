#include <bits/stdc++.h>

int main() {
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);

    int c, score; std::cin >> c >> score;

    std::vector<int> vec(c);

    for (int i = 0; i < c; ++i)
    {
        int t; std::cin >> t;
        vec[i] = t;
    }

    int max = 0;
    
    for (int i = 0; i < c-2; ++i)
    {
        for (int j = i + 1; j < c - 1; ++j)
        {
            for (int k = j + 1; k < c; ++k)
            {
                if (vec[i] + vec[j] + vec[k] > score)
                {
                    continue;
                }

                max = std::max(max, vec[i] + vec[j] + vec[k]);
            }
        }
    }

    std::cout << max;
    
    return 0;
}
