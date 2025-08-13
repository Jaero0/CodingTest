#include <iostream>
#include <string>
#include <vector>
#include <sstream>
#include <algorithm>

using namespace std;

string solution(string s) {
    string answer = "";
    
    
    for(int i = 0; i < s.length(); i++)
    {
        if (i == 0)
        {
            answer += toupper(s[i]);
            continue;
        }
        
        if (s[i-1] != ' ')
        {
            answer += tolower(s[i]);
        }
        else
        {
            answer += toupper(s[i]);
        }
    }
    
    
    return answer;
}