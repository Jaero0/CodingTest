string input = Console.ReadLine();
        if (input.Length == 1) input = "0" + input;

        string origin = input;
        int count = 0;

        while (true)
        {
            char[] s = input.ToCharArray();

            int sum = s[0] - '0' + (s[1] - '0') ;

            input = s[1].ToString() + sum % 10;
            count++;

            if (input == origin)
            {
                break;
            }
        }

        Console.WriteLine(count);