using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

public class Solution {
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] counts = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        string startB = "BWBWBWBWWBWBWBWB";
        string startW = "WBWBWBWBBWBWBWBW";

        var sList = new List<string>();
        
        for (int i = 0; i < counts[0]; i++)
        {
            sList.Add(sr.ReadLine());
        }

        int idxCount = 0;
        int minCount = 100000;
        
        for (int i = 0; i < sList.Count;)
        {

            if (idxCount + 8 > counts[1])
            {
                i++;
                idxCount = 0;
            }
            
            if (i + 8 > counts[0])
            {
                break;
            }

            string[] arr88 = new string[8]; 
            
            for (int j = 0; j < 8; j++)
            {
                string line = sList[i];

                string sub = line.Substring(idxCount,  8);

                arr88[j] = sub;
                i += 1;
            }

            string s = "";
            int wrongCountB = 0;
            int wrongCountW = 0;
            
            for (int j = 0; j < 8; j++)
            {
                s += arr88[j];

                if (j % 2 == 1)
                {
                    for (int k = 0; k < s.Length; k++)
                    {
                        if (s[k] != startB[k])
                        {
                            wrongCountB++;
                        }
                        
                        if (s[k] != startW[k])
                        {
                            wrongCountW++;
                        }
                    }

                    s = "";
                }
            }

            int min = Math.Min(wrongCountB, wrongCountW);

            if (minCount > min)
            {
                minCount = min;
            }

            i -= 8;
            idxCount++;
        }
        
        sw.WriteLine(minCount);
        
        sr.Close();
        sw.Close();
    }
}