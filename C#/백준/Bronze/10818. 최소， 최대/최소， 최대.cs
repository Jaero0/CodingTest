Console.ReadLine();

        string[] inputs = Console.ReadLine().Split(' ');

        int max = -1000001;
        int min = 1000001;

        foreach (var input in inputs)
        {
            int i = int.Parse(input);

            if (i > max)
            {
                max = i;
            }

            if (i < min)
            {
                min = i;
            }
        }

        Console.WriteLine($"{min} {max}");