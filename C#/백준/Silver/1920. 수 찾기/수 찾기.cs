using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sr.ReadLine();

        var arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        var dict = new Dictionary<int, bool>();

        foreach (var i in arr)
        {
            if (dict.TryAdd(i, true)) { }
        }

        sr.ReadLine();
        
        arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        foreach (var i in arr) { sw.WriteLine(dict.TryGetValue(i, out bool b) ? 1 : 0); }


        sw.Close();
        sr.Close();
    }
}