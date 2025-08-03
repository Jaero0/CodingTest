#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;
    
    vector<int> vec;
    
    for (int i = 0; i < c; ++i)
    {
        int temp; cin >> temp;
        vec.push_back(temp);
    }

    string s = "";

    int max = 1;
    stack<int> st;

    bool isBroken = false;
    for (int i : vec)
    {
        while (true)
        {
            if (st.empty())
            {
                st.push(max);
                max++;

                s += "+\n";
            }
            
            if (st.top() <= i)
            {
                if (i >= max)
                {
                    st.push(max);
                    max++;

                    s += "+\n";
                }

                
                if (st.top() == i)
                {
                    st.pop();
                    s += "-\n";
                    break;
                }
            }
            else
            {
                isBroken = true;
                break;
            }
        }

        if (isBroken == true)
        {
            break;
        }
    }

    cout << (isBroken == true ? "NO" : s);
    
    return 0;
    
}
