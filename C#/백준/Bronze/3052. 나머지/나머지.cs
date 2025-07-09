HashSet<int> set = new HashSet<int>();
        
        for (int i = 0; i < 10; i++)
        {
            int input = int.Parse(Console.ReadLine());

            set.Add(input % 42);
        }

        Console.WriteLine(set.Count);