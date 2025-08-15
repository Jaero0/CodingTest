#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int h,v,c1; cin >> h >> v>> c1;

        bool field[50][50] = {false};

        for (int i = 0; i < c1; ++i)
        {
            int t, t1; cin >> t >> t1;

            field[t][t1] = true;
        }

        stack<pair<int,int>> HaveToVisit;
        bool visited[50][50] = {false};
        set<pair<int,int>> visitedNode;

        int id = 0;

        for (int i = 0; i < h; ++i)
        {
            for (int j = 0; j < v; ++j)
            {
                if (field[i][j] == true && visited[i][j] == false)
                {
                    id++;
                    HaveToVisit.emplace(i,j);
                    visitedNode.insert(make_pair(i,j));
                    visited[i][j] = true;
                    
                    while (!HaveToVisit.empty())
                    {
                        auto pair = HaveToVisit.top();
                        HaveToVisit.pop();

                        int first = pair.first;
                        int second = pair.second;

                        bool isVisited = false;
                        
                        //up
                        if (first > 0)
                        {
                            auto up = make_pair(first-1, second);
                            if (visitedNode.count(up) == 1)
                            {
                                isVisited = true;
                            }
                            else
                            {
                                visitedNode.insert(up);
                            }
                            
                            if (field[first-1][second] == true && isVisited == false)
                            {
                                HaveToVisit.push(up);
                                visited[first-1][second] = true;
                            }
                        }

                        isVisited = false;

                        //down
                        if (first < 49)
                        {
                            auto down = make_pair(first+1, second);
                            if (visitedNode.count(down) == 1)
                            {
                                isVisited = true;
                            }
                            else
                            {
                                visitedNode.insert(down);
                            }
                            
                            if (field[first+1][second] == true && isVisited == false)
                            {
                                HaveToVisit.push(down);
                                visited[first+1][second] = true;
                            }
                        }

                        isVisited = false;

                        //left
                        if (second > 0)
                        {
                            auto left = make_pair(first, second-1);
                            if (visitedNode.count(left) == 1)
                            {
                                isVisited = true;
                            }
                            else
                            {
                                visitedNode.insert(left);
                            }
                            
                            if (field[first][second - 1] == true && isVisited == false)
                            {
                                HaveToVisit.push(left);
                                visited[first][second-1] = true;
                            }
                        }

                        isVisited = false;
                        
                        //right
                        if (second < 49)
                        {
                            auto right = make_pair(first, second + 1);
                            if (visitedNode.count(right) == 1)
                            {
                                isVisited = true;
                            }
                            else
                            {
                                visitedNode.insert(right);
                            }
                            
                            if (field[first][second + 1] == true && isVisited == false)
                            {
                                HaveToVisit.push(right);
                                visited[first][second+1] = true;
                            }
                        }
                    }
                }
            }
        }

        cout << id << "\n";
    }
    
    return 0;
}


