using System.Collections;

public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    
    public static void Main(string[] args)
    {
        var input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int b = int.Parse(input[2]);

        int[] land = new int[256 + 1];
        int maxHeight = 0;
        int totalBlockCount = 0;
        
        for (int i = 0; i < n; i++)
        {
            var s = sr.ReadLine().Split(' ');

            foreach (string s1 in s)
            {
                var index = int.Parse(s1);
                totalBlockCount += index;
                land[index]++;
            }
        }
        
        //priority time -> height
        int time = int.MaxValue;

        //1. 블럭 높이에 따라 평탄화 가능성 판별 후 시간 계산로직 
        for (int desireHeight = 0; desireHeight < 257; desireHeight++)
        {
            //2. 원하는 높이가 필요로 하는 전체블럭 수 > b + 전체 블럭 수
            //   -> 더이상 진행이 의미 없으므로 break
            int desireHeightBlockCount = desireHeight * n * m;

            if (totalBlockCount + b < desireHeightBlockCount)
            {
                break;
            }
            
            //3. 원하는 높이보다 작은 높이의 블럭에는 블럭을 쌓고
            //   원하는 높이보다 높은 높이의 블럭은 뺀 후
            //   time변수와 비교하여 같으면 더 높이가 높은것을, time이 더 크면 높이와 time값 교체
            int tempTime = 0;
            
            for (int currentHeight = 0; currentHeight < 257; currentHeight++)
            {
                if (currentHeight < desireHeight)
                {
                    tempTime += (desireHeight - currentHeight) * land[currentHeight];
                }
                else if (currentHeight > desireHeight)
                {
                    tempTime += (currentHeight - desireHeight) * 2 * land[currentHeight];
                }
            }

            if (tempTime == time)
            {
                maxHeight = Math.Max(maxHeight, desireHeight);
            }
            else if(tempTime < time)
            {
                time = Math.Min(tempTime, time);
                maxHeight = desireHeight;
            }
        }
        
        sw.WriteLine($"{time} {maxHeight}");

        sr.Close();
        sw.Close();
    }
}