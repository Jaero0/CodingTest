public class Solution
{
    private static int[] moveX = new int[4] { 1, -1, 0, 0 };
    private static int[] moveY = new int[4] { 0, 0, 1, -1 };

    struct XY
    {
        public int x;
        public int y;

        public XY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int T = int.Parse(sr.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int[] MNK = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int[,] field = new int[MNK[0], MNK[1]];

            //1. Init
            for (int j = 0; j < MNK[2]; j++)
            {
                int[] t = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                field[t[0], t[1]] = 1;
            }

            //2. BFS
            int worm = 0;
            bool[,] visited = new bool[MNK[0], MNK[1]];
            Queue<XY> haveToVisit = new Queue<XY>();

            for (int j = 0; j < MNK[0]; j++)
            {
                for (int k = 0; k < MNK[1]; k++)
                {
                    if (field[j, k] != 1 || visited[j, k] == true) continue;

                    haveToVisit.Enqueue(new XY(j, k));
                    worm++;

                    while (haveToVisit.Count > 0)
                    {
                        var xy = haveToVisit.Dequeue();

                        for (int l = 0; l < 4; l++)
                        {
                            int newX = xy.x + moveX[l];
                            int newY = xy.y + moveY[l];

                            if (newX < 0 || newX >= MNK[0] || newY < 0 || newY >= MNK[1]) continue;
                            if (visited[newX, newY] == true) continue;
                            if (field[newX, newY] != 1) continue;

                            haveToVisit.Enqueue(new XY(newX, newY));
                            visited[newX, newY] = true;
                        }
                    }
                }
            }

            sw.WriteLine(worm);
        }
    }
}