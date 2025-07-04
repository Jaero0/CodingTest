int input = int.Parse(Console.ReadLine());

        bool[] bools = new bool[input + 1];
        bools[0] = true;
        bools[1] = true;
        
        
        for (int i = 2; i * i <= input; i++)
        {
            for (int j = i * i; j <= input; j+=i)
            {
                bools[j] = true;
            }
        }
        
        StreamWriter sw = new (new BufferedStream(Console.OpenStandardOutput()));

        for (int i = 0; i < bools.Length; i++)
        {
            if (bools[i] == false)
            {
                while (input % i == 0)
                {
                    input /= i;
                    sw.WriteLine(i);
                }
            }

            if (i == input)
            {
                break;
            }
        }
        sw.Close();