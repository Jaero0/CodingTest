int sum = 0;
        
        Array.ForEach(Console.ReadLine().Split(' '), s =>
        {
            var i = int.Parse(s);
            sum += i * i;
        });

        Console.WriteLine(sum % 10);