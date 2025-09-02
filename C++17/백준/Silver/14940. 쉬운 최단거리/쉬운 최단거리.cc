#include "bits/stdc++.h"
using namespace std;

constexpr int dx[4] = {-1, 1, 0, 0};
constexpr int dy[4] = {0, 0, 1, -1};
int main()
{
    int N, M; cin >> N >> M;

    vector<vector<int>> map(N, vector<int>(M));

    pair<int, int> goalNode;
    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < M; ++j)
        {
            int t; cin >> t;

            if (t == 2)
            {
                goalNode = make_pair(i, j);
            }

            map[i][j] = t;
        }
    }

    queue<pair<pair<int,int>,int>> HaveToVisit;
    HaveToVisit.emplace(goalNode, 0);

    vector<vector<bool>> visited(N, vector<bool>(M, false));
    vector<vector<int>> finishMap(N, vector<int>(M, -1));

    while (!HaveToVisit.empty())
    {
        //first = node, second = count
        auto fNode_sCount = HaveToVisit.front();
        HaveToVisit.pop();

        //각 y,x와 [y][x]로 가기위한 count수
        auto fNode = fNode_sCount.first;
        int y = fNode.first;
        int x = fNode.second;
        int sCount = fNode_sCount.second;

        //방문한 노드일때는 건너뛰기
        if (visited[y][x] == true)
        {
            continue;
        }
        //아닐땐 방문한노드에 추가
        visited[y][x] = true;
        //최종 결과 행렬에 현재 [y][x]노드까지 올 수있는 count추가
        finishMap[y][x] = sCount;

        //[y][x]에 상하좌우로 움직일 수 있는 노드 모두 판별
        for (int move = 0; move < 4; ++move)
        {
            int my = y + dy[move];
            int mx = x + dx[move];

            if (my < 0 || my >= N || mx < 0 || mx >= M || visited[my][mx] == true)
            {
                continue;
            }

            //주의! [my][mx]노드로 움직일 수 있지만, 기존 행렬에서 [my][mx] == 0인경우는 바로 방문노드에 추가하고, 0으로 최종 행렬에 초기화
            if (map[my][mx] == 0)
            {
                finishMap[my][mx] = 0;
                visited[my][mx] = true;
                continue;
            }

            //위의 조건 모두 아닌경우 방문해야할 노드에 [my][mx]추가, [y][x]까지 올 수 있는 count +1 값을 count로 추가
            auto moveNode = make_pair(my,mx);
            HaveToVisit.emplace(moveNode, sCount + 1);
        }
    }

    //위 방법으로 초기화를 하면
    /**
     * 0 0 0 0
     * 0 0 0 1
     * 인 경우, [0][2], [0][3], [1][1], [1][2], [1][3]이 0임에도 불구하고 -1이 됨
     * -> 상하좌우가 0인경우 HaveToVisit큐에 노드가 추가되지 않음 (주의! 부분 참고)
     * 따라서 기존 행렬에서 0인 값은 0으로 처리해주고,
     * 그 외의값은 행렬에서 갈 수 있는 노드로 되어있지만 도달 할 수없으므로 -1로 처리
     */
    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < M; ++j)
        {
            int num = finishMap[i][j];
            int consoleNum = num < 0 ? (map[i][j] == 0 ? 0 : -1) : num;

            cout << consoleNum << " ";
        }
        cout << "\n";
    }
    
    return 0;
}