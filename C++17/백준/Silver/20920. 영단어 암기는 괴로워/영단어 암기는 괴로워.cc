#include <unordered_map>

#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c, c1;
    cin >> c >> c1;

    unordered_map<string, int> wordCount;

    for (int i = 0; i < c; ++i)
    {
        string inp;
        cin >> inp;

        if (inp.length() < c1)
        {
            continue;
        }

        wordCount[inp]++;
    }

    vector<pair<string,int>> v (wordCount.begin(), wordCount.end());

    sort(v.begin(), v.end(), [](pair< string, int> a, pair<string, int> b)
    {
        //frequent
        if (a.second != b.second)
        {
            return b.second < a.second;
        }

        //length
        if (a.first.length() != b.first.length())
        {
            return b.first.length() < a.first.length();
        }

        //alphabet
        return a.first < b.first;
    });


    for (pair<const string, int> p : v)
    {
        cout << p.first << "\n";
    }

    return 0;
}
