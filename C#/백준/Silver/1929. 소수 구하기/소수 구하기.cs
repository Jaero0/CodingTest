using System.Text;

namespace Testt;

public class Solution {
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] MN = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        /*bool[] sosu = new bool[1000001];
        sosu[0] = true;
        sosu[1] = true;
        for (int i = 2; i * i < 1000000; i++)
        {
            for (int j = i; j < 1000000; j *= 2)
            {
                
            }
        }*/

        StringBuilder sb = new StringBuilder();
        
        for (int i = MN[0]; i <= MN[1]; i++)
        {
            if (i == 1)
            {
                continue;
            }

            bool isDivided = false;
            int sqrt = (int)Math.Sqrt(i);
            for (int j = 2; j <= sqrt; j++)
            {
                if (i % j != 0) continue;
                isDivided = true;
                break;
            }

            if (isDivided)
            {
                continue;
            }

            sb.Append(i);
            sb.Append('\n');
        }

        Console.WriteLine(sb.ToString());
    }
}