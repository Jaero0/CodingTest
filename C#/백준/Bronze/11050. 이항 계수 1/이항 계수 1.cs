namespace Testt;

public class Solution {
    
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] fact = new int[11];
        fact[0] = 1;
        fact[1] = 1;

        for (int i = 2; i < 11; i++)
        {
            fact[i] = fact[i - 1] * i;
        }

        int[] NK = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine(fact[NK[0]] / (fact[NK[1]] * fact[NK[0] - NK[1]]));
        
        sw.Close();
        sr.Close();
    }
}