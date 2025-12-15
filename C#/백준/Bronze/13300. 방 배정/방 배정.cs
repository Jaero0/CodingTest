namespace Testt;

public class Solution {
    class StudentCount
    {
        public int girl;
        public int boy;
    }
    
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] nm = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        

        Dictionary<int, StudentCount> gradeCount = new Dictionary<int, StudentCount>();

        for (int i = 0; i < nm[0]; i++)
        {
            int[] t = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            if (!gradeCount.ContainsKey(t[1]))
            {
                StudentCount sc = new StudentCount();
                gradeCount.Add(t[1], sc);
            }
            
            StudentCount Count = gradeCount[t[1]];

            if (t[0] == 0)
            {
                Count.girl++;
            }
            else
            {
                Count.boy++;
            }
        }

        int sum = 0;
        foreach (KeyValuePair<int,StudentCount> kvp in gradeCount)
        {
            sum += kvp.Value.boy / nm[1];
            sum += kvp.Value.boy % nm[1] != 0 ? 1 : 0;
            sum += kvp.Value.girl / nm[1];
            sum += kvp.Value.girl % nm[1] != 0 ? 1 : 0;
        }

        Console.WriteLine(sum);
        
        sw.Close();
        sr.Close();
    }
}