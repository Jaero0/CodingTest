string s = Console.ReadLine().Replace(" ", "");

        switch (s)
        {
            case "12345678": Console.WriteLine("ascending"); break;
            case "87654321": Console.WriteLine("descending"); break;
            default: Console.WriteLine("mixed"); break;
        }