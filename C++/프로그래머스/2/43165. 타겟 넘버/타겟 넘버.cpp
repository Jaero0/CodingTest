#include <string>
#include <vector>
#include <queue>

using namespace std;

int solution(vector<int> numbers, int target) {
    int answer = 0;
    
    queue<pair<int,int>> nbIdx;
    nbIdx.push({numbers[0], 0});
    nbIdx.push({-numbers[0], 0});
    
    int size = numbers.size();
    
    while(!nbIdx.empty())
    {
        auto p = nbIdx.front();
        nbIdx.pop();
        
        int num = p.first;
        int idx = p.second + 1;
        
        if(idx == size)
        {
            if(num == target) answer++;
            continue;
        }
        
        nbIdx.push({num + numbers[idx], idx});
        nbIdx.push({num - numbers[idx], idx});
    }
    
    return answer;
}