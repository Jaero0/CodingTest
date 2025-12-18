using System.Collections;

namespace Testt;

public class Solution
{
    class Comp : IComparer<string>
    {
        public int Compare(string s, string s1) 
        {
            if (s.Length != s1.Length)
            {
                return s.Length - s1.Length;
            }

            return string.Compare(s, s1);
        }
    }
    
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int l = int.Parse(sr.ReadLine());

        SortedSet<string> arr = new SortedSet<string>(new Comp());

        for (int i = 0; i < l; i++)
        {
            arr.Add(sr.ReadLine());
        }
        
        foreach (var s in arr)
        {
            sw.WriteLine(s);
        }

        sw.Close();
        sr.Close();
    }
}