public class Solution
{
    class XY
    {
        public int X;
        public int Y;

        public XY(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(sr.ReadLine());

        var list = new List<XY>();

        for (int i = 0; i < n; i++)
        {
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            list.Add(new XY(arr[0], arr[1]));
        }
        
        list.Sort((xy1, xy2) =>
        {
            int cmpY = xy1.Y - xy2.Y;

            if (cmpY == 0)
            {
                return xy1.X - xy2.X;
            }

            return cmpY;
        });
        
        list.ForEach(xy => sw.WriteLine(xy.X + " " + xy.Y));
        
        sw.Close();
        sr.Close();
    }
}