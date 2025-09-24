#include "bits/stdc++.h"
using namespace std;

struct LR {
    char left;
    char right;

    LR(): left(0), right(0) {}
    LR(char l, char r) : left(l), right(r) {}

    static LR make_LR(char l, char r) {
        return LR(l, r);
    }
};

map<char, LR> tr;

void PreOrder(char node)
{
    if (node == '.')
    {
        return;
    }
    
    LR lr = tr[node];

    cout << node;
    PreOrder(lr.left);
    PreOrder(lr.right);
}

void InOrder(char node)
{
    if (node == '.')
    {
        return;
    }
    
    LR lr = tr[node];
    
    InOrder(lr.left);
    cout << node;
    InOrder(lr.right);
}

void PostOrder(char node)
{
    if (node == '.')
    {
        return;
    }
    
    LR lr = tr[node];
    
    PostOrder(lr.left);
    PostOrder(lr.right);
    cout << node;
}

int main()
{
    int N; cin >> N;
    
    
    for (int i = 0; i < N; ++i)
    {
        char t, t1, t2; cin >> t >> t1 >> t2;

        tr.emplace(t, LR::make_LR(t1,t2));
    }
    
    PreOrder('A');
    cout << "\n";
    InOrder('A');
    cout << "\n";
    PostOrder('A');
    
    return 0;
}