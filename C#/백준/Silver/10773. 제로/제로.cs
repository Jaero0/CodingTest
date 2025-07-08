Stack<int> acc = new Stack<int>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            int input = int.Parse(Console.ReadLine());

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