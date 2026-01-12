public class Solution
{
    public static void Main(string[] args)
    {
        using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int T = int.Parse(sr.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int[] NM = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] priority = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();

            for (int j = 0; j < NM[0]; j++)
            {
                q.Enqueue(KeyValuePair.Create(j, priority[j]));
            }

            int count = 0;
            int maxCount = NM[0];
            int dequeueCount = 0;
            
            while (true)
            {
                var check = q.Dequeue();

                bool isThereHigherPriority = false;

                while (count < maxCount - 1)
                {
                    var compared = q.Dequeue();
                    
                    if (check.Value < compared.Value)
                    {
                        isThereHigherPriority = true;
                    }
                    
                    q.Enqueue(compared);
                    count++;
                }

                if (isThereHigherPriority == true)
                {
                    q.Enqueue(check);
                }
                else
                {
                    if (check.Key == NM[1])
                    {
                        sw.WriteLine(dequeueCount + 1);
                        break;
                    }

                    maxCount--;
                    dequeueCount++;
                }
                
                count = 0;
            }
        }
    }
}