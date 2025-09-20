#include "bits/stdc++.h"
using namespace std;

int main()
{
    int64_t N, M; cin >> N >> M;

    queue<pair<int64_t, int>> HaveToVisit;
    HaveToVisit.emplace(N,1);
    map<int64_t,bool> visited;
    visited[N] = true;
    
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
        int64_t num = node.first;
        int count = node.second;
        HaveToVisit.pop();
        

        int64_t mul = num * 2;
        int64_t p1 = num * 10 + 1;

        if (p1 == M || mul == M)
        {
            b = true;
            c = count + 1;
            break;
        }

        if (mul < M && visited[mul] == false)
        {
            HaveToVisit.emplace(mul, count + 1);
        }
        
        if (p1 < M && visited[p1] == false)
        {
            HaveToVisit.emplace(p1, count + 1);
        }
    }

    cout << (b == true ? c : -1);
    
    return 0;
}