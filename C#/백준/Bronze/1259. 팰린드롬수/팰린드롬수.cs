namespace Testt;

public class Solution {
    
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        while (true)
        {
            string s = sr.ReadLine();

            if (s.Equals("0")) break;

            bool isSame = true;
            for (int i = 0; i < s.Length / 2; i++)
            {
                char f = s[i];
                char se = s[s.Length - i - 1];

                if (f != se)
                {
                    isSame = false;
                    break;
                }
            }
            
            sw.WriteLine(isSame ? "yes" : "no");
        }
        
        sw.Close();
        sr.Close();
    }
}