#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N, M;
    cin >> N >> M;

    map<int, vector<int>> connections;

    //init
    for (int i = 0; i < M; ++i)
    {
        int t, t1; cin >> t >> t1;
        if (connections[t].empty())
        {
            connections[t] = vector<int>{t1};
        }
        else
        {
            connections[t].push_back(t1);
        }

        if (connections[t1].empty())
        {
            connections[t1] = vector<int>{t};
        }
        else
        {
            connections[t1].push_back(t);
        }
    }

    queue<pair<int,int>> HaveToVisit;

    map<int, int> humanCount;

    //1~N checking
    for (const pair<const int, vector<int>> cPair : connections)
    {
        int start = cPair.first;
        HaveToVisit.emplace(start, 0);
        set<int> visited;
        
        //1~N까지 갈 수 있는 모든 너비우선탐색 노드 가중치로 돌아버림
        int count = 0;
        while (!HaveToVisit.empty())
        {
            pair<int,int> nodeCount = HaveToVisit.front();
            HaveToVisit.pop();

            if (visited.count(nodeCount.first) == 1)
            {
                continue;
            }
            
            count += nodeCount.second;
            visited.insert(nodeCount.first);

            //start노드에서 이어질 수 있는 모든 노드들 넣기
            for (int connectedNode : connections[nodeCount.first])
            {
                HaveToVisit.emplace(connectedNode, nodeCount.second + 1);
            }
        }

        humanCount[start] = count;
    }

    int minc = 1000000000;
    for (auto pair : humanCount)
    {
        minc = std::min(pair.second, minc);
    }

    for (auto pair : humanCount)
    {
        if (pair.second == minc)
        {
            cout << pair.first;
            return 0;
        }
    }
    
    return 0;
}