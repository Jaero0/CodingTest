string s = Console.ReadLine().Replace(" ", "");

        if (s.Equals("12345678"))
        {
            Console.WriteLine("ascending");
        }
        else if (s.Equals("87654321"))
        {
            Console.WriteLine("descending");
        }
        else
        {
            Console.WriteLine("mixed");
        }