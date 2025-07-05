string s = Console.ReadLine();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        s = s.ToUpper();

        foreach (var c in s)
        {
            if (!dict.TryAdd(c, 1))
            {
                dict[c]++;
                continue;
            }
        }

        var max = dict.Values.Max();

        char cc = ' ';
        int count = 0;

        foreach (var i in dict)
        {
            if (i.Value == max)
            {
                cc = i.Key;
                count++;
            }
        }

        Console.WriteLine(count > 1 ? "?" : cc);