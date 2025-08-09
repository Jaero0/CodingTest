#include <algorithm>

#include "bits/stdc++.h"
using namespace std;


int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    string input; cin >> input;
    string rev = input;
    reverse(rev.begin(), rev.end());

    cout << (input == rev ? "true" : "false");
    
    return 0;
}
