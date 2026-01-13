using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        var list = new List<int>();
        int sum = 0;
        int[] mod = new int[8001];
        int min = 4001, max = -4001;
        for (int i = 0; i < N; i++)
        {
            int t = int.Parse(sr.ReadLine());

            min = Math.Min(t, min);
            max = Math.Max(t, max);
            sum += t;
            mod[t + 4000]++;

            list.Add(t);
        }
        
        //산술평균
        double avg = Math.Round((double)sum / N, MidpointRounding.AwayFromZero);
        sw.WriteLine(avg == -0 ? 0 : avg);
        
        //중앙값
        list.Sort();
        sw.WriteLine(list[N/2]);

        //최빈값
        list.Clear();
        int count = 0;
        foreach (int i in mod)
        {
            count = Math.Max(i, count);
        }

        for (int i = 0; i < 8001; i++)
        {
            if (mod[i] == count)
            {
                list.Add(i - 4000);
            }
        }
        list.Sort();

        sw.WriteLine(list.Count > 1 ? list[1] : list[0]);

        //범위
        sw.WriteLine(max - min);
    }
}