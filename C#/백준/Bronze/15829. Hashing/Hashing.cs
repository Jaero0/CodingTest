StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int r = 31;

        int L = int.Parse(sr.ReadLine());
        string s = sr.ReadLine();

        long sum = 0;
        long pow = 1;
        for (int i = 0; i < L; i++)
        {
            int cur = s[i] - 'a' + 1;

            sum += cur * pow;
            pow = (pow * r) % 1234567891;
        }
        
        sw.WriteLine(sum % 1234567891);
        
        sr.Close();
        sw.Close();