int c = int.Parse(Console.ReadLine());

        string[] scs = Console.ReadLine().Split(' ');
        double newSum = 0;

        int max = 0;
        foreach (string sc in scs)
        {
            int s = int.Parse(sc);
            newSum += s;
            if (max < s) max = s;
        }

        newSum = newSum / max * 100;

        Console.WriteLine(newSum / c);