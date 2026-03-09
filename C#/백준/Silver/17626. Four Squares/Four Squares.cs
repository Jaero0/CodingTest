public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());
        
        int[] count = new int[50001];
        count[1] = 1;
        count[2] = 2;
        count[3] = 3;
        count[4] = 1;

        for (int i = 5; i <= N; i++)
        {
            int sqrt = (int)Math.Sqrt(i);

            if (sqrt * sqrt == i)
            {
                count[i] = 1;
            }
            else
            {
                int min = 5;
                for (int j = 2; j <= sqrt; j++)
                {
                    min = Math.Min(min, 1 + count[i - j * j]);
                }

                count[i] = min;
            }
        }
        
        sw.WriteLine(count[N]);
    }
}