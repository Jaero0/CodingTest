#include <bits/stdc++.h>
using namespace std;

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

        stack<char> stack;
        char peek;
        bool isCompatible = true;

        for (char c : s)
        {
            switch (c)
            {
            case '(':
                stack.push(c);
                break;
            case ')':
                if (stack.empty())
                {
                    isCompatible = false;
                    break;
                }
                peek = stack.top();
                if (peek != '(')
                {
                    isCompatible = false;
                    break;
                }
                stack.pop();
                break;
            case '[':
                stack.push(c);
                break;
            case ']':
                if (stack.empty())
                {
                    isCompatible = false;
                    break;
                }
                peek = stack.top();
                if (peek != '[')
                {
                    isCompatible = false;
                    break;
                }
                stack.pop();
                break;
            }

            if (isCompatible == false)
            {
                break;
            }
        }

        if (isCompatible == false || !stack.empty())
        {
            cout << "no" << "\n";
            continue;
        }

        if (stack.empty())
        {
            cout << "yes" << "\n";
        }
    }

    cout << endl;
    return 0;
}
