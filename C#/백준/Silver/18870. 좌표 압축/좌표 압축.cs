using System.Collections;
using System.Text;

public class FastReader
{
    private readonly Stream stream;
    private readonly byte[] buffer = new byte[1 << 16];
    private int len, ptr;

    public FastReader(Stream stream)
    {
        this.stream = stream;
    }

    private byte Read()
    {
        if (ptr >= len)
        {
            len = stream.Read(buffer, 0, buffer.Length);
            ptr = 0;
            if (len <= 0) return 0;
        }
        return buffer[ptr++];
    }

    public int NextInt()
    {
        byte c;
        do
        {
            c = Read();
        } while (c <= 32); // 공백 제거

        int sign = 1;
        if (c == '-')
        {
            sign = -1;
            c = Read();
        }

        int val = 0;
        while (c > 32)
        {
            val = val * 10 + (c - '0');
            c = Read();
        }

        return val * sign;
    }

    public string Next()
    {
        byte c;
        do
        {
            c = Read();
        } while (c <= 32);

        var sb = new StringBuilder();
        while (c > 32)
        {
            sb.Append((char)c);
            c = Read();
        }

        return sb.ToString();
    }
}

public class Solution
{
    private static FastReader sr = new FastReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    
    public static void Main(string[] args)
    {
        var n = sr.NextInt();

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = sr.NextInt();


        var sorted = arr.ToArray();
        Array.Sort(sorted);
        var dict = new Dictionary<int, int>();

        int count = 0;
        foreach (int i in sorted)
        {
            if (!dict.ContainsKey(i))
            {
                dict[i] = count++;
            }
        }

        foreach (int i in arr)
        {
            sw.Write(dict[i] + " ");
        }

        sw.Close();
    }
}