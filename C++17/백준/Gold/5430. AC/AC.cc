#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N;
    cin >> N;

    for (int i = 0; i < N; ++i)
    {
        string t; cin >> t;
        int t1; cin >> t1;

        string s; cin >> s;

        deque<int> sdq;

        string temp;
        for (char c : s)
        {
            if (c == '[')
            {
                continue;
            }
            
            if (c == ',' || c == ']')
            {
                if (temp.empty())
                {
                    continue;
                }
                sdq.push_back(stoi(temp));
                temp.clear();
                continue;
            }
            
            temp += c;
        }

        int rCount = 0;
        bool errorDetected = false;
        for (char f : t)
        {
            if (f == 'R')
            {
                rCount++;
                continue;
            }

            if (sdq.empty())
            {
                cout<<"error"<<"\n";
                errorDetected = true;
                break;
            }

            if (rCount % 2 == 0)
            {
                sdq.pop_front();
            }
            else
            {
                sdq.pop_back();
            }
        }

        if (errorDetected == true)
        {
            continue;
        }

        //print
        cout << "[";
        if (rCount % 2 == 0)
        {
            for (auto iter = sdq.begin(); iter != sdq.end(); ++iter)
            {
                cout << *iter;
                if (next(iter) != sdq.end())
                {
                    cout << ",";
                }
            }
        }
        else
        {
            for (auto iter = sdq.rbegin(); iter != sdq.rend(); ++iter)
            {
                cout << *iter;
                if (next(iter) != sdq.rend())
                {
                    cout << ",";
                }
            }
        }
        
        cout << "]" << "\n";
        
    }
    
    return 0;
}
