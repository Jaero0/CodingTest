#include <bits/stdc++.h>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    vector<int> v(8);
    for (int i = 0; i < 8; ++i)
        cin >> v[i];

    vector<int> asc = {1,2,3,4,5,6,7,8};
    vector<int> desc = {8,7,6,5,4,3,2,1};

    if (v == asc)
        cout << "ascending";
    else if (v == desc)
        cout << "descending";
    else
        cout << "mixed";

    return 0;
}
