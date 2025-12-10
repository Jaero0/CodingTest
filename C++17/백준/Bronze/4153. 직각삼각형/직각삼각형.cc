#include <bits/stdc++.h>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int arr[3];
    
    while (true)
    {
        cin >> arr[0]; cin >> arr[1]; cin >> arr[2];

        if (arr[0] == 0 && arr[1] == 0 && arr[2] == 0)
        {
            return 0;
        }
        
        sort(begin(arr), end(arr));
        if (arr[0] * arr[0] + arr[1] * arr[1] == arr[2] * arr[2])
        {
            cout << "right" << '\n';
        }
        else
        {
            cout << "wrong" << '\n';
        }
        
    }

    return 0;
}
