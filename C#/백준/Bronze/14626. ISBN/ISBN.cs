StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string s = sr.ReadLine();

        int check = s[s.Length - 1] - '0';

        bool isEven = false;
        
        int sum = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '*')
            {
                isEven = i % 2 == 0;
                continue;
            }
            
            int algo = s[i] - '0';
            
            if (i % 2 == 0)
            {
                sum += algo;
            }
            else
            {
                sum += algo * 3;
            }
        }

        int empty = 0;

        sum += check;

        if (isEven)
        {
            for (int i = 1; i < 10; i++)
            {
                if ((sum + i) % 10 == 0)
                {
                    empty = i;
                    break;
                }
            }
        }
        else
        {
            for (int i = 1; i < 10; i++)
            {
                if ((sum + i * 3) % 10 == 0)
                {
                    empty = i;
                    break;
                }
            }
        }
        
        sw.WriteLine(empty);
        

        sr.Close();
        sw.Close();