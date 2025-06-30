int c = int.Parse(Console.ReadLine());

        int fiveCount = c / 5;
        int threeCount = 0;

        bool isNot = false;

        c -= fiveCount * 5;

        while (true)
        {
            if (c % 3 == 0)
            {
                threeCount = c / 3;
                break;
            }

            fiveCount--;
            c += 5;

            if (fiveCount < 0)
            {
                isNot = true;
                break;
            }
        }

        Console.WriteLine(isNot == true ? -1 : fiveCount + threeCount);