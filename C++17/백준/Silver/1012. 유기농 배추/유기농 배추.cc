#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int M, N, Baechu; cin >> M >> N>> Baechu;

        bool field[50][50] = {false};

        for (int i = 0; i < Baechu; ++i)
        {
            int t, t1; cin >> t >> t1;

            field[t][t1] = true;
        }

        stack<pair<int,int>> HaveToVisit;
        bool visited[50][50] = {false};
        set<pair<int,int>> visitedNode;

        int BaechuWormCount = 0;

        for (int i = 0; i < M; ++i)
        {
            for (int j = 0; j < N; ++j)
            {
                if (field[i][j] == true && visited[i][j] == false)
                {
                    BaechuWormCount++;
                    HaveToVisit.emplace(i,j);
                    visitedNode.insert(make_pair(i,j));
                    visited[i][j] = true;
                    
                    while (!HaveToVisit.empty())
                    {
                        auto cur = HaveToVisit.top();
                        HaveToVisit.pop();

                        for (int dir = 0; dir < 4; ++dir)
                        {
                            //up,down,left,right
                            constexpr int dy[4] = {0, 0, -1, 1};
                            constexpr int dx[4] = {-1, 1, 0, 0};
                            
                            int newH = cur.first + dx[dir];
                            int newV = cur.second + dy[dir];

                            //범위 벗어나면 체킹안함
                            if (newH < 0 || newH >= 50 || newV < 0 || newV >= 50) continue;

                            auto next = make_pair(newH, newV);

                            // visitedNode check == false
                            if (visitedNode.count(next) == 0)
                            {
                                visitedNode.insert(next);

                                // field == true && visited == false
                                if (field[newH][newV] == true && visited[newH][newV] == false)
                                {
                                    HaveToVisit.push(next);
                                    visited[newH][newV] = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        cout << BaechuWormCount << "\n";
    }
    
    return 0;
}
