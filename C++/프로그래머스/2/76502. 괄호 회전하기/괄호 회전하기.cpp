#include <string>
#include <vector>
#include <stack>

using namespace std;

int solution(string s) {
    int answer = 0;
    
    int size = s.size();
    vector<char> v;
    for(char c :s )
    {
        v.push_back(c);
    }
    
    for(int i = 0; i < size; i++)
    {
        stack<char> st;
        
        bool isStopped = false;
        
        for(int j = i; j < i + size; j++)
        {
            int idx = j >= size ? j - size : j;
            
            char c = s[idx];
            
            if(c == '(' || c == '{' || c == '[')
            {
                st.push(c);
                continue;
            }
            
            if(st.size() == 0) 
            {
                isStopped = true;
                break;
            };
                
            if(c == ')' && st.top() == '(')
            {
                st.pop();
            }
            else if(c == '}' && st.top() == '{')
            {
                st.pop();
            }
            else if(c == ']' && st.top() == '[')
            {
                st.pop();
            }
            
        }
        
        if(isStopped) continue;
        
        if(st.size() == 0) answer++;
    }
    
    return answer;
}