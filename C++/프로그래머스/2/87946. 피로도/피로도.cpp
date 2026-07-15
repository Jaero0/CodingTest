#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int answer = 0;
bool visited[8];

void dfs(int fatigue, int cnt, vector<vector<int>>& dungeons)
{
    // 지금까지 탐험한 개수 갱신
    answer = max(answer, cnt);

    for (int i = 0; i < dungeons.size(); i++)
    {
        // 이미 방문한 던전이면 패스
        if (visited[i])
            continue;

        // 최소 필요 피로도가 부족하면 패스
        if (fatigue < dungeons[i][0])
            continue;

        visited[i] = true;

        dfs(fatigue - dungeons[i][1], cnt + 1, dungeons);

        visited[i] = false;
    }
}

int solution(int k, vector<vector<int>> dungeons)
{
    dfs(k, 0, dungeons);
    return answer;
}