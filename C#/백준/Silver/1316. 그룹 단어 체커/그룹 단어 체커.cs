int count = int.Parse(Console.ReadLine());

        int cc = 0;
        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();

            string check = "";

            foreach (char c in input)
            {
                if (check.LastIndexOf(c) == -1)
                {
                    check += c;
                }
                else if (check.LastIndexOf(c) == check.Length - 1)
                {
                    check += c;
                }
                else
                {
                    break;
                }
            }

            if (check == input)
            {
                cc++;
            }
        }

        Console.WriteLine(cc);