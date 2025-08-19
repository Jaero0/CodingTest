#include "bits/stdc++.h"
using namespace std;

constexpr int dv[4] = {-1, 1, 0, 0};
constexpr int dh[4] = {0, 0, -1, 1};

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int v, h;
    cin >> v >> h;

    vector<vector<int>> sq(v, vector<int>(h));

    for (int i = 0; i < v; ++i) {
        for (int j = 0; j < h; ++j) {
            cin >> sq[i][j];
        }
    }

    vector<vector<bool>> visited(v, vector<bool>(h, false));
    queue<pair<int, int>> haveToVisit;

    int componentCount = 0;
    int maxSize = 0;

    for (int i = 0; i < v; ++i)
    {
        for (int j = 0; j < h; ++j)
        {
            //조건 안맞는거 전부 거르기
            if (sq[i][j] == 0 || visited[i][j] == true)
            {
                continue;
            }

            componentCount++;
            int componentSize = 0;
            
            haveToVisit.emplace(i, j);

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
                componentSize++;

                //up,down,left,right check
                for (int k = 0; k < 4; ++k)
                {
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

            maxSize = std::max(componentSize, maxSize);
        }
    }

    cout << componentCount << "\n" << maxSize;
    
    return 0;
}