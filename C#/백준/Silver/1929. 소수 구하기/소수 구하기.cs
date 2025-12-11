using System.Text;

namespace Testt;

public class Solution {
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] MN = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        bool[] sosu = new bool[MN[1] + 1];
        sosu[0] = true;
        sosu[1] = true;
        for (int i = 2; i <= MN[1]; i++)
        {
            if (sosu[i] == true)
            {
                continue;
            }
            
            for (int j = i + i; j <= MN[1]; j += i)
            {
                sosu[j] = true;
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int i = MN[0]; i <= MN[1]; i++)
        {
            if (sosu[i] == false)
            {
                sw.WriteLine(i);
            }
        }
        
        sw.Close();
        sr.Close();
    }
}