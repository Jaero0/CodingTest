
#include <ios>
#include <iostream>
#include <vector>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    int count;
    cin >> count;
    auto vec = std::vector<pair<int, int>>();

    
    
    for (size_t i = 0; i < count; i++)
    {
        int x, y;
        cin >> x >> y;
        vec.push_back(make_pair(x,y));
    }

    vector<vector<bool>> square(100, vector<bool>(100));;

    int dim = 0;

    int x, y = 0;
    for (int i = 0; i < count; ++i)
    {
        x = vec[i].first;
        y = vec[i].second;

        for (int j = y; j < y + 10; ++j)
        {
            for (int k = x; k < x + 10; ++k)
            {
                if (square[k][j] != true)
                {
                    dim++;
                    square[k][j] = true;
                }
            }
        }
    }

    cout << dim << endl;

    return 0;
}