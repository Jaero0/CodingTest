Stack<int> acc = new Stack<int>();
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

        int count = int.Parse(sr.ReadLine());

        for (int i = 0; i < count; i++)
        {
            int input = int.Parse(sr.ReadLine());

            switch (input)
            {
                case 0:
                    acc.Pop();
                    break;
                default:
                    acc.Push(input);
                    break;
            }
        }

        int sum = 0;
        foreach (var i in acc)
        {
            sum += i;
        }

        Console.WriteLine(sum);