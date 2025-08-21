#include "bits/stdc++.h"
using namespace std;

void FindSquare(vector<vector<int>> &square, int y, int x, int squareSize, map<string, int> &whiteBlueMap)
{
    int firstColor = square[y][x];
    bool isBreak = false;

    for (int ny = y; ny < y + squareSize; ++ny)
    {
        for (int nx = x; nx < x + squareSize; ++nx)
        {
            if (square[ny][nx] != firstColor)
            {
                isBreak = true;
                break;
            }
        }

        if (isBreak)
        {
            break;
        }
    }

    if (isBreak)
    {
        int half = squareSize / 2;

        //4등분
        //1
        FindSquare(square, y, x, half, whiteBlueMap);
        //2
        FindSquare(square, y, x + half, half, whiteBlueMap);
        //3
        FindSquare(square, y + half, x, half, whiteBlueMap);
        //4
        FindSquare(square, y + half, x + half, half, whiteBlueMap);
    }
    //등분된 사각형이 전부 1일때
    else if (firstColor == 1)
    {
        whiteBlueMap["blue"] ++;
    }
    else if (firstColor == 0)
    {
        whiteBlueMap["white"] ++;
    }
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    vector<vector<int>> sq;

    for (int i = 0; i < c; ++i)
    {
        vector<int> v;
        for (int j = 0; j < c; ++j)
        {
            int t; cin >> t;
            v.push_back(t);
        }

        sq.push_back(v);
    }

    map<string, int> whiteBlueMap = {{"white", 0}, {"blue", 0}};

    FindSquare(sq, 0, 0, c,whiteBlueMap);

    cout << whiteBlueMap["white"] << "\n" << whiteBlueMap["blue"];
    
    return 0;
}
