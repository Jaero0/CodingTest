public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        if (N == 0)
        {
            sw.WriteLine(0);
            return;
        }

        int no = (int)Math.Round((double)N / 100 * 15, MidpointRounding.AwayFromZero);

        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(sr.ReadLine());
        }

        Array.Sort(arr);

        int sum = 0;
        for (int i = no; i < N - no; i++)
        {
            sum += arr[i];
        }
        
        sw.WriteLine(Math.Round((double)sum / (N - no * 2), MidpointRounding.AwayFromZero));
    }
}