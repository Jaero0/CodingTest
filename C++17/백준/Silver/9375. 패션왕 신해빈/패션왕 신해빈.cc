#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    for (int i = 0; i < c; ++i)
    {
        int c1; cin >> c1;

        map<string, int> cateCloth;
        for (int i = 0; i < c1; ++i)
        {
            string cl, cate; cin >> cl >> cate;

            if (cateCloth[cate] == 0)
            {
                cateCloth[cate] = 1;
            }
            else
            {
                cateCloth[cate]++;
            }
        }

        int sum = 1;

        for (auto cate_cloth : cateCloth)
        {
            sum *= (cate_cloth.second + 1);
        }

        cout << sum - 1 << "\n";
    }
    
    return 0;
}


