namespace Testt;

public class Solution {
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        //3 2 5 -> 3, 1, 4, 2, 5
        //3 1 5 -> 3, 2, 5
        //5 2 11-> 5, 3, 8, 6, 11
        //5 2 12-> 5, 3, 8, 6, 11, 9, 14

        int[] abc = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        int minArrive = abc[2] - abc[0];
        int i = minArrive % (abc[0] - abc[1]) == 0 ? minArrive / (abc[0] - abc[1]) : minArrive / (abc[0] - abc[1]) + 1;
        
        sw.WriteLine(i+1);
        
        sw.Close();
        sr.Close();
    }
}