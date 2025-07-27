StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int input = int.Parse(sr.ReadLine());

        int calc = 1;
        int zeroCount = 0;

        while (input >= 5)
        {
            zeroCount += input / 5;
            input /= 5;
        }
        
        sw.WriteLine(zeroCount);
        
        sr.Close();
        sw.Close();