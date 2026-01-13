using System.Collections;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());
        StringBuilder sb = new StringBuilder();

        var stack = new Stack<int>();

        int num = 1;
        for (int i = 1; i <= N; i++)
        {
            int t = int.Parse(sr.ReadLine());

            while (num <= t)
            {
                stack.Push(num);
                sb.Append("+\n");
                num++;
            }

            bool isPopped = false;
            while (stack.Count != 0)
            {
                int tmp = stack.Pop();
                sb.Append("-\n");

                if (tmp != t) continue;
                isPopped = true;   
                break;
            }

            if (isPopped != false) continue;
            sw.WriteLine("NO");
            return;
        }
        
        sw.WriteLine(sb.ToString());
    }
}