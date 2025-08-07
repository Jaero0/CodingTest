#include "bits/stdc++.h"
using namespace std;

int main()
{
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);

    string s; cin >> s;

    set<string> set;

    for (int i = 1; i <= s.size(); ++i)
    {
        for (int j = 0; j < s.size() - i + 1; ++j)
        {
            set.insert(s.substr(j, i));
        }
    }

    cout << set.size();
    
    return 0;
}
