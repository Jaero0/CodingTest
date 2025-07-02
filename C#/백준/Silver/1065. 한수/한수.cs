int s = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 1; i <= s; i++)
        {
            if (i < 100)
            {
                count++;
                continue;
            }

            char[] c = i.ToString().ToCharArray();

            int fHansu = c[0] - '0';
            int sHansu = c[1] - '0';
            int tHansu = c[2] - '0';

            if (sHansu - fHansu == tHansu - sHansu) count++;
        }

        Console.WriteLine(count);