int c = int.Parse(Console.ReadLine());
        string[] inputs = new string[c];

        for (int i = 0; i < c; i++)
        {
            inputs[i] = Console.ReadLine();
        }

        foreach (string input in inputs)
        {
            string[] s = input.Split(' ');

            double sum = 0.0;
            
            for (int i = 1; i < s.Length; i++)
            {
                sum += int.Parse(s[i]);
            }

            
            int totalCount = s.Length - 1;
            double avg = sum / totalCount;
            double overCount = 0.0;

            for (int i = 1; i < s.Length; i++)
            {
                if (avg < int.Parse(s[i])) overCount += 1.0;
            }

            double rate = overCount / totalCount * 100;

            rate = Math.Round(rate, 3);

            Console.WriteLine(rate.ToString("n3") + "%");
        }