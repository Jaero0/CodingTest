string input = Console.ReadLine();

        string[] alpha = new string[] {"dz=", "lj", "nj", "c=", "c-", "d-", "s=", "z="};

        int count = 0;
        foreach (var s in alpha)
        {
            if (!input.Contains(s))
            {
                continue;
            }
            
            var strings = input.Split(s);

            count += strings.Length - 1;

            input = input.Replace(s, ",");
        }

        count += input.Replace(",", "").Length;

        Console.WriteLine(count);