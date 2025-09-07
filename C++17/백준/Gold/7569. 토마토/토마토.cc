#include "bits/stdc++.h"
using namespace std;

constexpr int dx[6] = {1,-1,0,0,0,0};
constexpr int dy[6] = {0,0,1,-1,0,0};
constexpr int dz[6] = {0,0,0,0,1,-1};

struct Triple
{
    int Z;
    int Y;
    int X;

private:
    Triple(int z, int y, int x) : Z(z), Y(y), X(x) {}

public:
    static Triple make_triple(int z, int y, int x)
    {
        return Triple(z, y, x);
    }
};

int main()
{
    int N,M,H; cin >> M >> N >> H;

    vector<vector<vector<int>>> plate_3d(H, vector<vector<int>>(N, vector<int>(M, -1)));

    queue<pair<Triple, int>> tomato;

    for (int i = 0; i < H; ++i)
    {
        for (int j = 0; j < N; ++j)
        {
            for (int k = 0; k < M; ++k)
            {
                int t; cin >> t;

                plate_3d[i][j][k] = t;
                
                if (t == 1)
                {
                    tomato.push(make_pair(Triple::make_triple(i,j,k), 1));
                }
            }
        }
    }

    while (!tomato.empty())
    {
        auto p = tomato.front();
        tomato.pop();

        Triple node = p.first;
        int score = p.second;

        //초기값, 0인 자리 제외하고 모두 continue
        if (1 < plate_3d[node.Z][node.Y][node.X] || plate_3d[node.Z][node.Y][node.X] < 0)
        {
            continue;
        }

        plate_3d[node.Z][node.Y][node.X] = score;

        for (int move = 0; move < 6; ++move)
        {
            int mz = node.Z + dz[move];
            int my = node.Y + dy[move];
            int mx = node.X + dx[move];

            if (mz < 0 || my < 0 || mx < 0 || mz >= H || my >= N || mx >= M)
            {
                continue;
            }

            if (plate_3d[mz][my][mx] != 0)
            {
                continue;
            }

            tomato.push(make_pair(Triple::make_triple(mz,my,mx), score + 1));
        }
    }

    int maxCount = 0;
    bool isBroken = false;
    
    for (int i = 0; i < H; ++i)
    {
        for (int j = 0; j < N; ++j)
        {
            for (int k = 0; k < M; ++k)
            {
                if (plate_3d[i][j][k] == 0)
                {
                    isBroken = true;
                    break;
                }

                maxCount = max(plate_3d[i][j][k], maxCount);
            }

            if (isBroken)
            {
                break;
            }
        }

        if (isBroken)
        {
            break;
        }
    }

    cout << (isBroken ? -1 : maxCount - 1);
    
    return 0;
}
