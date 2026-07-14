#include <string>
#include <vector>
#include <iostream>

using namespace std;

vector<int> solution(vector<int> progresses, vector<int> speeds) {
    vector<int> answer;
    
    vector<int> v(progresses.size());
    for(int i = 0; i < progresses.size(); i++)
    {
        int left = 100 - progresses[i];
        int days = left / speeds[i];
        days += left % speeds[i] == 0 ? 0 : 1;
        
        v[i] = days;
    }
    
    for(int i = 0; i < v.size(); i++)
    {
        int mc = 0;
        
        for(int j = i; j < v.size(); j++)
        {
            if(v[j] <= v[i])
            {
                mc++;
            }
            else
            {
                i = j - 1;
                break;
            }
        }
        
        answer.push_back(mc);
    }
    
    int sum = 0;
    v.clear();
    for(int i : answer)
    {
        sum += i;
        
        if(sum <= progresses.size()) v.push_back(i);
    }
    
    return v;
}