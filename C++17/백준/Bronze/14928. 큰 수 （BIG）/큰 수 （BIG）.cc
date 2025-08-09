#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    string s; cin >> s;

    string add;
    constexpr int date = 20000303;
    for (char c : s)
    {
        add += c;

        if (add.size() >= 8)
        {
            int dev = stoi(add) % date;
            add = to_string(dev);
        }
    }
    
    cout << add;
    
    return 0;
}
