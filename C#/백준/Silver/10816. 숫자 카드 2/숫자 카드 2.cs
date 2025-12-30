public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        const int CHUNMAN = 10_000_000;

        sr.ReadLine();
        var oriDic = new Dictionary<int, int>();
        int[] arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        foreach (var t in arr)
        {
            if (!oriDic.TryAdd(t, 1))
            {
                oriDic[t]++;
            }
        }

        sr.ReadLine();
        arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        foreach (int t in arr)
        {
            if (oriDic.TryGetValue(t, out var r))
            {
                sw.Write(r + " ");
            }
            else
            {
                sw.Write("0 ");
            }
        }
        
        sr.Close();
        sw.Close();
    }
}