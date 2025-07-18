public class Solution {
    public static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        
        int fFac = Factorial(input[0]);
        int sFac = Factorial(input[1]);
        int fac = Factorial((input[0] - input[1]));

        Console.WriteLine(fFac / (fac * sFac));
    }
    
    public static int Factorial(int i)
    {
        int fac = 1;
        
        if (i == 1)
        {
            return fac;
        }
        
        for (int j = 2; j <= i; j++)
        {
            fac *= j;
        }

        return fac;
    }
}