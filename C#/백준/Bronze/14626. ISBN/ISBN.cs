namespace Testt;

public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string isbn = sr.ReadLine();

        int sum = 0;
        int asteriskMul = 0;
        for (int i = 0; i < 13; i++)
        {
            int mul = i % 2 == 0 ? 1 : 3;

            if (isbn[i] == '*')
            {
                asteriskMul = mul;
                continue;
            }

            sum += (isbn[i] - '0') * mul;
        }

        for (int i = 0; i < 10; i++)
        {
            if ((sum + asteriskMul * i) % 10 == 0)
            {
                sw.WriteLine(i);
                break;
            }
        }

        sw.Close();
        sr.Close();
    }
}