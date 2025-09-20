#include "bits/stdc++.h"
using namespace std;

int main()
{
    int64_t N, M; cin >> N >> M;

    queue<pair<int, int>> HaveToVisit;
    HaveToVisit.emplace(N,1);
    
    bool b = false;
    int c = 0;

    if (N == M)
    {
        cout << 1;
        return 0;
    }

    while (!HaveToVisit.empty())
    {
        auto node = HaveToVisit.front();
        int num = node.first;
        int count = node.second;
        HaveToVisit.pop();
        

        int mul = num * 2;
        int64_t p1 = static_cast<int64_t>(num) * 10 + 1;

        if (p1 == M || mul == M)
        {
            b = true;
            c = count + 1;
            break;
        }

        if (mul < M)
        {
            HaveToVisit.emplace(mul, count + 1);
        }
        
        if (p1 < M)
        {
            HaveToVisit.emplace(p1, count + 1);
        }
    }

    cout << (b == true ? c : -1);
    
    return 0;
}