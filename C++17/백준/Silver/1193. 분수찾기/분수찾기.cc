#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int total;
    cin >> total;

    int count = 1;

    while (total - count > 0)
    {
        total -= count;
        count++;
    }


    int mom, son;
    if (count % 2 == 0)
    {
        mom = count + 1 - total;
        son = total;
    }
    else
    {
        mom = total;
        son = count + 1 - total;
    }
    
    cout << son << "/" << mom << endl;
    return 0;
}
