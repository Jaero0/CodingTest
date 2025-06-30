int f = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());

        int pow = 0;
        int sum = 0;
        
        while (s > 0)
        {
            int mul = f * (s % 10);
            Console.WriteLine(mul);

            sum += mul * (int)Math.Pow(10, pow);

            pow++;
            s /= 10;
        }

        Console.WriteLine(sum);