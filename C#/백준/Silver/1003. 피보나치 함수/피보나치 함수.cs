using System.Collections;
using System.Text;

public class Solution
{
    struct ZeroOne
    {
        public int zero;
        public int one;
    }
    
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());

        ZeroOne[] arr = new ZeroOne[41];
        arr[0].zero = 1;
        arr[0].one = 0;
        arr[1].zero = 0;
        arr[1].one = 1;
        arr[2].zero = 1;
        arr[2].one = 1;

        for (int i = 3; i < 41; i++)
        {
            arr[i].zero = arr[i - 1].zero + arr[i - 2].zero;
            arr[i].one = arr[i - 1].one + arr[i - 2].one;
        }

        for (int i = 0; i < N; i++)
        {
            int t = int.Parse(sr.ReadLine());
            
            sw.WriteLine(arr[t].zero + " " + arr[t].one);
        }
    }
}