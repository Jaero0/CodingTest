public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    
    public static void Main(string[] args)
    {
        string[] s = sr.ReadLine().Split('-');

        int res = ParseGroup(s[0]); // 첫 번째는 더함

        for (int i = 1; i < s.Length; i++)
            res -= ParseGroup(s[i]); // 나머지는 뺌

        sw.WriteLine(res);

        sr.Close();
        sw.Close();
    }

    private static int ParseGroup(string token)
    {
        int sum = 0;
        Array.ForEach(token.Split('+'), t => sum += int.Parse(t));
        return sum;
    }

}