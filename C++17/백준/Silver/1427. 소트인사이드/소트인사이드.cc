#include <chrono>
#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int i; cin >> i;

    vector<int> v;

    while (i != 0)
    {
        v.push_back(i % 10);

        i /= 10;
    }

    std::sort(v.begin(), v.end(), [](int a, int b){return a > b;});

    for (int v1 : v)
    {
        cout << v1;
    }
    
    return 0;
}
