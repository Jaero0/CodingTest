StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int count = int.Parse(sr.ReadLine());

        var ageName = new Dictionary<int, List<string>>();
        
        for (int i = 0; i < count; i++)
        {
            string[] input = sr.ReadLine().Split(' ');

            int key = int.Parse(input[0]);
            
            if (ageName.TryGetValue(key, out var list))
            {
                ageName[key].Add(input[1]);
                continue;
            }
            
            ageName.Add(key, new List<string>(){input[1]});
        }

        IOrderedEnumerable<KeyValuePair<int, List<string>>> keyValuePairs = ageName.OrderBy(x => x.Key);

        foreach (var kvp in keyValuePairs)
        {
            int key = kvp.Key;
            var val = kvp.Value;
            
            foreach (var t in val) { sw.WriteLine($"{key} {t}"); }
        }

        sr.Close();
        sw.Close();