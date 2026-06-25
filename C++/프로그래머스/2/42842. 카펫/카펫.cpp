#include <string>
#include <vector>
#include <iostream>

using namespace std;

bool check(int &width, int &height, int color)
{
    while(true)
    {
        if(width < 1 || height < 1) return false;
        
        int sum = height == 1 ? width : width * 2 + (height - 2) * 2;
        
        color -= sum;
        width -= 2;
        height -= 2;
        
        //cout << "width: " << width << ", " << "height: " << height
        //    << ", " << "sum: " << sum << ", " << "color: " << color << "\n";
            
        if(color < 0) return false;
        if(color == 0) return true;
    }
}

//-0----------------------------

vector<int> solution(int brown, int yellow) {
    vector<int> answer;
    
    int sum = brown + yellow;
    
    int height = 2;
    int width = 2;
    
    vector<pair<int,int>> v;
    
    while(height <= width)
    {
        int mul = height * width;
        
        if(mul == sum)
        {
            v.push_back(make_pair(width, height));
            height++;
            width = height;
        }
        else if(mul < sum)
        {
            width++;
        }
        else if(mul > sum)
        {
            if(height > sum / 2) break;
            height++;
            width = height;
        }
    }
    
    // width * 2 + (height - 2) * 2
    // width -= 2, height -= 2;
    
    for(auto p : v)
    {
        width = p.first;
        height = p.second;
        int originW = width;
        int originH = height;
        
        bool checkBrown = check(width, height, brown);
        if(!checkBrown) continue;
        
        bool checkYellow = check(width, height, yellow);
        if(!checkYellow) continue;
        
        answer.push_back(originW);
        answer.push_back(originH);
        break;
    }
    
    return answer;
}