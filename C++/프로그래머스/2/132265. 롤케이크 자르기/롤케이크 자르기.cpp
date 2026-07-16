#include <string>
#include <vector>
#include <unordered_map>
#include <iostream>

using namespace std;

int solution(vector<int> topping) {
    int answer = 0;
    
    unordered_map<int, int> 철수;
    unordered_map<int, int> 철동;
    
    for(int i : topping)
    {
        철수[i]++;
    }
    
    for(int i : topping)
    {
        if(철수.count(i) > 0)
        {
            철수[i]--;
        }
        if(철수[i] == 0)
        {
            철수.erase(i);
        }
        
        철동[i]++;
        
        if(철수.size() == 철동.size()) answer++;
    }
    
    
    return answer;
}