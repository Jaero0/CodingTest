#include "bits/stdc++.h"
using namespace std;

constexpr int dx[4] = {-1,1,0,0};
constexpr int dy[4] = {0,0,1,-1};

int main()
{
    int M, N; cin >> M >> N;

    vector<pair<int,int>> doneToma;
    vector<vector<int>> plate(N, vector<int>(M, -1));

    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < M; ++j)
        {
            int t; cin >> t;
            if (t == 1)
            {
                doneToma.emplace_back(i,j);
            }

            plate[i][j] = t;
        }
    }

    queue<pair<pair<int,int>, int>> HaveToVisit;

    for (auto t : doneToma)
    {
        auto p = make_pair(t.first, t.second);
        HaveToVisit.emplace(p, 1);
    }

    while (!HaveToVisit.empty())
    {
        auto fNode_sCount = HaveToVisit.front();
        HaveToVisit.pop();

        auto fNode = fNode_sCount.first;
        int y = fNode.first;
        int x = fNode.second;
        int count = fNode_sCount.second;

        if (plate[y][x] > 1 || plate[y][x] == -1)
        {
            continue;
        }

        plate[y][x] = count;

        for (int move = 0; move < 4; ++move)
        {
            int my = y + dy[move];
            int mx = x + dx[move];

            if (my < 0 || my >= N || mx < 0 || mx >= M || plate[my][mx] > 0 || plate[my][mx] == -1)
            {
                continue;
            }

            auto p = make_pair(my,mx);
            HaveToVisit.emplace(p, count + 1);
        }
    }

    bool isZeroCounted = false;
    int max = 0;

    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < M; ++j)
        {
            if (plate[i][j] == 0)
            {
                isZeroCounted = true;
                break;
            }

            if (plate[i][j] == -1)
            {
                continue;
            }

            max = std::max(max, plate[i][j]);
        }

        if (isZeroCounted == true)
        {
            break;
        }
    }

    cout << (isZeroCounted == true ? -1 : max - 1);
    
    return 0;
}