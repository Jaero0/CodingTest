#include <bits/stdc++.h>


int main()
{
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);
    std::cout.tie(nullptr);

    int a, b; std::cin >> a >> b;

    std::map<int, int> A;
    std::map<int, int> B;
    
    for (int i = 0; i < a; ++i)
    {
        int t; std::cin >> t;
        A[t] = 100;
    }
    for (int i = 0; i < b; ++i)
    {
        int t; std::cin >> t;
        B[t] = 100;
    }

    int total = A.size() + B.size();
    
    for (std::pair<int, int> a1 : A)
    {
        if (B[a1.first] > 1)
        {
            total--;
        }
    }

    for (std::pair<int, int> b1 : B)
    {
        if (b1.second == 0)
        {
            continue;
        }
        if (A[b1.first] > 1)
        {
            total--;
        }
    }

    std::cout << total;
    
    return 0;
}
