#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N, K; cin >> N >> K;

    list<int> list;
    for (int i = 0; i < N; ++i)
    {
        list.push_back(i+1);
    }

    auto ptr = list.begin();

    cout << "<";

    while (true)
    {
        for (int i = 0; i < K; ++i)
        {
            if (ptr == list.end())
            {
                ptr = list.begin();
            }
            
            ++ptr;

            if (ptr == list.end())
            {
                ptr = list.begin();
            }
        }

        if (ptr == list.begin())
        {
            ptr = list.end();
        }

        --ptr;
        int temp = *ptr;
        ptr = list.erase(ptr);

        if (list.empty())
        {
            cout << temp;
            break;
        }
        
        cout << temp << ", ";
        
    }

    cout << ">";
    
    return 0;
}
