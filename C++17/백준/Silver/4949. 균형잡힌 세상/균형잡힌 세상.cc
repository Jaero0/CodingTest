#include <bits/stdc++.h>
using namespace std;

bool IsStringBalanced(const string* s)
{
    stack<char> stack;

    for (char c : *s)
    {
        if (c == '(' || c == '[')
        {
            stack.push(c);
        }
        else if (c == ')' || c == ']')
        {
            if (stack.empty())
            {
                return false;
            }

            char peek = stack.top();
            if (c == ')' && peek != '('  || c == ']' && peek != '[' )
            {
                return false;
            }

            stack.pop();
        }
    }

    return stack.empty();
}

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    string s;

    while (true)
    {
        getline(cin, s);
        if (s == ".")
        {
            break;
        }

        cout << (IsStringBalanced(&s) ? "yes" : "no") << "\n";
        
    }

    cout << endl;
    return 0;
}


