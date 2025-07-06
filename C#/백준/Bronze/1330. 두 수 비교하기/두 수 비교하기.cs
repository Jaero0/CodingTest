string[] ss = Console.ReadLine().Split(' ');

        int a = int.Parse(ss[0]);
        int b = int.Parse(ss[1]);

        Console.WriteLine(a == b ? "==" : a > b ? ">" : "<");