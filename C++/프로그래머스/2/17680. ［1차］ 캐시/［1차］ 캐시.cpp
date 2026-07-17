#include <string>
#include <vector>
#include <list>
#include <algorithm>
#include <iostream>

using namespace std;

int solution(int cacheSize, vector<string> cities) {
    int answer = 0;
    
    for(int i = 0; i < cities.size(); i++)
    {
        transform(cities[i].begin(), cities[i].end(), cities[i].begin(), ::toupper);
    }
    
    list<string> l;
    
    for(string s : cities)
    {
        bool found = false;
        auto iter = l.begin();
        
        for(auto it = l.begin(); it != l.end(); ++it)
        {
            if(*it == s)
            {
                found = true;
                iter = it;
                break;
            }
        }
        
        if(!found)
        {
            l.push_back(s);
            
            answer += 5;
            
            if(l.size() > cacheSize) l.pop_front();
        }
        else
        {
            l.erase(iter);
            l.push_back(s);
            answer += 1;
        }
    }
    
    return answer;
}