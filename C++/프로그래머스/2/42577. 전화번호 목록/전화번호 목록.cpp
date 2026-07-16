#include <string>
#include <vector>
#include <algorithm>

#include <unordered_set> 

using namespace std;

bool solution(vector<string> phone_book) {
    
    sort(phone_book.begin(), phone_book.end(), 
         [](string a, string b) {return a.size() < b.size();}
        );
    
    unordered_set<string> s;
    
    for(string st : phone_book)
    {
        string temp;
        temp.reserve(st.size());
        
        for(char c : st)
        {
            temp += c;
            
            if(s.count(temp) > 0)
            {
                return false;
            }
        }
        
        s.insert(st);
    }
    
    return true;
}