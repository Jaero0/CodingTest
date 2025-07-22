StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sr.ReadLine();

        var dict = new Dictionary<string, int>();

        foreach (var s in sr.ReadLine().Split(' '))
        {
            if (dict.TryGetValue(s, out int i))
            {
                dict[s]++;
                continue;
            }
            dict.Add(s, 1);
        }

        sr.ReadLine();

        foreach (var s in sr.ReadLine().Split(' '))
        {
            if (dict.TryGetValue(s, out int i))
            {
                sw.WriteLine(i);
                continue;
            }
            
            sw.WriteLine(0);
        }
        
        
        sr.Close();
        sw.Close();