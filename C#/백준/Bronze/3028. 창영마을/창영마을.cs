namespace Testt;

public class Solution {
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        bool[] cups = new [] { true, false, false };

        string inp = sr.ReadLine();

        foreach (char c in inp)
        {
            if (c == 'A')
            {
                bool temp = cups[0];
                cups[0] = cups[1];
                cups[1] = temp;
            }
            else if (c == 'B')
            {
                bool temp = cups[1];
                cups[1] = cups[2];
                cups[2] = temp;
            }
            else if (c == 'C')
            {
                bool temp = cups[0];
                cups[0] = cups[2];
                cups[2] = temp;
            }
        }

        for (int i = 0; i < 3; i++)
        {
            if (cups[i] != true) continue;
            
            sw.WriteLine(i + 1);
            break;
        }
        
        sw.Close();
        sr.Close();
    }
    
    
}