namespace Testt;

public class Solution {
    
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[,] apt = new int[15,15];
        for (int i = 0; i < 15; i++)
        {
            for (int j = 1; j < 15; j++)
            {
                if (i == 0)
                {
                    apt[i, j] = j;
                    continue;
                }

                if (j == 1)
                {
                    apt[i, j] = 1;
                    continue;
                }

                apt[i, j] = apt[i - 1, j] + apt[i, j - 1];
            }
        }
        
        int T = int.Parse(sr.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int f = int.Parse(sr.ReadLine());
            int n = int.Parse(sr.ReadLine());
            
            sw.WriteLine(apt[f,n]);
        }
        
        sw.Close();
        sr.Close();
    }
}