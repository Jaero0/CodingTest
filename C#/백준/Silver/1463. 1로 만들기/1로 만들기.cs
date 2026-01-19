using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic.Add(1, 0);
        dic.Add(2, 1);
        dic.Add(3, 1);

        for (int i = 4; i <= N; i++)
        {
            int count1 = 1;
            int count2 = int.MaxValue;
            int count3 = int.MaxValue;
            if (i % 2 == 0)
            {
                count2 = 1;
                count2 += dic[i / 2];
            }
            if (i % 3 == 0)
            {
                count3 = 1;
                count3 += dic[i / 3];
            }
            
            count1 += dic[i - 1];
            
            dic.Add(i, Math.Min(Math.Min(count1, count2), count3));
        }
        
        sw.WriteLine(dic[N]);
    }
}