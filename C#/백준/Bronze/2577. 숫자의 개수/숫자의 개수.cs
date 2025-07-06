int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int ii = a * b * c;

        int[] arr = new int[10];

        while (ii > 0)
        {
            arr[ii % 10]++;
            ii /= 10;
        }

        StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
        foreach (var i in arr)
        {
            sw.WriteLine(i);
        }
        sw.Close();