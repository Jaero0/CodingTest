#include <string>
#include <unordered_map>
#include <algorithm>
#include <iostream>
#include <queue>

using namespace std;

bool findChar(const vector<char>& c, char t)
{
    for(char ch : c)
    {
        if(ch == t) return true;
    }
    
    return false;
}

bool rev(char c)
{
    switch(c)
    {
        case 'L' : return 'R';
        case 'R' : return 'L';
        case 'U' : return 'D';
        case 'D' : return 'U';
    }
}

int solution(string dirs) {
    int answer = 0;
    
    unordered_map<int, vector<char>> m;
    int loc = 61;
    
    for(char c : dirs)
    {
        if(c == 'L') 
        {
            if(loc % 11 == 1) continue;
            
            if(!findChar(m[loc], c))
            {
                answer++;
                m[loc].push_back('L');
                m[loc-1].push_back('R');
            }
            
            loc -= 1;
        }
        if(c == 'R') 
        {
            if(loc % 11 == 0) continue;
            
            if(!findChar(m[loc], c))
            {
                answer++;
                m[loc].push_back('R');
                m[loc+1].push_back('L');
            }
            
            loc += 1;
        }
        if(c == 'U') 
        {
            if(loc < 12) continue;
            
            if(!findChar(m[loc], c))
            {
                answer++;
                m[loc].push_back('U');
                m[loc-11].push_back('D');
            }
            
            loc -= 11;
        }
        if(c == 'D') 
        {
            if(loc > 110) continue;
            
            if(!findChar(m[loc], c))
            {
                answer++;
                m[loc].push_back('D');
                m[loc+11].push_back('U');
            }
            
            loc += 11;
        }
    }
    
    return answer;
}