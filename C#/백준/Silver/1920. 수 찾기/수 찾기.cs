using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sr.ReadLine();

        var arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        var set = new HashSet<int>();

        foreach (var i in arr)
        {
            set.Add(i);
        }

        sr.ReadLine();
        
        arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        foreach (var i in arr) { sw.WriteLine(set.Contains(i) ? 1 : 0); }


        sw.Close();
        sr.Close();
    }
}