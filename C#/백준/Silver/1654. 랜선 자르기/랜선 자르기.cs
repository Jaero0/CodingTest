public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

    public static long Con(int[] have, int aim)
    {
        long lo = 1;
        long hi = have.Max();
        long mid = 0;

        while (lo <= hi)        {
            long sum = 0;
            mid = (lo + hi) / 2;
            
            foreach (int i in have)
            {
                sum += i / mid;
            }
            
            if (sum < aim)
            {
                hi = mid - 1;
            }
            else if (sum >= aim)
            {
                lo = mid + 1;
            }
        }

        return hi;
    }

    public static void Main(string[] args)
    {
        int[] KN = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        int[] have = new int[KN[0]];
        for (int i = 0; i < KN[0]; i++)
        {
            int t = int.Parse(sr.ReadLine());
            have[i] = t;
        }

        sw.WriteLine(Con(have, KN[1]));

        sr.Close();
        sw.Close();
    }
}