#include <bits/stdc++.h>
using namespace std;

int main()
{
    int input;

    cin >> input;

    for (int i = 0; i < input; i++)
    {
        int h, w, human;
        cin >> h >> w >> human;

        int hCount = 1;
        int wCount = 1;
        int count = 1;

        while (count != human)
        {
            hCount++;

            if (hCount > h)
            {
                hCount = 1;
                wCount++;
            }

            count++;
        }

        string s = to_string(wCount);


        cout << hCount << (wCount < 10 ? "0" + s : s) << "\n";
    }

    cout << endl;

    return 0;
}