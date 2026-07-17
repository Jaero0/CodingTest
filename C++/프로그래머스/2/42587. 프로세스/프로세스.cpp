#include <string>
#include <vector>
#include <queue>

using namespace std;

int solution(vector<int> priorities, int location) {
    int answer = 1;
    
    queue<int> q;
    for(int i = 1; i <= priorities.size(); i++) q.push(i);
    
    while(!q.empty())
    {
        int i = q.front();
        q.pop();
        
        int size = q.size();
        bool found = false;
        
        for(int j = 0; j < size; j++)
        {
            int temp = q.front();
            q.pop();
            if(priorities[temp - 1] > priorities[i - 1])
            {
                found = true;
            }
            q.push(temp);
        }
        
        if(found)
        {
            q.push(i);
            continue;
        }
        
        if(i == location + 1) return answer;
        else answer++;
    }
    
    return answer;
}