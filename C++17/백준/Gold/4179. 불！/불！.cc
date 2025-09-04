#include "bits/stdc++.h"
using namespace std;

constexpr int dx[4] = {-1, 1, 0, 0};
constexpr int dy[4] = {0, 0, 1, -1};

enum CONSTS
{
    WALL = -1,
    PATH = 0,
    N_J = 100,
    N_F = 268435456
};

int main()
{
    int R, C;
    cin >> R >> C;
    cin.ignore();

    //-1: wall, 0: path, 100: J, 200: F
    vector<vector<int>> maze(R, vector<int>(C));

    pair<int, int> J_Point;
    vector<pair<int, int>> F_Points;

    //init
    for (int i = 0; i < R; ++i)
    {
        string ts;
        std::getline(cin, ts);

        for (int j = 0; j < C; ++j)
        {
            char t = ts[j];

            if (t == '#')
            {
                maze[i][j] = WALL;
                continue;
            }

            if (t == '.')
            {
                maze[i][j] = PATH;
                continue;
            }

            if (t == 'J')
            {
                maze[i][j] = N_J;
                J_Point = make_pair(i, j);
                continue;
            }

            maze[i][j] = N_F;
            F_Points.emplace_back(i, j);
        }
    }

    //bfs prepare
    queue<pair<int, int>> HaveToVisit;
    HaveToVisit.push(J_Point);
    for (auto p : F_Points) HaveToVisit.push(p);
    vector<vector<bool>> J_Visited(R, vector<bool>(C, false));
    vector<vector<bool>> Fs_Visited(R, vector<bool>(C, false));
    vector<vector<int>> scores(R, vector<int>(C));
    scores[J_Point.first][J_Point.second] = 100;
    bool bJ_Win = false;
    int WinScore = 0;

    //bfs
    while (!HaveToVisit.empty() && bJ_Win == false)
    {
        auto node = HaveToVisit.front();
        HaveToVisit.pop();

        int y = node.first;
        int x = node.second;
        int player = maze[y][x];

        //무한루프 방지로직
        if (player == N_J)
        {
            if (J_Visited[y][x] == true)
            {
                continue;
            }

            J_Visited[y][x] = true;
        }
        else if (player == N_F)
        {
            if (Fs_Visited[y][x] == true)
            {
                continue;
            }
            Fs_Visited[y][x] = true;
        }

        //search
        for (int i = 0; i < 4; ++i)
        {
            int my = y + dy[i];
            int mx = x + dx[i];

            //Fire일때
            if (player == N_F)
            {
                //벽에 막히거나 OutOfRange일때
                if (my < 0 || mx < 0 || my >= R || mx >= C || maze[my][mx] == WALL || maze[my][mx] == N_F)
                {
                    continue;
                }

                //N_J위에 덮어씌우기
                maze[my][mx] = N_F;
                HaveToVisit.emplace(my, mx);
                continue;
            }

            //J일때
            //빠져나오면 승리
            if (mx < 0 || my < 0 || mx >= C || my >= R)
            {
                bJ_Win = true;
                WinScore = scores[y][x] + 1 - static_cast<int>(N_J); //현재 포인트 + 1 - 100 = 탈출
                break;
            }

            //길이 아니면 건너뛰기
            if (maze[my][mx] != PATH)
            {
                continue;
            }

            //추가
            maze[my][mx] = N_J;
            scores[my][mx] = scores[y][x] + 1;
            HaveToVisit.emplace(my, mx);
        }
    }

    if (bJ_Win == true)
    {
        cout << WinScore;
    }
    else
    {
        cout << "IMPOSSIBLE";
    }

    return 0;
}
