StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] s = sr.ReadLine().Trim().Split(' ');
        
        sw.WriteLine(string.IsNullOrEmpty(s[0]) ? 0 : s.Length);
        
        sr.Close();
        sw.Close();