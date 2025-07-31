#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    string grade;
    double majorGrade = 0;

    double chihoonTotal = 0;
    double total = 0;

    for (int i = 0; i < 20; ++i)
    {
        cin >> grade >> majorGrade >> grade;

        if (grade == "P")
            continue;
        else if (grade == "A+")
            chihoonTotal += majorGrade * 4.5;
        else if (grade == "A0")
            chihoonTotal += majorGrade * 4.0;
        else if (grade == "B+")
            chihoonTotal += majorGrade * 3.5;
        else if (grade == "B0")
            chihoonTotal += majorGrade * 3.0;
        else if (grade == "C+")
            chihoonTotal += majorGrade * 2.5;
        else if (grade == "C0")
            chihoonTotal += majorGrade * 2.0;
        else if (grade == "D+")
            chihoonTotal += majorGrade * 1.5;
        else if (grade == "D0")
            chihoonTotal += majorGrade * 1.0;
        else if (grade == "F")
            chihoonTotal += majorGrade * 0.0;

        if (grade != "P")
            total += majorGrade;
    }
    
    cout << fixed;
    cout.precision(6);
    cout << chihoonTotal / total << endl;

    return 0;
}
