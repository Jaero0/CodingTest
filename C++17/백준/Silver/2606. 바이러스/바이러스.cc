#include "bits/stdc++.h"
using namespace std;

struct Node
{
    int id;
    vector<Node*> v_coneccted;
};

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    vector<Node*> nodes;

    nodes.reserve(c);
    for (int i = 0; i < c; ++i)
    {
        nodes.push_back(new Node());
    }

    cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int node, infection; cin >> node >> infection;

        auto originNode = nodes[node-1];
        originNode->id = node;
        auto infectionNode = nodes[infection-1];
        infectionNode->id = infection;
        
        originNode->v_coneccted.push_back(infectionNode);
        infectionNode->v_coneccted.push_back(originNode);
    }


    // 방문 처리용
    set<Node*> visited;

    // DFS 스택
    stack<Node*> st;
    st.push(nodes[0]);

    // 시작점: 1번 노드의 연결 노드들부터 탐색
    for (auto n : nodes[0]->v_coneccted)
    {
        st.push(n);
    }

    // DFS 실행
    while (!st.empty())
    {
        Node* cur = st.top();
        st.pop();

        // 이미 방문했으면 건너뜀
        if (visited.count(cur)) continue;

        // 방문 처리
        visited.insert(cur);

        // 연결된 노드들을 스택에 추가
        for (auto next : cur->v_coneccted)
        {
            if (!visited.count(next))
            {
                st.push(next);
            }
        }
    }

    cout << visited.size() - 1;
    
    return 0;
}
