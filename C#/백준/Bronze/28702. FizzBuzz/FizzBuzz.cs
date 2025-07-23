static string ReturnFizzBuzz(int t)
        {
            if (t % 3 == 0 && t % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (t % 3 == 0 && t % 5 != 0)
            {
                return "Fizz";
            }

            if (t % 3 != 0 && t % 5 == 0)
            {
                return "Buzz";
            }
            
            return t.ToString();
        }
        
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string f = sr.ReadLine();
        string s = sr.ReadLine();
        string t = sr.ReadLine();

        if (int.TryParse(t, out int tResult))
        {
            sw.WriteLine(ReturnFizzBuzz(tResult + 1));
        }
        else if (int.TryParse(s, out int sResult))
        {
            sw.WriteLine(ReturnFizzBuzz(sResult + 2));
        }
        else if (int.TryParse(f, out int fResult))
        {
            sw.WriteLine(ReturnFizzBuzz(fResult + 3));
        }
        else
        {
            sw.WriteLine("FizzBuzz");
        }
        
        sr.Close();
        sw.Close();