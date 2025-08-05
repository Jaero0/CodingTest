#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int c, c1; cin >> c >> c1;

    map<string, string> m;
    for (int i = 0; i < c; ++i)
    {
        string t, t1; cin >> t >> t1;

        m[t] = t1;
    }

    for (int i = 0; i < c1; ++i)
    {
        string input; cin >> input;

        cout << m[input] << "\n";
    }
    
    return 0;
}
