StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int r = 31;

        int L = int.Parse(sr.ReadLine());
        string s = sr.ReadLine();

        long sum = 0;
        for (int i = 0; i < L; i++)
        {
            int cur = s[i] - 'a' + 1;

            long pow = (long)Math.Pow(r, i);

            sum += cur * pow;
        }
        
        sw.WriteLine(sum);
        
        sr.Close();
        sw.Close();