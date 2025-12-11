StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int length = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();

        int r = 1;
        int M = 1234567891;

        int sum = 0;
        for (int i = 0; i < length; i++)
        {
            int n = str[i] - 'a' + 1;

            sum += ((n % M) * (r % M));
            r = (r * 31) % M;
        }

        Console.WriteLine(sum);