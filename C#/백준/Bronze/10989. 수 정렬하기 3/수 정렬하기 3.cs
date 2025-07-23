StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        int L = int.Parse(sr.ReadLine());

        var list = new Dictionary<int, int>();


        for (int i = 0; i < L; i++)
        {
            int inp = int.Parse(sr.ReadLine());

            if (!list.TryAdd(inp, 1))
            {
                list[inp]++;
            }
        }

        IOrderedEnumerable<KeyValuePair<int, int>> keyValuePairs = list.OrderBy(kvp => kvp.Key);

        foreach (KeyValuePair<int, int> kvp in keyValuePairs)
        {
            for (int i = 0; i < kvp.Value; i++)
            {
                sw.WriteLine(kvp.Key);
            }
        }

        sr.Close();
        sw.Close();