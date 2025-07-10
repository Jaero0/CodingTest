int count = 0;
        int max = -1;
        for (int i = 0; i < 9; i++)
        {
            int inp = int.Parse(Console.ReadLine());

            if (max < inp)
            {
                max = inp;
                count = i + 1;
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(count);