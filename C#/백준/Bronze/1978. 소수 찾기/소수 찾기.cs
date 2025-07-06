Console.ReadLine();

        string[] ss = Console.ReadLine().Split(' ');

        int count = 0;

        foreach (var s in ss)
        {
            int i = int.Parse(s);
            
            if(i == 1) continue;

            int c = 0;
            for (int j = 2; j*j <= i; j++)
            {
                if (i % j == 0)
                {
                    c++;
                }
            }

            if (c == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);