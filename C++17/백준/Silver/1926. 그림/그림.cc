#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int v, h; cin >> v >> h;

    vector<vector<int>> sq;

    for (int i = 0; i < v; ++i)
    {
        vector<int> ve;
        for (int i = 0; i < h; ++i)
        {
            int t; cin >> t;
            ve.push_back(t);
        }

        sq.push_back(ve);
    }

    bool visited[500][500] = {false};
    queue<pair<int,int>> haveToVisit;

    vector<int> mins;

    for (int i = 0; i < v; ++i)
    {
        for (int j = 0; j < h; ++j)
        {
            if (visited[i][j] == true)
            {
                continue;
            }

            if (sq[i][j] == 1)
            {
                haveToVisit.emplace(i,j);

                int min = 0;

                while (!haveToVisit.empty())
                {
                    //v , h
                    auto p = haveToVisit.front();
                    haveToVisit.pop();

                    if (visited[p.first][p.second] == true)
                    {
                        continue;
                    }

                    visited[p.first][p.second] = true;

                    min++;

                    //up,down,left,right check
                    for (int k = 0; k < 4; ++k)
                    {
                        constexpr int dv[4] = {-1,1,0,0};
                        constexpr int dh[4] = {0,0,-1,1};

                        int movev = p.first + dv[k];
                        int moveh = p.second + dh[k];

                        if (movev < 0 || movev >= v || moveh < 0 || moveh >= h)
                        {
                            continue;
                        }

                        if (visited[movev][moveh] == true)
                        {
                            continue;
                        }

                        if (sq[movev][moveh] == 1)
                        {
                            haveToVisit.emplace(movev, moveh);
                        }
                    }
                }

                mins.push_back(min);
            }
        }
    }

    int max = 0;

    for (auto i : mins)
    {
        max = std::max(max, i);
    }

    cout << mins.size() << "\n" << max;

    return 0;
}