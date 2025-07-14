int result = int.Parse(Console.ReadLine());

        int ba = 1;
        while (ba < result)
        {
            string s = ba.ToString();

            int sum = 0;
            foreach (var c in s)
            {
                sum += c - '0';
            }

            if (ba + sum == result)
            {
                break;
            }

            ba++;
        }

        Console.WriteLine(ba == result ? 0 : ba);