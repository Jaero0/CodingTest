public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());
        var s = new Stack<int>();

        for (int i = 0; i < N; i++)
        {
            string[] t = sr.ReadLine().Split(' ');

            switch (t[0])
            {
                case "push":
                    s.Push(int.Parse(t[1]));
                    break;
                case "pop":
                    sw.WriteLine(s.TryPop(out var r) ? r : -1);
                    break;
                case "size":
                    sw.WriteLine(s.Count);
                    break;
                case "empty":
                    sw.WriteLine(s.Count > 0 ? 0 : 1);
                    break;
                case "top":
                    sw.WriteLine(s.TryPeek(out var rr) ? rr : -1);
                    break;
            }
        }
        
        sr.Close();
        sw.Close();
    }
}