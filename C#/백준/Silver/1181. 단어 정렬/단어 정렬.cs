StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

        int gugu = int.Parse(sr.ReadLine());
        var list = new List<string>();

        for (int i = 0; i < gugu; i++)
        {
            var readLine = sr.ReadLine();
            
            if (list.Contains(readLine))
            {
                continue;
            }
            
            list.Add(readLine);
        }
        
        list.Sort((s1, s2) =>
        {
            if (s1.Length < s2.Length)
            {
                return -1;
            }

            if (s1.Length > s2.Length)
            {
                return 1;
            }

            return s1.CompareTo(s2);
        } );
        
        list.ForEach(s => sw.WriteLine(s));

        sr.Close();
        sw.Close();