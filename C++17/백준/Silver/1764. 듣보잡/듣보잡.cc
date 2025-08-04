#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int dudC, boC;
    cin >> dudC >> boC;

    map<string, int> dud;
    
    for (int i = 0; i < dudC; ++i)
    {
        string temp; cin >> temp;
        dud[temp] = i + 100;;
    }

    vector<string> dudbo;

    for (int i = 0; i < boC; ++i)
    {
        string temp; cin >> temp;

        if (dud[temp] >= 100)
        {
            dudbo.push_back(temp);
        }
    }


    sort(dudbo.begin(), dudbo.end());

    cout << dudbo.size() << "\n";

    for (auto value : dudbo)
    {
        cout << value << "\n";
    }
    
    return 0;
}
