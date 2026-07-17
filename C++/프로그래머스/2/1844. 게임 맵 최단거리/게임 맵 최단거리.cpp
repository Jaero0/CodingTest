#include<vector>
#include<queue>
#include<unordered_map>
#include<algorithm>
#include<iostream>

using namespace std;

const int xm[] = {-1,1,0,0};
const int ym[] = {0,0,-1,1};

struct S
{
public:
    pair<int, int> xy;
    int count;
    
    S(pair<int, int> xy, int c) : xy(xy), count(c) {}
};

int solution(vector<vector<int> > maps)
{
    int answer = -1;
    
    int maxX = maps[0].size();
    int maxY = maps.size();
    
    S s({0, 0}, 1);
    
    queue<S> q;
    q.push(s);
    vector<vector<bool>> visited(maxY, vector<bool>(maxX, false));
    visited[0][0] = 1;
    
    while(!q.empty())
    {
        S s = q.front();
        q.pop();
        
        auto xy = s.xy;
        int x = xy.second;
        int y = xy.first;
        int cnt = s.count;
        
        for(int i = 0; i < 4; i++)
        {
            int mx = x + xm[i];
            int my = y + ym[i];
            
            if(mx < 0 || mx >= maxX || my < 0 || my >= maxY) continue;
            if(maps[my][mx] == 0) continue;
            if(visited[my][mx]) continue;
            
            if(mx == maxX - 1 && my == maxY - 1)
            {
                return cnt + 1;
            }
            
            q.push({make_pair(my,mx), cnt + 1});
            visited[my][mx] = true;
        }
    }
    
    return answer;
}