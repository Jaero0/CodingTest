int sum = 0;
        foreach (var se in Console.ReadLine().Split(' '))
        {
            sum += int.Parse(se);
        }

        Console.WriteLine(sum);