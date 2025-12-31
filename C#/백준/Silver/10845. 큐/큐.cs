public class Solution
{
    public class FBQ
    {
        
    }
    
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());
        var s = new Queue<int>();
        int rear = -1;

        for (int i = 0; i < N; i++)
        {
            string[] t = sr.ReadLine().Split(' ');

            switch (t[0])
            {
                case "push":
                    var ad = int.Parse(t[1]);
                    s.Enqueue(ad);
                    rear = ad;
                    break;
                case "pop":
                    sw.WriteLine(s.TryDequeue(out var r) ? r : -1);
                    if (s.Count == 0)
                    {
                        rear = -1;
                    }
                    break;
                case "size":
                    sw.WriteLine(s.Count);
                    break;
                case "empty":
                    sw.WriteLine(s.Count > 0 ? 0 : 1);
                    break;
                case "front":
                    sw.WriteLine(s.TryPeek(out var rr) ? rr : -1);
                    break;
                case "back":
                    sw.WriteLine(rear);
                    break;
            }
        }
        
        sr.Close();
        sw.Close();
    }
}