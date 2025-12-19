using System.Collections;

namespace Testt;

public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        //666 1666 2666 3666 4666 5666 6661 6662 6663 6664 6665 6666 6667 6668 6669 7666 8666 9666
        //10666 11666 12666 13666 14666 15666 16661 16662 16663 16664 16665 16666 16667 16668 16669 17666 18666 19666
        //20666
        //100666 101666 102666 103666
        //116660

        int n = int.Parse(sr.ReadLine());
        int ans = 666;
        int count = 1;

        while (count < n)
        {
            ans++;

            if (ans.ToString().Contains("666"))
            {
                count++;
            }
        }
        
        sw.WriteLine(ans);

        sw.Close();
        sr.Close();
    }
}