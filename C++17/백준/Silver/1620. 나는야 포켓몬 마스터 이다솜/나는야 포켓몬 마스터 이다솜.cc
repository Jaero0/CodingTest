#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int inputC, findC;
    cin >> inputC >> findC;

    map<string, string> nameIndex;
    map<string, string> indexName;

    for (int i = 0; i < inputC; ++i)
    {
        string temp; cin >> temp;
        string stemp = to_string(i + 1);
        nameIndex[temp] = stemp;
        indexName[stemp] = temp;
    }

    for (int i = 0; i < findC; ++i)
    {
        string input; cin >> input;

        if ('0' <= input[0] && input[0] <= '9')
        {
            cout << indexName[input] << "\n";
            continue;
        }

        cout << nameIndex[input] << "\n";
    }
    
    return 0;
}
