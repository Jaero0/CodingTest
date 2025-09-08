#include "bits/stdc++.h"
using namespace std;

constexpr int dx[4] = {1,-1,0,0};
constexpr int dy[4] = {0,0,1,-1};
int N;

#define R 0
#define G 1
#define B 2

int BFS(vector<vector<int>> RGB_Board)
{
    queue<pair<int,int>> HaveToVisit;
    vector<vector<bool>> Visited(N, vector<bool>(N, false));

    int count = 0;
    
    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < N; ++j)
        {
            if (Visited[i][j] == true)
            {
                continue;
            }

            count++;
            
            HaveToVisit.emplace(i,j);
            int COLOR = RGB_Board[i][j];

            while (!HaveToVisit.empty())
            {
                auto node = HaveToVisit.front();
                HaveToVisit.pop();

                int y = node.first;
                int x = node.second;

                if (Visited[y][x] == true)
                {
                    continue;
                }

                Visited[y][x] = true;

                for (int k = 0; k < 4; ++k)
                {
                    int my = y + dy[k];
                    int mx = x + dx[k];

                    if (my < 0 || mx < 0 || my >= N || mx >= N)
                    {
                        continue;
                    }

                    if (Visited[my][mx] == true)
                    {
                        continue;
                    }

                    if (RGB_Board[my][mx] != COLOR)
                    {
                        continue;
                    }

                    HaveToVisit.emplace(my,mx);
                }
            }
        }
    }

    return count;
}

int main()
{
    cin >> N;

    vector<vector<int>> RGB_Board;
    vector<vector<int>> RGB_ColorBlind;

    for (int i = 0; i < N; ++i)
    {
        string t; cin >> t;
        vector<int> vt;
        vector<int> vtcb;

        for (char c_t : t)
        {
            if (c_t == 'R')
            {
                vt.push_back(R);
                vtcb.push_back(R);
            }
            else if (c_t == 'G')
            {
                vt.push_back(G);
                vtcb.push_back(R);
            }
            else
            {
                vt.push_back(B);
                vtcb.push_back(B);
            }
        }

        RGB_Board.push_back(vt);
        RGB_ColorBlind.push_back(vtcb);
    }

    int nocb = BFS(RGB_Board);
    int cb = BFS(RGB_ColorBlind);

    cout << nocb << " " << cb;
    

    return 0;
}
