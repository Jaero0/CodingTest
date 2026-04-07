public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

    private static int c1 = 0;
    private static int c2 = 0;
    
    public static void Con(List<int[]> sq, int yMin, int yMax, int xMin, int xMax)
    {
        int prv = sq[yMin][xMin];
        bool isPass = true;
        
        for (int i = yMin; i < yMax; i++)
        {
            for (int j = xMin; j < xMax; j++)
            {
                if (sq[i][j] != prv)
                {
                    isPass = false;

                    int yMid = (yMin + yMax) / 2;
                    int xMid = (xMin + xMax) / 2;
                    
                    //1
                    Con(sq, yMin, yMid, xMin, xMid);
                    //2
                    Con(sq, yMin, yMid, xMid, xMax);
                    //3
                    Con(sq, yMid, yMax, xMin, xMid);
                    //4
                    Con(sq, yMid, yMax, xMid, xMax);

                    return;
                }
            }
        }

        if (!isPass) return;
        if (prv == 1)
        {
            c1 += 1;
        }
        else
        {
            c2 += 1;
        }
    }
    
    public static void Main(string[] args)
    {
        int K = int.Parse(sr.ReadLine());

        List<int[]> sq = new List<int[]>();

        for (int i = 0; i < K; i++)
        {
            int[] t = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            sq.Add(t);
        }
        
        Con(sq, 0, K, 0, K);
        
        sw.WriteLine(c2);
        sw.WriteLine(c1);

        sr.Close();
        sw.Close();
    }
}