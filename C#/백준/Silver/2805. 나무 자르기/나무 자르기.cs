public class Solution
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

    public static int Con(int[] tree, int aim)
    {
        int lo = 0;
        int hi = tree.Max();
        int r = 0;

        while (lo <= hi)
        {
            long sum = 0;
            int pivot = (lo + hi) / 2;
            
            foreach (int i in tree)
            {
                sum += i - pivot <= 0 ? 0 : i - pivot;
            }

            if (sum < aim)
            {
                hi = pivot - 1;
            }
            else if(sum >= aim)
            {
                r = pivot;
                lo = pivot + 1;
            }
        }

        return r;
    }
    
    
    public static void Main(string[] args)
    {
        int[] NM = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        int[] tree = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        
        
        sw.WriteLine(Con(tree, NM[1]));
        

        sr.Close();
        sw.Close();
    }
}