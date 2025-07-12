StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

        int gugu = int.Parse(sr.ReadLine());
        var list = new List<string>();

        for (int i = 0; i < gugu; i++)
        {
            var readLine = sr.ReadLine();
            
            list.Add(readLine);
        }
        
        list.Sort((a, b) =>
        {
            if (a.Length == b.Length)
            {
                return a.CompareTo(b);
            }
            
            return a.Length - b.Length;
        } );

        for (int i = 0; i < gugu; i++)
        {
            if (i != 0 && list[i] == list[i - 1])
            {
                continue;
            }
            
            sw.WriteLine(list[i]);
        }

        sr.Close();
        sw.Close();