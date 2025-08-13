#include "bits/stdc++.h"
using namespace std;

vector<string> split(string str, char Delimiter)
{
    istringstream iss(str);
    string buffer;

    vector<string> result;

    while (getline(iss, buffer, Delimiter))
    {
        result.push_back(buffer);
    }

    return result;
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    string s;
    cin >> s;

    vector<string> v = split(s, '-');

    int sum = 0;

    for (int i = 0; i < v.size(); ++i)
    {
        auto spl = split(v[i], '+');

        int temp = 0;
        
        for (string ss : spl)
        {
            temp += stoi(ss);
        }
        
        if (i == 0)
        {
            sum += temp;
            continue;
        }

        sum -= temp;
    }

    cout << sum;
    
    return 0;
}
