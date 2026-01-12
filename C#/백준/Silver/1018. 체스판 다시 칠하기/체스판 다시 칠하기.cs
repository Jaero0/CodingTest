public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] NM = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        char[] StartW = new char[]
        {
            'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B',
            'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W',
            'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B',
            'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W',
            'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B',
            'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W',
            'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B',
            'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W'
        };

        char[] StartB = new char[]
        {
            'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W',
            'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B',
            'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W',
            'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B',
            'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W',
            'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B',
            'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W',
            'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B',
        };

        string[] chess = new string[NM[0]];
        for (int i = 0; i < NM[0]; i++) { chess[i] = sr.ReadLine(); }

        int count = 9 * 9;

        for (int i = 0; i < NM[0] - 7; i++)
        {
            for (int j = 0; j < NM[1] - 7; j++)
            {
                //여기부터
                int wCount = 0;
                int bCount = 0;

                for (int k = i; k <= i + 7; k++)
                {
                    for (int l = j; l <= j + 7; l++)
                    {
                        int ind = (k - i) * 7 + (l - j) + (k - i);


                        if (chess[k][l] != StartW[ind]) { wCount++; }

                        if (chess[k][l] != StartB[ind]) { bCount++; }
                    }
                }
                
                count = Math.Min(count, Math.Min(wCount, bCount));
            }
        }

        sw.Write(count);
    }
}