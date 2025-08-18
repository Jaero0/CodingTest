#include "bits/stdc++.h"
using namespace std;

void DFS(map<int, vector<int>> &m, int startNode, set<int> &visitedNode)
{
    visitedNode.insert(startNode);
    cout << startNode << " ";

    for (int v1 : m[startNode])
    {
        if (visitedNode.count(v1) == 1)
        {
            continue;
        }

        DFS(m, v1, visitedNode);
    }
}

void BFS(map<int, vector<int>> &m, int startNode, set<int> &visitedNode)
{
    queue<int> visit;

    visit.push(startNode);
    visitedNode.insert(startNode);

    while (!visit.empty())
    {
        int node = visit.front();
        visit.pop();
        cout << node << " ";

        for (int v1 : m[node])
        {
            if (visitedNode.count(v1) == 1)
            {
                continue;
            }

            visitedNode.insert(v1);
            visit.push(v1);
        }
    }
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    map<int, vector<int>> nodeEdges;

    int n,e,start; cin >> n >> e >> start;

    for (int i = 1; i <= n; ++i)
    {
        vector<int> v;
        nodeEdges[i] = v;
    }

    for (int i = 0; i < e; ++i)
    {
        int start,end; cin >> start >> end;

        nodeEdges[start].push_back(end);
        nodeEdges[end].push_back(start);
    }

    //오름차순 정렬
    for (auto &p : nodeEdges)
    {
        sort(p.second.begin(), p.second.end());
    }

    set<int> visitedNode;
    
    DFS(nodeEdges, start, visitedNode);
    
    cout << "\n";
    
    visitedNode.clear();
    BFS(nodeEdges, start, visitedNode);

    return 0;
}
