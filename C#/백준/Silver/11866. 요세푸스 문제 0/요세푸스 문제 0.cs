public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] N = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        var q = new Queue<int>(N[0]);

        for (int i = 0; i < N[0]; i++)
        {
            q.Enqueue(i + 1);
        }
        
        sw.Write("<");

        while (q.Count > 1)
        {
            for (int i = 0; i < N[1]; i++)
            {
                if (i == N[1] - 1)
                {
                    sw.Write(q.Dequeue() + ", ");
                    break;
                }
                
                q.Enqueue(q.Dequeue());
            }
        }
        
        sw.Write(q.Dequeue() + ">");
        
        sr.Close();
        sw.Close();
    }
}