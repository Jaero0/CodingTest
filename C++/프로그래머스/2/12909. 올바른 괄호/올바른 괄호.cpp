#include <string>
#include <iostream>
#include <stack>

using namespace std;

bool solution(string s)
{
    bool answer = true;

    std::stack<char> st;
    
    for(char c : s)
    {        
        // ')'
        if(c == ')')
            if(st.size() > 0 && st.top() == '(')
            {
                st.pop();
                continue;
            }
        
        st.push(c);
        
    }

    return st.size() == 0 ? true : false;
}