StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sr.ReadLine();

        string[] A = sr.ReadLine().Split(' ');

        sr.ReadLine();
        
        string[] M = sr.ReadLine().Split(' ');

        var dict = new Dictionary<string, bool>();

        foreach (string s in A)
        {
            if (dict.TryGetValue(s, out var b))
            {
                dict[s] = true;
            }
            else
            {
                dict.Add(s, true);
            }
        }

        foreach (var s in M)
        {
            if (dict.TryGetValue(s, out var b))
            {
                sw.WriteLine(1);
            }
            else
            {
                sw.WriteLine(0);
            }
        }
        
        
        sr.Close();
        sw.Close();