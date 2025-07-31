#include <string>
#include <iostream>
using namespace std;

bool solution(string s)
{
    int pC = 0;
    int yC = 0;
    for (size_t i = 0; i < s.size(); i++)
    {
        if (s[i] == 'p' || s[i] == 'P')
            pC++;

        if (s[i] == 'y' || s[i] == 'Y')
            yC++;
    }

    return pC == yC;
}