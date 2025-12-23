public class Solution
{
    class YN
    {
        public int height;
        public int weight;

        public YN(int height, int weight)
        {
            this.height = height;
            this.weight = weight;
        }
    }
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(sr.ReadLine());

        List<YN> list = new List<YN>();

        for (int i = 0; i < n; i++)
        {
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            list.Add(new YN(arr[1], arr[0]));
        }

        for (int i = 0; i < n; i++)
        {
            int count = 1;
            YN originKey = list[i];
            
            for (int j = 0; j < n; j++)
            {
                if (j == i)
                {
                    continue;
                }

                if (list[j].height > originKey.height && list[j].weight > originKey.weight)
                {
                    count++;
                }
            }

            sw.Write(count + " ");
        }
        
        sw.Close();
        sr.Close();
    }
}