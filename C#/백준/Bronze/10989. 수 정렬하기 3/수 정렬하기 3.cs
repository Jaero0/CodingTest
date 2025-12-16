namespace Testt;

public class Solution {
    
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] arr = new int[10001];
        int l = int.Parse(sr.ReadLine());

        for (int i = 0; i < l; i++)
        {
            int t = int.Parse(sr.ReadLine());

            arr[t]++;
        }

        for (int i = 0; i < 10001; i++)
        {
            if (arr[i] == 0)
            {
                continue;
            }

            for (int j = 0; j < arr[i]; j++)
            {
                sw.WriteLine(i);
            }
        }
        
        sw.Close();
        sr.Close();
    }
}