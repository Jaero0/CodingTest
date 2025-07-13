StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

        string gugu = sr.ReadLine();

        char[] inp = sr.ReadLine().ToCharArray();

        int sum = 0;
        
        Array.ForEach(inp, i => sum += i - '0');

        Console.WriteLine(sum);
        
        sr.Close();