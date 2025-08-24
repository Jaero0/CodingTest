#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N, M;
    cin >> N >> M;

    //개행문자 버리기
    cin.ignore();

    char cam[601][601];
    
    pair<int,int> DoYeonPos;
    
    for (int i = 0; i < N; ++i)
    {
        string t;
        getline(cin, t);
        
        for (int j = 0; j < M; ++j)
        {
            cam[i][j] = t[j];

            if (t[j] == 'I')
            {
                DoYeonPos = make_pair(i,j);
            }
        }
    }

    queue<pair<int,int>> HaveToVisit;
    bool visited[601][601] = {false};

    const int dx[4] = {-1, 1, 0, 0};
    const int dy[4] = {0, 0, -1, 1};
    
    HaveToVisit.push(DoYeonPos);

    int MeetCount = 0;
    
    while (!HaveToVisit.empty())
    {
        auto VisitingPair = HaveToVisit.front();
        HaveToVisit.pop();

        int y = VisitingPair.first;
        int x = VisitingPair.second;
        
        if (visited[y][x] == true)
        {
            continue;
        }

        if (cam[y][x] == 'P')
        {
            MeetCount++;
        }

        visited[y][x] = true;

        for (int i = 0; i < 4; ++i)
        {
            int ny = y + dy[i];
            int nx = x + dx[i];
            if (nx < 0 || nx >= M || ny < 0 || ny >= N)
            {
                continue;
            }

            if (cam[ny][nx] == 'X')
            {
                visited[ny][nx] = true;
                continue;
            }
            
            HaveToVisit.emplace(ny,nx);
        }
        
    }

    if (MeetCount > 0)
    {
        cout << MeetCount;
    }
    else
    {
        cout << "TT";
    }
    
    
    return 0;
}