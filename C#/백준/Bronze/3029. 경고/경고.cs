namespace Testt;

public class Solution {
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] first = Array.ConvertAll(sr.ReadLine().Split(':'), int.Parse);
        int[] second = Array.ConvertAll(sr.ReadLine().Split(':'), int.Parse);

        int sec, min, hr = 0;
        if (second[2] < first[2]) //sec
        {
            second[1]--;
            sec = second[2] + 60 - first[2];
        }
        else
        {
            sec = second[2] - first[2];
        }

        if (second[1] < first[1])//min
        {
            second[0]--;
            min = second[1] + 60 - first[1];
        }
        else
        {
            min = second[1] - first[1];
        }

        hr = second[0] - first[0] < 0 ? second[0] - first[0] + 24 : second[0] - first[0];

        if (sec == 0 && min == 0 && hr == 0)
        {
            sw.WriteLine("24:00:00");
        }
        else
        {
            sw.Write(hr < 10 ? $"0{hr}:" : $"{hr}:");
            sw.Write(min < 10 ? $"0{min}:" : $"{min}:");
            sw.Write(sec < 10 ? $"0{sec}" : $"{sec}");
        }
        
        sw.Close();
        sr.Close();
    }
    
    
}