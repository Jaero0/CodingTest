int start = 1;

        int input = int.Parse(Console.ReadLine());

        int count = 0;

        while (start < input)
        {
            count++;
            start += 6 * count;
        }

        Console.WriteLine(count+1);