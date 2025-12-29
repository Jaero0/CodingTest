using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        while (true)
        {
            string parse = sr.ReadLine();

            if (parse.Equals("."))
            {
                break;
            }

            Stack<char> s = new Stack<char>();
            bool isNot = false;

            foreach (var c in parse)
            {
                if (c == '(' || c == '[')
                {
                    s.Push(c);
                }
                else if (c == ')' || c == ']')
                {
                    if (s.Count == 0)
                    {
                        isNot = true;
                        break;
                    }
                    
                    if (c == ')')
                    {
                        if (s.Peek() == '(')
                        {
                            s.Pop();
                        }
                        else
                        {
                            isNot = true;
                            break;
                        }
                    }
                    else
                    {
                        if (s.Peek() == '[')
                        {
                            s.Pop();
                        }
                        else
                        {
                            isNot = true;
                            break;
                        }
                    }
                }
            }
            
            sw.WriteLine(s.Count == 0 && isNot == false ? "yes" : "no");
        }

        sw.Close();
        sr.Close();
    }
}