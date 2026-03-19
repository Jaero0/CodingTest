public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    
    public static void Main(string[] args)
    {
        string[] s = sr.ReadLine().Split('-');

        int length = s.Length;

        int[] sum = new int[length];
        for (int i = 0; i < length; i++)
        {
            if (int.TryParse(s[i], out var result))
            {
                sum[i] = result;
            }
            else
            {
                Array.ForEach(s[i].Split('+'), ss => sum[i] += int.Parse(ss));
            }
        }

        if (length == 1)
        {
            sw.WriteLine(sum[0]);
        }
        else
        {
            int res = sum[0];

            for (int i = 1; i < length; i++)
            {
                res -= sum[i];
            }
            
            sw.WriteLine(res);
        }
        
        sr.Close();
        sw.Close();
    }
}