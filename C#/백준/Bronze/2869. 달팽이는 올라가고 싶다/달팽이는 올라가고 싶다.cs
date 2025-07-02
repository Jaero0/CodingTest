string[] inputs = Console.ReadLine().Split(' ');

        int climb = int.Parse(inputs[0]);
        int fall = int.Parse(inputs[1]);
        int max = int.Parse(inputs[2]);

        var b = (max - fall) % (climb - fall) == 0;
        var c = (max - fall) / (climb - fall);
        Console.WriteLine(b ? c : c + 1 );

        //n = days
        //-fall * (n - 1) + climb  * n >= max 
        //-fall * n + fall + climb * n >= max
        //-fall * n + climb * n >= max - fall
        //(climb-fall) * n >= max - fall
        //n = (max - fall) / (climb - fall)